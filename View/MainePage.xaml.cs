using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp10.Core;
using WpfApp10.Model;
using WpfApp10.View.Page;
using static WpfApp10.Core.Core;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainePage.xaml
    /// </summary>
    public partial class MainePage
    {
        public MainePage()
        {
            InitializeComponent();
            DataFrame.db = new TaskBDOEntities();
           
        }

        private void DaX_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users userMode = DataFrame.db.Users.FirstOrDefault(g => g.FirstName = FirstN.Text && g.LastName == PSPPassword.Password);
                if (userMode != null)
                {
                    switch (userMode.UsersID)
                    {
                        case 1:
                            MessageBox.Show($"привет-{userMode.FirstName}", "Приветсвие", MessageBoxButton.OK,MessageBoxImage.Information);
                            break;
                        case 2:
                            MessageBox.Show($"привет-{userMode.FirstName}", "Приветсвие", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        case 3:
                            MessageBox.Show($"привет-{userMode.FirstName}", "Приветсвие", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        case 4:
                            MessageBox.Show($"привет-{userMode.FirstName}", "Приветсвие", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                    }
                }
                else
                {
                    
                            MessageBox.Show("Очибочка", "Приветсвие", MessageBoxButton.OK, MessageBoxImage.Error);
                   
                }

            }
            catch 
            (Exception)
            { 
                MessageBox.Show("Чиго???", "Приветсвие", MessageBoxButton.OK, MessageBoxImage.Information);
               
            }
        }

        private void Apst_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.N1.Navigate(new closepag());
        }
    }
}
