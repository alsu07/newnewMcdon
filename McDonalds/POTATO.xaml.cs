using System.Windows;
using System.Windows.Input;

namespace McDonalds
{
    /// <summary>
    /// Логика взаимодействия для Potato.xaml
    /// </summary>
    public partial class Potato : Window
    {
        public Potato()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            listPotato.Items.Clear();
            foreach (Item item in MyItem.list)
                listPotato.Items.Add(item);
        }

        private void fri_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.FriPotato);
            change.Show();
            Refresh();
        }

        private void village_MouseDown(object sender, MouseButtonEventArgs e)
        {
            changeAmount change = new changeAmount(MyItem.Items.VillagePotato);
            change.Show();
            Refresh();
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
    }
}
