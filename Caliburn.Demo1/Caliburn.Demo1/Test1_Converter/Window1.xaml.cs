using System.Windows;

namespace Caliburn.Demo1.Test1_Converter
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human h = (Human) this.FindResource("human");

            MessageBox.Show(h.Child.Name);
        }
    }
}
