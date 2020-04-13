using System.Collections.Generic;

namespace McDonalds
{
    public static class MyItem
    {
        public static List<Item> list = new List<Item>();
        public enum Items
        {
            BigTasty, ChickenBurger, ChizBurger, ChickenRoyal, FriPotato, VillagePotato, MacFlury, ChizCake, CherryCake, Donut, Cola, Cappucino, MilkShake, BerryPunch
        }
        public static void Add(string name, int amount, int price)
        {
            list.Add(new Item { Name = name, Amount = amount, Price = price });
        }
        public static void Delete(int index)
        {
            list.RemoveAt(index);
        }
        public static void Edit(int index, int amount)
        {
            list[index].Amount = amount;
        }
    }
    public class Item
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
