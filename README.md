# RESX2WORD

Convert Microsoft RESX 2.0 resource files (Visual Studio)
into Microsoft Word 2003 documents (and vice-versa).

The purpose of such a conversion is to let the translators work
in a more convenient and familiar environment (i.e. MS Word)
as opposed to raw XML files editor.

## Quick start

USAGE **resx2word** :

    resx2word.exe InputRESX OutputWORD

Where:
- InputRESX: the path of the RESX document
- OutputWORD: the path of the Ms Word document

USAGE **word2resx** :

    word2resx.exe InputWORD OutputRESX

Where:
- InputWORD: the path of the Ms Word document
- OutputRESX: the path of the RESX document

## Tech

The program (*in C# language*) simply transforms RESX XML file into Word 2003 XML file with a XSLT file and vice-versa.

Build tool is Visual Studio 2015 Community Edition targeted to .NET 2.0 framework.

Word file format is XML with schema [office/word/2003/wordml](http://schemas.microsoft.com/office/word/2003/wordml).

## Authors

Version 1.1
- Author: Cyrille Giquello
- Date: October 2016
- URL: https://github.com/Cyrille37/Resx2Word

Version <= 1.0
- Authors: Joannes Vermorel (www.vermorel.com), Lionel Fourquaux
- Date: July 28th, 2007
- URL: http://resx.sourceforge.net
