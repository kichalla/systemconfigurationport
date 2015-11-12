//------------------------------------------------------------------------------
// <copyright file="NamespaceChange.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

    using System.Configuration.Internal;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    
    
    using System.Text;
    using System.Xml;
    using System.Collections.Specialized;
namespace System.Configuration {

    enum NamespaceChange {
        None    = 0,
        Add     = 1,
        Remove  = 2,
    }
}
