//------------------------------------------------------------------------------
// <copyright file="ConfigXmlReader.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

    using System.Configuration.Internal;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security;
    
    using System.Text;
    using System.Xml;
    using System.Net;
namespace System.Configuration {

    internal sealed class ConfigXmlReader : XmlReader, IConfigErrorInfo {
        string  _rawXml;
        int     _lineOffset;
        string  _filename;

        // Used in a decrypted configuration section to locate
        // the line where the ecnrypted section begins.
        bool    _lineNumberIsConstant;

        internal ConfigXmlReader(string rawXml, string filename, int lineOffset) : 
                this(rawXml, filename, lineOffset, false) {
        }

        internal ConfigXmlReader(string rawXml, string filename, int lineOffset, bool lineNumberIsConstant) : 
                base(new StringReader(rawXml)) {

            _rawXml = rawXml;
            _filename = filename;
            _lineOffset = lineOffset;
            _lineNumberIsConstant = lineNumberIsConstant;

            Debug.Assert(!_lineNumberIsConstant || _lineOffset > 0, 
                        "!_lineNumberIsConstant || _lineOffset > 0");
        }

        internal ConfigXmlReader Clone() {
            return new ConfigXmlReader(_rawXml, _filename, _lineOffset, _lineNumberIsConstant);
        }

        public override System.String GetAttribute(System.Int32 i)
        {
            throw new NotImplementedException();
        }

        public override System.String GetAttribute(System.String name)
        {
            throw new NotImplementedException();
        }

        public override System.String GetAttribute(System.String name, System.String namespaceURI)
        {
            throw new NotImplementedException();
        }

        public override System.String LookupNamespace(System.String prefix)
        {
            throw new NotImplementedException();
        }

        public override System.Boolean MoveToAttribute(System.String name)
        {
            throw new NotImplementedException();
        }

        public override System.Boolean MoveToAttribute(System.String name, System.String ns)
        {
            throw new NotImplementedException();
        }

        public override System.Boolean MoveToElement()
        {
            throw new NotImplementedException();
        }

        public override System.Boolean MoveToFirstAttribute()
        {
            throw new NotImplementedException();
        }

        public override System.Boolean MoveToNextAttribute()
        {
            throw new NotImplementedException();
        }

        public override System.Boolean Read()
        {
            throw new NotImplementedException();
        }

        public override System.Boolean ReadAttributeValue()
        {
            throw new NotImplementedException();
        }

        public override void ResolveEntity()
        {
            throw new NotImplementedException();
        }

        int IConfigErrorInfo.LineNumber {
            get {
                if (_lineNumberIsConstant) {
                    return _lineOffset;
                }
                else if (_lineOffset > 0) {
                    return base.LineNumber + (_lineOffset - 1);
                }
                else {
                    return base.LineNumber;
                }
            }
        }
    
        string IConfigErrorInfo.Filename {
            get {
                return _filename;
            }
        }

        internal string RawXml {
            get {
                return _rawXml;
            }
        }

        public override System.Int32 AttributeCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.String BaseURI
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.Int32 Depth
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.Boolean EOF
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.Boolean IsEmptyElement
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.String LocalName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.String NamespaceURI
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override XmlNameTable NameTable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override XmlNodeType NodeType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.String Prefix
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ReadState ReadState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override System.String Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
