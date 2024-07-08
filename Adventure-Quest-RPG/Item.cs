using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Use(Player player);
    }

    // Weapon.cs
    public class Weapon : Item
    {
        public int AttackBoost { get; set; }

        public Weapon(string name, string description, int attackBoost)
            : base(name, description)
        {
            AttackBoost = attackBoost;
        }

        public override void Use(Player player)
        {
            player.AttackPower += AttackBoost;
            Console.WriteLine($"{player.Name} equipped {Name}, Attack Power increased by {AttackBoost}.");
        }
    }

    // Armor.cs
    public class Armor : Item
    {
        public int DefenseBoost { get; set; }

        public Armor(string name, string description, int defenseBoost)
            : base(name, description)
        {
            DefenseBoost = defenseBoost;
        }

        public override void Use(Player player)
        {
            player.Defense += DefenseBoost;
            Console.WriteLine($"{player.Name} equipped {Name}, Defense increased by {DefenseBoost}.");
        }
    }

    // Potion.cs
    public class Potion : Item
    {
        public int HealthRestore { get; set; }

        public Potion(string name, string description, int healthRestore)
            : base(name, description)
        {
            HealthRestore = healthRestore;
        }

        public override void Use(Player player)
        {
            player.Health += HealthRestore;
            if (player.Health > 100)
            {
                player.Health = 100;
            }
            Console.WriteLine($"{player.Name} used {Name}, Health restored by {HealthRestore}.");
        }
    }
}

