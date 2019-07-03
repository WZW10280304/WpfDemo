using System.ComponentModel;

namespace Caliburn.Demo1.Test1_Converter
{
    [TypeConverter(typeof(String2HumanTypeConverter))]
    public class Human
    {
        public string Name { get; set; }

        public Human Child { get; set; }
    }
}