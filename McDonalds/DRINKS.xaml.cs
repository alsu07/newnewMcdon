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
    /// Логика взаимодействия для DRINKS.xaml
    /// </summary>
    public partial class DRINKS : Window
    {
        public DRINKS()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            listDrink.Items.Clear();
            foreach (Item item in MyItem.list)
                listDrink.Items.Add(item);
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

        private void cola_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.Cola);
            change.Show();
            Refresh();
        }

        private void berryPunch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.BerryPunch);
            change.Show();
            Refresh();
        }

        private void milkShake_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.MilkShake);
            change.Show();
            Refresh();
        }

        private void cappucino_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.Cappucino);
            change.Show();
            Refresh();
        }
    }
}
