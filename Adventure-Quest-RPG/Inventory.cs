using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Inventory
    {
        public List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void Display()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Description}");
            }
        }

        public void UseItem(Player player, string itemName)
        {
            var item = items.Find(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.Use(player);
                items.Remove(item);
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
    }
    

}
