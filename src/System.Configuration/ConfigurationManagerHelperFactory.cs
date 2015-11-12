//------------------------------------------------------------------------------
// <copyright file="ConfigurationManagerHelperFactory.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Configuration {
    using System.Configuration.Internal;
    using System.Diagnostics.CodeAnalysis;


    //
    // class ConfigurationManagerHelperFactory manages access to a
    // single instance of ConfigurationManagerHelper.
    //
    static internal class ConfigurationManagerHelperFactory {
        private const string ConfigurationManagerHelperTypeString = "System.Configuration.Internal.ConfigurationManagerHelper, " + AssemblyRef.System;

        static private volatile IConfigurationManagerHelper s_instance;

        static internal IConfigurationManagerHelper Instance {
            get {
                if (s_instance == null) {
                    s_instance = CreateConfigurationManagerHelper();
                }

                return s_instance;
            }
        }

        private static IConfigurationManagerHelper CreateConfigurationManagerHelper() {
            return TypeUtil.CreateInstance<IConfigurationManagerHelper>(ConfigurationManagerHelperTypeString);
        }
    }
}
