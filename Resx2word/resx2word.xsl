<?xml version="1.0" encoding="utf-8"?>
<!--
// Resx2word  Copyright (C) 2006 - 2007  Joannès Vermorel (www.vermorel.com)
// This program comes with ABSOLUTELY NO WARRANTY.
// This is free software, and you are welcome to redistribute it
// under the conditions defined by the GPL 3 open-source license.
-->
<xsl:stylesheet
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:w="http://schemas.microsoft.com/office/word/2003/wordml"
    version="1.0">
  <xsl:output
    method="xml"
    version="1.0"
    encoding="utf-8"
    omit-xml-declaration="no"
    indent="no"
    media-type="text/xml" />
  <xsl:preserve-space elements="value" />
  <xsl:template match="root">
    
    <xsl:processing-instruction name="mso-application">
      <xsl:text>progid="Word.Document"</xsl:text>
    </xsl:processing-instruction>
    <w:wordDocument>
      <xsl:attribute name="xml:space">
        <xsl:text>preserve</xsl:text>
      </xsl:attribute>
      <w:styles>
        <w:style w:type="paragraph" w:styleId="Normal" w:default="on">
          <w:name w:val="Normal" />
          <w:pPr>
            <w:jc w:val="left" />
          </w:pPr>
          <w:rPr>
            <w:sz w:val="24" />
          </w:rPr>
        </w:style>
        <w:style w:type="paragraph" w:styleId="Title" w:default="off">
          <w:name w:val="Title" />
          <w:basedOn w:val="Normal" />
          <w:pPr>
            <w:spacing w:before="0" w:after="384" />
          </w:pPr>
          <w:rPr>
            <w:b w:val="on" />
            <w:sz w:val="32" />
          </w:rPr>
        </w:style>
        <w:style w:type="paragraph" w:styleId="Text" w:default="off">
          <w:name w:val="Text" />
          <w:basedOn w:val="Normal" />
          <w:pPr>
            <w:jc w:val="both" />
            <w:spacing w:before="0" w:after="216" />
          </w:pPr>
        </w:style>
        <w:style w:type="character" w:styleId="Emphasis" w:default="off">
          <w:name w:val="Emphasis" />
          <w:rPr>
            <w:b w:val="on" />
          </w:rPr>
        </w:style>
        <w:style w:type="character" w:styleId="DoNotChange" w:default="off">
          <w:name w:val="DoNotChange" />
          <w:rPr>
            <w:shd w:color="c0c0c0" w:val="solid" />
          </w:rPr>
        </w:style>
        <w:style w:type="character" w:styleId="Translation" w:default="off">
          <w:name w:val="Translation" />
          <w:rPr>
            <w:noProof w:val="on" />
          </w:rPr>
        </w:style>
        <w:style w:type="table" w:styleId="ResXData" w:default="off">
          <w:name w:val="ResXData" />
          <w:tblPr>
            <w:tblBorders>
              <w:top w:val="single" w:sz="2" />
              <w:left w:val="single" w:sz="2" />
              <w:bottom w:val="single" w:sz="2" />
              <w:right w:val="single" w:sz="2" />
              <w:insideH w:val="single" w:sz="2" />
              <w:insideV w:val="single" w:sz="2" />
            </w:tblBorders>
            <w:tblLook w:val="0" />
          </w:tblPr>
        </w:style>
      </w:styles>
      <w:docPr>
        <w:autoHyphenation w:val="off" />
        <w:view w:val="normal" />
      </w:docPr>
      <w:body>
        <w:p>
          <w:pPr>
            <w:pStyle w:val="Title" />
          </w:pPr>
          <w:r>
            <w:t>Resx2Word</w:t>
          </w:r>
        </w:p>
        <w:p>
          <w:pPr>
            <w:pStyle w:val="Text" />
          </w:pPr>
          <w:r>
            <w:t>
              <xsl:text>INSTRUCTIONS TO THE TRANSLATOR: The text elements with a </xsl:text>
            </w:t>
          </w:r>
          <w:r>
            <w:rPr>
              <w:rStyle w:val="DoNotChange" />
            </w:rPr>
            <w:t>
              <xsl:text>grey background</xsl:text>
            </w:t>
          </w:r>
          <w:r>
            <w:t>
              <xsl:text> must </xsl:text>
            </w:t>
          </w:r>
          <w:r>
            <w:rPr>
              <w:rStyle w:val="Emphasis" />
            </w:rPr>
            <w:t>
              <xsl:text>neither be touched nor translated</xsl:text>
            </w:t>
          </w:r>
          <w:r>
            <w:t>
              <xsl:text>. The first grayed element is an identifier for the block of text. The second grayed element contains the original text. The third line contains a copy of the second line. Please overwrite the third line by replacing the text by its translation. The fourth line is optional. Whenever it exists, it's a comment provided by the author to guide you through the translation work.</xsl:text>
            </w:t>
          </w:r>
        </w:p>
        <xsl:apply-templates select="data" >
          <xsl:sort select="@name"/>
        </xsl:apply-templates>
          <w:sectPr>
          <w:pgSz w:w="11906" w:h="16838" w:orient="portrait" />
          <w:pgMar
            w:top="1440"
            w:right="1630"
            w:bottom="1440"
            w:left="1630"
            w:header="709"
            w:footer="709"
            w:gutter="0" />
        </w:sectPr>
      </w:body>
    </w:wordDocument>
  </xsl:template>
  <xsl:template match="data">
    <w:tbl>
      <w:tblPr>
        <w:tblStyle w:val="ResXData" />
        <w:tblW w:w="5000" w:type="pct" />
      </w:tblPr>
      <w:tblGrid>
        <w:gridCol />
      </w:tblGrid>
      <w:tr>
        <w:tc>
          <w:p>
            <w:pPr>
              <w:pStyle w:val="Normal" />
            </w:pPr>
            <w:r>
              <w:rPr>
                <w:rStyle w:val="DoNotChange" />
              </w:rPr>
              <w:t>
                <xsl:value-of select="@name" />
              </w:t>
            </w:r>
          </w:p>
        </w:tc>
      </w:tr>
      <w:tr>
        <w:tc>
          <w:p>
            <w:pPr>
              <w:pStyle w:val="Normal" />
            </w:pPr>
            <w:r>
              <w:rPr>
                <w:rStyle w:val="DoNotChange" />
              </w:rPr>
              <w:t>
                <xsl:value-of select="value" />
              </w:t>
            </w:r>
          </w:p>
        </w:tc>
      </w:tr>
      <w:tr>
        <w:tc>
          <w:p>
            <w:pPr>
              <w:pStyle w:val="Normal" />
            </w:pPr>
            <w:r>
              <w:rPr>
                <w:rStyle w:val="Translation" />
              </w:rPr>
              <w:t>
                <xsl:value-of select="value" />
              </w:t>
            </w:r>
          </w:p>
        </w:tc>
      </w:tr>
      <xsl:for-each select="comment">
        <w:tr>
          <w:tc>
            <w:p>
              <w:pPr>
                <w:pStyle w:val="Normal" />
              </w:pPr>
              <w:r>
                <w:rPr>
                  <w:rStyle w:val="DoNotChange" />
                </w:rPr>
                <w:t>
                  <xsl:value-of select="." />
                </w:t>
              </w:r>
            </w:p>
          </w:tc>
        </w:tr>
      </xsl:for-each>
    </w:tbl>
    <w:p>
      <w:pPr>
        <w:pStyle w:val="Normal" />
      </w:pPr>
    </w:p>
  </xsl:template>
</xsl:stylesheet>
