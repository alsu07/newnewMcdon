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

namespace McDonalds
{
    /// <summary>
    /// Логика взаимодействия для DESSERTS.xaml
    /// </summary>
    public partial class DESSERTS : Window
    {
        public DESSERTS()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            listDesert.Items.Clear();
            foreach (Item item in MyItem.list)
                listDesert.Items.Add(item);
            totalPrice.Content = MyItem.TotalPrice.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainw = new MainWindow();
            mainw.Show();
            this.Close();
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            Refresh();
        }

        private void makFlury_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.MacFlury);
            change.Show();
            Refresh();
        }

        private void chizCake_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.ChizCake);
            change.Show();
            Refresh();
        }

        private void cherryCake_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.CherryCake);
            change.Show();
            Refresh();
        }

        private void donut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.Donut);
            change.Show();
            Refresh();
        }
    }
}
