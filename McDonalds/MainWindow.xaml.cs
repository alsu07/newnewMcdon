using System.Windows;
using System.Windows.Input;

namespace McDonalds
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            listMain.Items.Clear();
            foreach (Item item in MyItem.list)
                listMain.Items.Add(item);
            totalPrice.Content = MyItem.TotalPrice.ToString();
        }
        private void burger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            BURGERS burgers = new BURGERS();
            burgers.Show();
            this.Close();
        }

        private void potato_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Potato potato = new Potato();
            potato.Show();
            this.Close();
        }

        private void dessert_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DESSERTS desserts = new DESSERTS();
            desserts.Show();
            this.Close();
        }

        private void drink_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DRINKS drinks = new DRINKS();
            drinks.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MyItem.Delete(listMain.Items.IndexOf(listMain.SelectedItem));
            Refresh();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var i = listMain.Items.IndexOf(listMain.SelectedItem);
            changeAmount change = new changeAmount(i, 2);
            change.Show();
            Refresh();
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            Refresh();
        }
    }
}
