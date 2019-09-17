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

namespace Caliburn.Demo1.Test4
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();

            this.Loaded += Window4_Loaded;
        }

        public List<Users> List = new List<Users>();

        private void Window4_Loaded(object sender, RoutedEventArgs e)
        {

            List.Add(new Users { Name = "1、杰拉德" });
            List.Add(new Users { Name = "2、巴蒂斯图塔" });
            List.Add(new Users { Name = "3、舍甫琴科" });
            List.Add(new Users { Name = "4、亨利" });
            List.Add(new Users { Name = "5、罗纳尔迪尼奥" });

            this.DataContext = List;
        }

        private void Show(string str)
        {
            MessageBox.Show(str);
        }
    }

    public class Users
    {
        public string Name { get; set; }

        private bool Execute()
        {
            MessageBox.Show("您选择了："+Name);
            return true;
        }

        public ICommand OnCommand => new TestCommand(Execute);
    }

    public class TestCommand : ICommand
    {
        private readonly Func<bool> _exFunc;

        public TestCommand(Func<bool> execute)
        {
            _exFunc = execute;
        }

        public void Execute(object parameter)
        {
            _exFunc.Invoke();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
