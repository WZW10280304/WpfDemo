using System.ComponentModel;

namespace Caliburn.Demo1.Test1
{
    [TypeConverter(typeof(String2HumanTypeConverter))]
    public class Human
    {
        public string Name { get; set; }

        public Human Child { get; set; }
    }
}