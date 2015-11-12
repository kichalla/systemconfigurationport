using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

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
    }

    public class ConfigurationLocation
    {

    }
}
