//------------------------------------------------------------------------------
// <copyright file="ProviderException.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Configuration.Provider {

    [Serializable]
    public class ProviderException : Exception
    {
        public ProviderException() {}

        public ProviderException( string message )
            : base( message )
        {}

        public ProviderException( string message, Exception innerException )
            : base( message, innerException )
        {}

    }
}
