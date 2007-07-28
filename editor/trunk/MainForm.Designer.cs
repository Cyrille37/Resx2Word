using System.Resources;

using ResxEditor.Properties;

namespace ResxEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseTextSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseTextSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.defaultTextSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.wordCountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlGridView = new System.Windows.Forms.DataGridView();
            this.fileStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmlGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileStrip
            // 
            this.fileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.helpMenu});
            this.fileStrip.Location = new System.Drawing.Point(0, 0);
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(632, 24);
            this.fileStrip.TabIndex = 0;
            this.fileStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator3,
            this.printMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(35, 20);
            this.fileMenu.Text = global::ResxEditor.Properties.Resources.FileMenu;
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openMenuItem.Text = global::ResxEditor.Properties.Resources.OpenCommand;
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Enabled = false;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveMenuItem.Text = global::ResxEditor.Properties.Resources.SaveCommand;
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveAsMenuItem.Text = global::ResxEditor.Properties.Resources.SaveAsCommand;
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printMenuItem.Text = "Print";
            this.printMenuItem.Visible = false;
            this.printMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = global::ResxEditor.Properties.Resources.ExitCommand;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSizeMenuItem,
            this.toolStripSeparator4,
            this.wordCountMenuItem,
            this.showKeysToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(41, 20);
            this.viewMenu.Text = global::ResxEditor.Properties.Resources.ViewMenu;
            // 
            // textSizeMenuItem
            // 
            this.textSizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseTextSizeMenuItem,
            this.decreaseTextSizeMenuItem,
            this.toolStripSeparator2,
            this.defaultTextSizeMenuItem});
            this.textSizeMenuItem.Enabled = false;
            this.textSizeMenuItem.Name = "textSizeMenuItem";
            this.textSizeMenuItem.Size = new System.Drawing.Size(132, 22);
            this.textSizeMenuItem.Text = global::ResxEditor.Properties.Resources.TextSizeCommand;
            // 
            // increaseTextSizeMenuItem
            // 
            this.increaseTextSizeMenuItem.Name = "increaseTextSizeMenuItem";
            this.increaseTextSizeMenuItem.ShortcutKeyDisplayString = "Ctrl++";
            this.increaseTextSizeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.increaseTextSizeMenuItem.Size = new System.Drawing.Size(156, 22);
            this.increaseTextSizeMenuItem.Text = global::ResxEditor.Properties.Resources.IncreaseTextSizeCommand;
            this.increaseTextSizeMenuItem.Click += new System.EventHandler(this.increaseTextSizeMenuItem_Click);
            // 
            // decreaseTextSizeMenuItem
            // 
            this.decreaseTextSizeMenuItem.Name = "decreaseTextSizeMenuItem";
            this.decreaseTextSizeMenuItem.ShortcutKeyDisplayString = "Ctrl+-";
            this.decreaseTextSizeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.decreaseTextSizeMenuItem.Size = new System.Drawing.Size(156, 22);
            this.decreaseTextSizeMenuItem.Text = global::ResxEditor.Properties.Resources.DecreaseTextSizeCommand;
            this.decreaseTextSizeMenuItem.Click += new System.EventHandler(this.decreaseTextSizeMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // defaultTextSizeMenuItem
            // 
            this.defaultTextSizeMenuItem.Name = "defaultTextSizeMenuItem";
            this.defaultTextSizeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.defaultTextSizeMenuItem.Size = new System.Drawing.Size(156, 22);
            this.defaultTextSizeMenuItem.Text = global::ResxEditor.Properties.Resources.DefaultTextSizeCommand;
            this.defaultTextSizeMenuItem.Click += new System.EventHandler(this.defaultTextSizeMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(129, 6);
            // 
            // wordCountMenuItem
            // 
            this.wordCountMenuItem.Enabled = false;
            this.wordCountMenuItem.Name = "wordCountMenuItem";
            this.wordCountMenuItem.Size = new System.Drawing.Size(132, 22);
            this.wordCountMenuItem.Text = global::ResxEditor.Properties.Resources.WordCountCommand;
            this.wordCountMenuItem.Click += new System.EventHandler(this.wordCountMenuItem_Click);
            // 
            // showKeysToolStripMenuItem
            // 
            this.showKeysToolStripMenuItem.CheckOnClick = true;
            this.showKeysToolStripMenuItem.Enabled = false;
            this.showKeysToolStripMenuItem.Name = "showKeysToolStripMenuItem";
            this.showKeysToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.showKeysToolStripMenuItem.Text = "View Keys";
            this.showKeysToolStripMenuItem.Click += new System.EventHandler(this.showKeysToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(40, 20);
            this.helpMenu.Text = global::ResxEditor.Properties.Resources.HelpMenu;
            // 
            // aboutUsMenuItem
            // 
            this.aboutUsMenuItem.Name = "aboutUsMenuItem";
            this.aboutUsMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutUsMenuItem.Text = global::ResxEditor.Properties.Resources.AboutUsCommand;
            this.aboutUsMenuItem.Click += new System.EventHandler(this.aboutUsMenuItem_Click);
            // 
            // xmlGridView
            // 
            this.xmlGridView.AllowUserToAddRows = false;
            this.xmlGridView.AllowUserToDeleteRows = false;
            this.xmlGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xmlGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.xmlGridView.Location = new System.Drawing.Point(0, 27);
            this.xmlGridView.Name = "xmlGridView";
            this.xmlGridView.Size = new System.Drawing.Size(632, 339);
            this.xmlGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this.xmlGridView);
            this.Controls.Add(this.fileStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.fileStrip;
            this.Name = "MainForm";
            this.Text = "RESX ?????";
            this.fileStrip.ResumeLayout(false);
            this.fileStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmlGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip fileStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.DataGridView xmlGridView;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem textSizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseTextSizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseTextSizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultTextSizeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutUsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem wordCountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showKeysToolStripMenuItem;
    }
}

