//------------------------------------------------------------------------------
// <copyright file="PropertySourceInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Configuration.Internal;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using System.Xml;
using System.Globalization;
using System.ComponentModel;

using System.Text;

namespace System.Configuration
{

    internal class PropertySourceInfo
    {
        private string _fileName;
        private int _lineNumber;

        internal PropertySourceInfo(XmlReader reader)
        {
            _fileName = GetFilename(reader);
            _lineNumber = GetLineNumber(reader);
        }

        internal string FileName
        {
            get
            {
                return _fileName;
            }
        }

        internal int LineNumber
        {
            get
            {
                return _lineNumber;
            }
        }

        private string GetFilename(XmlReader reader)
        {
            IConfigErrorInfo err = reader as IConfigErrorInfo;

            if (err != null)
            {
                return (string)err.Filename;
            }

            return "";
        }

        private int GetLineNumber(XmlReader reader)
        {
            IConfigErrorInfo err = reader as IConfigErrorInfo;

            if (err != null)
            {
                return (int)err.LineNumber;
            }
            return 0;
        }
    }
}
