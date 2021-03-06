//------------------------------------------------------------------------------
// <copyright file="ProtectedProviderSettings.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Configuration
{
    public class ProtectedProviderSettings : ConfigurationElement
    {
        private ConfigurationPropertyCollection _properties;
        private readonly ConfigurationProperty _propProviders =
            new ConfigurationProperty(null, typeof(ProviderSettingsCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

        public ProtectedProviderSettings()
        {
            // Property initialization
            _properties = new ConfigurationPropertyCollection();
            _properties.Add(_propProviders);
        }

        protected internal override ConfigurationPropertyCollection Properties
        {
            get
            {
                return _properties;
            }
        }


        [ConfigurationProperty("", IsDefaultCollection = true, Options = ConfigurationPropertyOptions.IsDefaultCollection)]
        public ProviderSettingsCollection Providers
        {
            get
            {
                return (ProviderSettingsCollection)base[_propProviders];
            }
        }
    }
}
