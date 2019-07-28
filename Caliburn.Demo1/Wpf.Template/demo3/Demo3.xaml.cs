using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf.Template.demo2;

namespace Wpf.Template.demo3
{
    /// <summary>
    /// Demo3.xaml 的交互逻辑
    /// </summary>
    public partial class Demo3 : Window
    {
        public Demo3()
        {
            InitializeComponent();

            InitCars();
        }

        public void InitCars()
        {
            var list = new List<Car>();

            list.Add(new Car { AutoMaker = "logo", Name = "car1", Year = "1920", TopSpeed = "190" });
            list.Add(new Car { AutoMaker = "logo", Name = "car2", Year = "1950", TopSpeed = "220" });
            list.Add(new Car { AutoMaker = "logo", Name = "car3", Year = "1970", TopSpeed = "270" });
            list.Add(new Car { AutoMaker = "logo", Name = "car4", Year = "1990", TopSpeed = "320" });

            listBoxCars.ItemsSource = list;
        }
    }
}
