using System.ComponentModel;
using System.Globalization;

namespace Caliburn.Demo1.Test1_Converter
{
    public class String2HumanTypeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                Human h = new Human();
                h.Name = value as string;
                return h;
            }

            return base.ConvertFrom(context, culture, value);
        }
    }
}