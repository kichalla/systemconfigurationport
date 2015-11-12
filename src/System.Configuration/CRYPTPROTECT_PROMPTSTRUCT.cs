//------------------------------------------------------------------------------
// <copyright file="CRYPTPROTECT_PROMPTSTRUCT.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

    using System.Collections.Specialized;
    using System.Runtime.Serialization;
    using System.Configuration.Provider;
    using System.Xml;
    using System.Text;
    using  System.Runtime.InteropServices;
    using Microsoft.Win32;
namespace System.Configuration
{

    ////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////
    [StructLayout(LayoutKind.Sequential)]
    internal struct CRYPTPROTECT_PROMPTSTRUCT : IDisposable
    {
        public int cbSize;
        public int dwPromptFlags;
        public IntPtr hwndApp;
        public string szPrompt;
        void IDisposable.Dispose()
        {
            hwndApp = IntPtr.Zero;
        }
    }
}
