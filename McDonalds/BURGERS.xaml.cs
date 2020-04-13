using System.Windows;
using System.Windows.Input;

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
            totalPrice.Content = MyItem.TotalPrice.ToString();
        }
        private void backBurger_mouseDown(object sender, RoutedEventArgs e)
        {
            MainWindow mainw = new MainWindow();
            mainw.Show();
            this.Close();
        }

        private void bigtasty_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.BigTasty);
            change.Show();
            Refresh();
        }
       
        private void chickenburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.ChickenBurger);
            change.Show();
            Refresh();
        }

        private void cheeseburger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.ChickenRoyal);
            change.Show();
            Refresh();
        }

        private void chickenroyal_mouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.ChizBurger);
            change.Show();
            Refresh();
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            Refresh();
        }
    }
}
