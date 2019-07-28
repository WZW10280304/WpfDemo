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

namespace Wpf.Template.demo2
{
    /// <summary>
    /// demo2.xaml 的交互逻辑
    /// </summary>
    public partial class Demo2 : Window
    {
        public Demo2()
        {
            InitializeComponent();

            InitCarList();
        }

        private void InitCarList()
        {
            List<Car> lst = new List<Car>();
            lst.Add(new Car { AutoMaker = "logo", Name = "car1", Year = "1990", TopSpeed = "300" });
            lst.Add(new Car { AutoMaker = "logo", Name = "car2", Year = "1890", TopSpeed = "400" });
            lst.Add(new Car { AutoMaker = "logo", Name = "car3", Year = "1969", TopSpeed = "200" });
            lst.Add(new Car { AutoMaker = "logo", Name = "car4", Year = "2005", TopSpeed = "600" });

            foreach (var item in lst)
            {
                CarListItemView view = new CarListItemView();
                view.Car = item;
                listBoxCars.Items.Add(view);
            }
        }

        private void ListBoxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarListItemView view = e.AddedItems[0] as CarListItemView;

            if (view != null)
            {
                this.detailView.Car = view.Car;
            }
        }
    }
}
