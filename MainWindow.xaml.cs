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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

            {
        RCPEntities database = new RCPEntities();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void clickautoriz(object sender, RoutedEventArgs e)
        {
            Role337 roles = new Role337();
            var login = txtlogin.Text; 
            var pass = txtpass.Text;
            if (database.Client.Any(u => u.client_name == login && u.client_passport_number == pass))

            {
                foreach (var client in database.Client) 
                {
                    if (client.client_name == login && client.client_passport_number == pass) 
                                                     
                    {
                        var role = database.Roles.Find(client.client_role);
                        roles.UserLogin = login;
                        roles.UserRole = role.Role;

                        this.Visibility = Visibility.Collapsed;
                        Window1 window = new Window1(roles.UserLogin, roles.UserRole);
                        window.Show();

                    }
                }

            }
            else
            {
                MessageBox.Show("");
            }
        }
    
       

        private void clickguest(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            string UserLogin = "Гость";
            string UserRole = "Гость";
            Window1 wins1 = new Window1(UserLogin, UserRole);
            wins1.Show();
        }
    }
}
