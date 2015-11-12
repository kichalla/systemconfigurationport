//------------------------------------------------------------------------------
// <copyright file="ProtectedConfigurationProvider.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

    using System.Collections.Specialized;
    using System.Runtime.Serialization;
    using System.Configuration.Provider;
    using System.Xml;
namespace System.Configuration
{

    public abstract class ProtectedConfigurationProvider : ProviderBase
    {
        public abstract XmlNode Encrypt(XmlNode node);
        public abstract XmlNode Decrypt(XmlNode encryptedNode);
    }
}
