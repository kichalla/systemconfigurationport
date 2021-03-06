﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace System.Configuration
{
    public class SerializableAttribute : Attribute
    {
    }

    public class ConfigurationException : Exception
    {
        public ConfigurationException() { }

        public ConfigurationException(SerializationInfo info, StreamingContext context) { }

        public string Filename { get; set; }

        public int Line { get; set; }

        internal void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public string BareMessage
        {
            get
            {
                return this.Message;
            }
        }
    }

    public class SerializationInfo
    {
        internal string GetString(string sERIALIZATION_PARAM_FILENAME)
        {
            return null;
        }

        internal int GetInt32(string sERIALIZATION_PARAM_LINE)
        {
            return -1;
        }

        internal void AddValue(String sERIALIZATION_PARAM_FILENAME, String filename)
        {
            throw new NotImplementedException();
        }
    }

    public class ConfigurationLocation
    {
        public ConfigurationLocation() { }

        public ConfigurationLocation(Configuration config, string str) { }
    }

    public interface IConfigurationSectionHandler
    {
        object Create(Object parent, Object configContext, XmlNode section);
    }

    namespace System.ComponentModel
    {
        using System;

        /// <devdoc>
        ///    <para>Specifies a description for a property
        ///       or event.</para>
        /// </devdoc>
        [AttributeUsage(AttributeTargets.All)]
        public class DescriptionAttribute : Attribute
        {
            /// <devdoc>
            /// <para>Specifies the default value for the <see cref='System.ComponentModel.DescriptionAttribute'/> , which is an
            ///    empty string (""). This <see langword='static'/> field is read-only.</para>
            /// </devdoc>
            public static readonly DescriptionAttribute Default = new DescriptionAttribute();
            private string description;

            /// <devdoc>
            ///    <para>[To be supplied.]</para>
            /// </devdoc>
            public DescriptionAttribute() : this(string.Empty)
            {
            }

            /// <devdoc>
            ///    <para>Initializes a new instance of the <see cref='System.ComponentModel.DescriptionAttribute'/> class.</para>
            /// </devdoc>
            public DescriptionAttribute(string description)
            {
                this.description = description;
            }

            /// <devdoc>
            ///    <para>Gets the description stored in this attribute.</para>
            /// </devdoc>
            public virtual string Description
            {
                get
                {
                    return DescriptionValue;
                }
            }

            /// <devdoc>
            ///     Read/Write property that directly modifies the string stored
            ///     in the description attribute. The default implementation
            ///     of the Description property simply returns this value.
            /// </devdoc>
            protected string DescriptionValue
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }

            public override bool Equals(object obj)
            {
                if (obj == this)
                {
                    return true;
                }

                DescriptionAttribute other = obj as DescriptionAttribute;

                return (other != null) && other.Description == Description;
            }

            public override int GetHashCode()
            {
                return Description.GetHashCode();
            }

//#if !SILVERLIGHT
//            /// <internalonly/>
//            /// <devdoc>
//            /// </devdoc>
//            public override bool IsDefaultAttribute()
//            {
//                return (this.Equals(Default));
//            }
//#endif

        }
    }
}
