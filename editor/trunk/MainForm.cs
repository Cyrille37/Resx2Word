using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Resources;
using System.Text;
using System.Xml;
using System.Windows.Forms;

using ResxEditor.Properties;

namespace ResxEditor
{
    public partial class MainForm : Form
    {
        string xmlFileName = "";
        ResXResourceSet resourceSet;
        XmlDataDocument xmlDocument;

        bool isDocumentOpen = false;
        bool isDataModified = false;

        float defaultTextSize;
        #region Constructor
        public MainForm(string[] args)
        {
            InitializeComponent();

            xmlGridView.CellValueChanged += new DataGridViewCellEventHandler(xmlGridView_CellValueChanged);
            xmlGridView.CellBeginEdit += new DataGridViewCellCancelEventHandler(xmlGridView_CellBeginEdit);
            xmlGridView.CurrentCellDirtyStateChanged += new EventHandler(xmlGridView_CurrentCellDirtyStateChanged);
            peopleWordsLink.Text = Resources.Motto;
            this.Text = Resources.Title;
            if (args.Length > 0)
            {
                OpenFile(args[0]);
            }
        }
        #endregion

        #region methods - main logic stored here
        #region OpenFile
        private void OpenFile(string fileName)
        {
            FileStream file;
            try
            {
                xmlDocument = new XmlDataDocument();
                xmlDocument.DataSet.ReadXmlSchema(fileName);
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                xmlDocument.Load(file);
                file.Close();
                xmlGridView.DataSource = xmlDocument.DataSet;
                xmlGridView.DataMember = "data";

                //we need this to exclude non-text fields
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                resourceSet = new ResXResourceSet(file);
            }
            catch (Exception ex)
            {
                isDocumentOpen = false;
                ReportError(ex.Message);
                return;
            }

            xmlFileName = fileName;
            InitGrid();

            //hide non-text fields
            foreach (DictionaryEntry d in resourceSet)
            {
                if (d.Value.GetType() != (new string('a', 1).GetType()))
                {
                    foreach (DataGridViewRow row in xmlGridView.Rows)
                    {
                        if (row.Cells["name"].Value.ToString() == d.Key.ToString())
                            row.Visible = false;
                    }
                }
            }
            //release resources
            resourceSet.Close();
            file.Close();
            
            isDataModified = false;
            isDocumentOpen = true;
            UpdateForm();
        }
        #endregion
        #region InitGrid
        private void InitGrid()
        {
            xmlGridView.AutoGenerateColumns = true;
            xmlGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            defaultTextSize = xmlGridView.DefaultCellStyle.Font.Size;

            //hiding all columns
            foreach (DataGridViewColumn col in xmlGridView.Columns)
            {
                col.Visible = false;
            }

            //show and set up the Value column
            xmlGridView.Columns["value"].Visible = true;
            xmlGridView.Columns["value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            xmlGridView.Columns["value"].HeaderText = Resources.ValueHeader;
            xmlGridView.Columns["value"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //show and set up the Comment column
            xmlGridView.Columns["comment"].Visible = true;
            xmlGridView.Columns["comment"].ReadOnly = true;
            xmlGridView.Columns["comment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            xmlGridView.Columns["comment"].HeaderText = Resources.CommentHeader;
            xmlGridView.Columns["comment"].DefaultCellStyle.BackColor = Color.LightGray;
            xmlGridView.Columns["comment"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //set up the Name column
            xmlGridView.Columns["name"].HeaderText = Resources.NameHeader;
            xmlGridView.Columns["name"].ReadOnly = true;
            xmlGridView.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            xmlGridView.Columns["name"].DefaultCellStyle.BackColor = Color.LightGray;
            xmlGridView.Columns["name"].SortMode = DataGridViewColumnSortMode.NotSortable;

            // auto-resize rows
            xmlGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        #endregion
        #region UpdateForm
        private void UpdateForm()
        {
            if (xmlFileName == null || xmlFileName == string.Empty)
            {
                this.Text = Resources.FormTitle;
            }
            else
            {
                string star = isDataModified ? "*" : "";

                int index = Math.Max(xmlFileName.LastIndexOf('\\') + 1, 0);
                this.Text = xmlFileName.Substring(index) + star + " - " + Resources.FormTitle;
            }

            textSizeMenuItem.Enabled = isDocumentOpen;
            saveMenuItem.Enabled = isDocumentOpen;
            saveAsMenuItem.Enabled = isDocumentOpen;
            wordCountMenuItem.Enabled = isDocumentOpen;
            showKeysToolStripMenuItem.Enabled = isDocumentOpen;
        }
        #endregion
        #region ReportError
        private void ReportError(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region ConfirmFileSave
        private bool ConfirmFileSave(string message)
        {
            DialogResult res;
            res = MessageBox.Show(message, Resources.UnsavedChangesCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (res)
            {
                case DialogResult.Cancel:
                    return false;
                case DialogResult.No:
                    return true;
                default:// DialogResult.Yes:
                    SaveFile();
                    return true;
            }
        } 
        #endregion
        #region SaveFile
        private void SaveFile()
        {
            this.Validate();
            xmlGridView.EndEdit();
            CurrencyManager cm = (CurrencyManager)xmlGridView.BindingContext[xmlGridView.DataSource, "data"];
            cm.EndCurrentEdit();
            xmlDocument.Save(xmlFileName);
            isDataModified = false;
            UpdateForm();
        } 
        #endregion
        #endregion
        #region event handlers
        #region xmlGridView_CurrentCellDirtyStateChanged - unused
        void xmlGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            isDataModified = true;
            return;
        } 
        #endregion
        #region xmlGridView_CellBeginEdit - unused
        void xmlGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            return;
        } 
        #endregion
        #region OnClosing
        protected override void OnClosing(CancelEventArgs e)
        {
            if (isDataModified)
            {
                if (!ConfirmFileSave(Resources.UnsavedChangesExit))
                {
                    e.Cancel = true;
                    return;
                }
            }
            base.OnClosing(e);
        } 
        #endregion
        #region xmlGridView_CellValueChanged
        void xmlGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateForm();
        } 
        #endregion
        #endregion

        #region menu items
        #region openMenuItem_Click
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (isDataModified)
            {
                if (!ConfirmFileSave(Resources.UnsavedChanges))
                    return;
            }
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = Resources.ResxFilesFilter + " (*.resx)|*.resx|"
                + Resources.AllFilesFilter + " (*.*)|*.*";

            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(dialog.FileName);
            }
        } 
        #endregion
        #region exitMenuItem_click
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion
        #region save_MenuItem_click
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        } 
        #endregion
        #region saveAsMenuItem_click
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream;
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = Resources.ResxFilesFilter + " (*.resx)|*.resx|"
                + Resources.AllFilesFilter + " (*.*)|*.*";

            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = dialog.OpenFile()) != null)
                {
                    fileStream.Close();
                    xmlFileName = dialog.FileName;
                    SaveFile();
                }

                isDataModified = false;
                UpdateForm();
            }
        } 
        #endregion
        #region increaseTextSizeMenuItem_Click
        private void increaseTextSizeMenuItem_Click(object sender, EventArgs e)
        {
            xmlGridView.Font = new Font(xmlGridView.Font.FontFamily, xmlGridView.Font.Size * 1.2f);
            xmlGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        } 
        #endregion
        #region decreaseTextSizeMenuItem_Click
        private void decreaseTextSizeMenuItem_Click(object sender, EventArgs e)
        {
            xmlGridView.Font = new Font(xmlGridView.Font.FontFamily, xmlGridView.Font.Size / 1.2f);
            xmlGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        } 
        #endregion
        #region defaultTextSizeMenuItem_Click
        private void defaultTextSizeMenuItem_Click(object sender, EventArgs e)
        {
            xmlGridView.Font = new Font(xmlGridView.Font.FontFamily, defaultTextSize);
            xmlGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        } 
        #endregion
        #region aboutUsMenuItem_Click
        private void aboutUsMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        } 
        #endregion
        #region peopleWordsLink_LinkClicked
        private void peopleWordsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.peoplewords.com");
        } 
        #endregion
        #region printMenuItem_Click
        private void printMenuItem_Click(object sender, EventArgs e)
        {
            // caution: menu item have been set as invisible.
            // TODO: Implement print
        } 
        #endregion
        #region wordCountMenuItem_Click
        private void wordCountMenuItem_Click(object sender, EventArgs e)
        {
            int wordCount = 0;
            foreach (DataGridViewRow row in xmlGridView.Rows)
            {
                string rowText = (string)row.Cells["value"].Value;
                wordCount += rowText.Split(
                    new char[] { ' ', ',', ';', '.', '\t', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries).Length;
            }

            MessageBox.Show(Resources.WordCountLine + " " + wordCount,
                Resources.DocumentStatistics, MessageBoxButtons.OK);
        } 
        #endregion
        #region showKeysToolStripMenuItem_Click
        private void showKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show/hide Name column of the DataGrid
            xmlGridView.Columns["name"].Visible ^= true; //bool xor true == !bool
        }
	    #endregion
        #endregion
    }
}