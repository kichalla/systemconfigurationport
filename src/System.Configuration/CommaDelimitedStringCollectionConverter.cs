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

    public sealed class CommaDelimitedStringCollectionConverter : ConfigurationConverterBase
    {

        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
        {

            ValidateType(value, typeof(CommaDelimitedStringCollection));
            CommaDelimitedStringCollection internalValue = value as CommaDelimitedStringCollection;
            if (internalValue != null)
            {
                return internalValue.ToString();
            }
            else
            {
                return null;
            }
        }

        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
        {
            CommaDelimitedStringCollection attributeCollection = new CommaDelimitedStringCollection();
            attributeCollection.FromString((string)data);
            return attributeCollection;
        }
    }
}