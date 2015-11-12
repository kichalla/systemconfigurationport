//------------------------------------------------------------------------------
// <copyright file="ConfigurationLocationCollection.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

    using System.Collections;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Text;
namespace System.Configuration {

    public class ConfigurationLocationCollection : ReadOnlyCollectionBase {
        
        internal ConfigurationLocationCollection(ICollection col) {
            InnerList.AddRange(col);
        }

        public ConfigurationLocation this[int index] {
            get {
                return (ConfigurationLocation) InnerList[index];
            }
        }
    }
}
