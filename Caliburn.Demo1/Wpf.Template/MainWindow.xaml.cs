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
using Wpf.Template.demo2;
using Wpf.Template.demo3;

namespace Wpf.Template
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDemo1_Click(object sender, RoutedEventArgs e)
        {
            var d = new Demo1();
            d.Show();
        }

        private void BtnDemo2_Click(object sender, RoutedEventArgs e)
        {
            var d = new Demo2();
            d.Show();
        }

        private void BtnDemo3_Click(object sender, RoutedEventArgs e)
        {
            var d = new Demo3();
            d.Show();
        }
    }
}
