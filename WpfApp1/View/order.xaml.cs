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

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для order.xaml
    /// </summary>
    public partial class order : Window
    {
        public order()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            foreach (Window window in App.Current.Windows)
            {
                if (!(window is MainWindow))		//Проверка, что окно не главное
                    window.Close();         //Закрыть все остальные окна, кроме главного
            }

        }
    }
}
