using System;

namespace Interfaces
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DisplayPropertyAttribute : Attribute
    {
        public DisplayPropertyAttribute(string displayProperty, string formatString, string separator)
        {
            DisplayProperty = displayProperty;
            FormatString = formatString;
            Seperator = separator;
        }

        public string DisplayProperty { get; }
        public string FormatString { get; }
        public string Seperator { get; }
    }
}