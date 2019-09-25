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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Caliburn.Demo1.Test1_Converter;
using Caliburn.Demo1.Test2MarkupExtensions;
using Caliburn.Demo1.Test3StyleAndArray;
using Caliburn.Demo1.Test4;
using Caliburn.Demo1.Test5;
using Caliburn.Demo1.Test6Drawing;

namespace Caliburn.Demo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Window3 w = new Window3();
            w.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Demo1CustomControl.Demo1 d=new Demo1CustomControl.Demo1();
            d.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 w = new Window4();
            w.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var w = new Window5();
            w.Show();
            var w2 = new Window5B();
            w2.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var win = new WindowDrawing();
            win.Show();
        }
    }
}
