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
using WpfApp1.View;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e) 
        {
            View.createOrder createOreder = new View.createOrder();
            this.Hide();
            createOreder.ShowDialog();
            this.Show();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            View.makeAnOrder makeAnOreder = new View.makeAnOrder();
            this.Hide();
            makeAnOreder.ShowDialog();
            this.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            View.editCatalog editCatalog = new View.editCatalog();
            this.Hide();
            editCatalog.ShowDialog();
            this.Show();
        }
    }
}
