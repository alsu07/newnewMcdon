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
    /// Логика взаимодействия для changeAmount.xaml
    /// </summary>
    public partial class changeAmount : Window
    {
        public int count;
        public string name;
        public int price;

        public changeAmount(int _price, string _name)
        {
            InitializeComponent();
            count = Convert.ToInt32(tbCount.Text);
            name = _name;
            price = _price;
        }

        
        

        private void changeAmountClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            count++;
            tbCount.Text = count.ToString(); ;

        }

        private void btnMinus_click(object sender, RoutedEventArgs e)
        {
            if (count >= 1)
            {
                count--;
                tbCount.Text = count.ToString();
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ListBox.newCheque.Add(new ItemsOfList { name = this.name, price = this.price * count, amount = count });
            ListBox.countOfItems++;
            this.Close();
            BURGERS test = new BURGERS();
            test.Show();
        }
    }
}
