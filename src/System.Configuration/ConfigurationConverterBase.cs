﻿using System;
using System.Collections;
using System.IO;
using System.Reflection;

using System.Xml;
using System.Collections.Specialized;
using System.Globalization;
using System.ComponentModel;

using System.Text;

namespace System.Configuration
{

    public abstract class ConfigurationConverterBase : TypeConverter
    {

        public override bool CanConvertTo(ITypeDescriptorContext ctx, Type type)
        {
            return (type == typeof(string));
        }

        public override bool CanConvertFrom(ITypeDescriptorContext ctx, Type type)
        {
            return (type == typeof(string));
        }

        internal void ValidateType(object value, Type expected)
        {
            if ((value != null) && (value.GetType() != expected))
            {
                throw new ArgumentException(SR.GetString(SR.Converter_unsupported_value_type, expected.Name));
            }
        }
    }
}