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

namespace Wpf.Template
{
    /// <summary>
    /// Demo1.xaml 的交互逻辑
    /// </summary>
    public partial class Demo1 : Window
    {
        public Demo1()
        {
            InitializeComponent();

            var lst = new List<Demo1ViewModel>();
            lst.Add(new Demo1ViewModel("2001年", 100));
            lst.Add(new Demo1ViewModel("2002年", 89));
            lst.Add(new Demo1ViewModel("2003年", 102));
            lst.Add(new Demo1ViewModel("2004年", 66));
            lst.Add(new Demo1ViewModel("2005年", 180));
            lst.Add(new Demo1ViewModel("2006年", 111));
            lst.Add(new Demo1ViewModel("2007年", 222));

            DataContext = lst;
        }
    }

    public class Demo1ViewModel
    {
        public Demo1ViewModel(string year, int price)
        {

        }

        public string Year { get; set; }

        public int Price { get; set; }
    }
}
