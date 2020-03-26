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

        public class MyItem
        {
            public int Amount { get; set; }

            public string Name { get; set; }
            public int Price { get; set; }
        }
        public BURGERS()
        {
            InitializeComponent();
            var gridView = new GridView();
            this.listBurgers.View = gridView;
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Имя",
                DisplayMemberBinding = new Binding("Name")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Количество",
                DisplayMemberBinding = new Binding("Amount")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Цена",
                DisplayMemberBinding = new Binding("Price")
            });
        }

        private void backBurger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            MainWindow mainw = new MainWindow();
            mainw.Show();
        }

        private void bigtasty_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount();
            change.Show();
          this.IsEnabled = false;
           while (change.IsActive) ;
            this.IsEnabled = true;
                
            listBurgers.Items.Add(new MyItem { Name = "Биг Тейсти", Amount = change.count, Price = change.count * 249 });
            
        }

        private void chickenburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount();
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
            listBurgers.Items.Add(new MyItem { Name = "Чикенбургер", Amount = change.count, Price = change.count * 50 });
        }

        private void cheeseburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount();
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
            listBurgers.Items.Add(new MyItem { Name = "Чизбургер", Amount = change.count, Price = change.count * 50 });
        }

        private void chickenroyal_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount();
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
            listBurgers.Items.Add(new MyItem { Name = "Чикен Роял", Amount = change.count, Price = change.count * 139 });
        }
    }
}
