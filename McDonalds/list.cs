using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    public static class ListBox
    {
        public static List<ItemsOfList> newCheque = new List<ItemsOfList>();
        public static int countOfItems = 0;
        
    }
    public  class ItemsOfList
    {
        public  int price;
        public int amount;
        public  string name;
        /*public ItemsOfList(string _name, int _price, int _amount)
        {
            price = _price;
            name = _name;
            amount = _amount;
        }
        */
    }
}
