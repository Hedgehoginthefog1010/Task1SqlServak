using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp10.Core.Core;

namespace WpfApp10.View.Page
{
    /// <summary>
    /// Логика взаимодействия для closepag.xaml
    /// </summary>
    public partial class closepag 
    {
        public closepag()
        {
            InitializeComponent();
        }

        private void btnus_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btny_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new MainePage());

        }
    }
}
