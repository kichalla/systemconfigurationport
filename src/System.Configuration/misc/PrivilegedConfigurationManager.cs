//------------------------------------------------------------------------------
// <copyright file="PrivilegedConfigurationManager.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------


using System.Collections.Specialized;

namespace System.Configuration
{



    internal static class PrivilegedConfigurationManager
    {
        internal static ConnectionStringSettingsCollection ConnectionStrings
        {
            get
            {
                return ConfigurationManager.ConnectionStrings;
            }
        }

        internal static object GetSection(string sectionName)
        {
            return ConfigurationManager.GetSection(sectionName);
        }
    }
}
