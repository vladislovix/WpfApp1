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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        RCPEntities db;
        public Window1(string UserLogin, string Roles)
        {
            RCPEntities database = new RCPEntities();
            InitializeComponent();
            TableCars.ItemsSource = database.Cars.ToList();
            txtlogin.Text += $"Имя: {UserLogin}";
            txtrole.Text += $"Роль: {Roles}";
        }

        private void exit_btn(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            db = new RCPEntities();
            Cars item = TableCars.SelectedItem as Cars;
            try
            {
                Cars car = db.Cars.Where(c => c.id_car == item.id_car).Single();
                db.Cars.Remove(car);
                db.SaveChanges();

                MessageBox.Show("Клиент успешно удалён!");
                refreshdatagrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            refreshdatagrid();
            Window2 mw = new Window2();
            mw.ShowDialog();
        }
        private void refreshdatagrid()
        {
            RCPEntities db = new RCPEntities(); 
            TableCars.ItemsSource = db.Cars.ToList();
            TableCars.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            refreshdatagrid();
        }
    }
}
