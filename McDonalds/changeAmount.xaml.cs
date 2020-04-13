using System;
using System.Windows;

namespace McDonalds
{
    /// <summary>
    /// Логика взаимодействия для changeAmount.xaml
    /// </summary>
    public partial class changeAmount : Window
    {
        public int count;
        public int flag { get; set; }
        public int index { get; set; }
        public MyItem.Items tmp;
        public changeAmount(int _index, int _flag)
        {
            flag = _flag;
            index = _index;
            InitializeComponent();
        }
        public changeAmount(MyItem.Items items)
        {
            tmp = items;
            InitializeComponent();
            count = Convert.ToInt32(tbCount.Text);
        }
        private void btnPlus_mouseDown(object sender, RoutedEventArgs e)
        {
            count++;
            tbCount.Text = count.ToString();
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
            if (count > 0)
            {
                if (flag == 2)
                {
                    MyItem.Edit(index, count);
                }
                else
                {
                    switch (tmp)
                    {
                        case MyItem.Items.BigTasty:
                            MyItem.Add("Биг Тейсти", count, count * 249);
                            break;
                        case MyItem.Items.ChickenBurger:
                            MyItem.Add("Чикенбургер", count, count * 50);
                            break;
                        case MyItem.Items.ChizBurger:
                            MyItem.Add("Чизбургер", count, count * 50);
                            break;
                        case MyItem.Items.ChickenRoyal:
                            MyItem.Add("Чикен Рояль", count, count * 139);
                            break;
                        case MyItem.Items.FriPotato:
                            MyItem.Add("Картошка Фри", count, count * 64);
                            break;
                        case MyItem.Items.VillagePotato:
                            MyItem.Add("Картошка по-деревенски", count, count * 77);
                            break;
                        case MyItem.Items.MacFlury:
                            MyItem.Add("Мак флури", count, count * 100);
                            break;
                        case MyItem.Items.MilkShake:
                            MyItem.Add("Молочный коктейль", count, count * 99);
                            break;
                        case MyItem.Items.ChizCake:
                            MyItem.Add("Чизкейк", count, count * 129);
                            break;
                        case MyItem.Items.CherryCake:
                            MyItem.Add("Пирожок с вишней", count, count * 50);
                            break;
                        case MyItem.Items.Donut:
                            MyItem.Add("Донат", count, count * 89);
                            break;
                        case MyItem.Items.Cola:
                            MyItem.Add("Кола", count, count * 65);
                            break;
                        case MyItem.Items.BerryPunch:
                            MyItem.Add("Ягодный пунш", count, count * 99);
                            break;
                        case MyItem.Items.Cappucino:
                            MyItem.Add("Капучино", count, count * 99);
                            break;
                    }
                }
            }
            this.Close();
        }
    }
}
