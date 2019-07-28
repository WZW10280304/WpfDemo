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

namespace Wpf.Template.demo2
{
    /// <summary>
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        public CarDetailView()
        {
            InitializeComponent();
        }

        private Car _car;
        public Car Car
        {
            get { return _car; }
            set
            {
                _car = value;
                this.txtName.Text = _car.Name;
                this.txtYear.Text = _car.Year;
                this.txtTopSpeed.Text = _car.TopSpeed;
                this.txtAutoMaker.Text = _car.AutoMaker;
                var uriStr = string.Format(@"/Resources/Images/{0}.jpg", _car.Name);
                this.imgPhote.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
    }
}
