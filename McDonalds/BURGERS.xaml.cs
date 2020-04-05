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
    /// 
    class MyItem
    {
        public int Price;
        public int Amount;
        public string Name;
        public MyItem(string _name, int _amount,int _price)
        {
            Name = _name;
            Amount = _amount;
            Price = _price;
        }
    }
    public partial class BURGERS : Window
    {

        
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
            for(int i= 0; i < ListBox.countOfItems;i++)
            listBurgers.Items.Add(new MyItem(ListBox.newCheque[i].name, ListBox.newCheque[i].amount, ListBox.newCheque[i].price ));
            
        }

        private void backBurger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            MainWindow mainw = new MainWindow();
            mainw.Show();
        }

        private void bigtasty_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(249, "Биг Тейсти");
            change.Show();

            // listBurgers.Items.Add(new MyItem { Name = "Биг Тейсти", Amount = change.count, Price = change.count * 249 });
            this.Close();
        }
        
        private void chickenburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(249, "Биг Тейсти");
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
           // listBurgers.Items.Add(new MyItem { Name = "Чикенбургер", Amount = change.count, Price = change.count * 50 });
        }

        private void cheeseburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(249, "Биг Тейсти");
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
           // listBurgers.Items.Add(new MyItem { Name = "Чизбургер", Amount = change.count, Price = change.count * 50 });
        }

        private void chickenroyal_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(249, "Биг Тейсти");
            change.Show();
            this.IsEnabled = false;
            while (change.IsActive) ;
            this.IsEnabled = true;
           // listBurgers.Items.Add(new MyItem { Name = "Чикен Роял", Amount = change.count, Price = change.count * 139 });
        }
        
    }
}
