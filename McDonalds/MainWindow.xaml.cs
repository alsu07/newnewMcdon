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

namespace McDonalds
{
    public class Item
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public static class MyItem
    {
        public static GridView gridView = new GridView();
        public static List<Item> list = new List<Item>();
        public enum Items
        {
            BigTaste
        }
        public static void Add(string name, int amount, int price)
        {
            list.Add(new Item { Name = name, Amount = amount, Price = price });
        }

    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void burger_mouseDown(object sender, MouseButtonEventArgs e)
        {
            BURGERS burgers = new BURGERS();
            burgers.Show();
            this.Close();
        }
    }
}
