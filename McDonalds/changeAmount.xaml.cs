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
        public MyItem.Items tmp;
        public changeAmount(MyItem.Items items)
        {
            tmp = items;
            InitializeComponent();
            count = Convert.ToInt32(tbCount.Text);
        }
        private void btnPlus_mouseDown(object sender, RoutedEventArgs e)
        {
            count++;
            string res = count.ToString();
            tbCount.Text = res;
        }
        private void btnMinus_mouseDown(object sender, RoutedEventArgs e)
        {
            if (count >= 1)
            {
                count--;
                tbCount.Text = count.ToString();
            }
        }
        private void btnOk_mouseDown(object sender, RoutedEventArgs e)
        {
            if(tmp == MyItem.Items.BigTaste)
                MyItem.Add("Биг Тейсти", count, count * 249);
            this.Close();
        }

    }
}
