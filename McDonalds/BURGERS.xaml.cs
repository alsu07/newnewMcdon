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
    /// Логика взаимодействия для BURGERS.xaml
    /// </summary>
    public partial class BURGERS : Window
    {
        public BURGERS()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            listBurgers.Items.Clear();
            foreach (Item item in MyItem.list)
                listBurgers.Items.Add(item);
        }
        private void backBurger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainw = new MainWindow();
            mainw.Show();
            this.Close();
        }

        private void bigtasty_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.BigTaste);
            change.Show();
            Refresh();
        }
       
        private void chickenburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.BigTaste);
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
            //listBurgers.Items.Add(new MyItem { Name = "Чикенбургер", Amount = change.count, Price = change.count * 50 });
        }

        private void cheeseburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.BigTaste);
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
            //listBurgers.Items.Add(new MyItem { Name = "Чизбургер", Amount = change.count, Price = change.count * 50 });
        }

        private void chickenroyal_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.BigTaste);
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
            //listBurgers.Items.Add(new MyItem { Name = "Чикен Роял", Amount = change.count, Price = change.count * 139 });
        }
    }
}
