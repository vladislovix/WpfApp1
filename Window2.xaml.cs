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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        RCPEntities db;
        public Window2()
        {
            InitializeComponent();
        }

        private void btn_addClient(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cars car = new Cars();
            db = new RCPEntities();


            car.car_model = car_model.Text;
            car.car_color = car_color.Text;
            car.car_year = DateTime.Parse(car_year.Text);
            car.car_number = car_number.Text;

            MessageBox.Show("Успешно");

            try
            {
                db.Cars.Add(car);
                db.SaveChanges();
                this.Close();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
