using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Characters : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
    }

    public class Player : Characters
        {
        public Inventory Inventory { get; set; }

        public Player(string name, int health = 100, int attackPower = 20, int defense = 10)
        {
            Name = "hero";
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
            Inventory = new Inventory();
        }


        public void UseItem(string itemName)
        {
            Inventory.UseItem(this, itemName);
        }

    }

    public abstract class Monster : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public Monster(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }

        public abstract void Attack(Player player);
    }

    public class BossMonster : Monster
    {
        public BossMonster(string name, int health = 200, int attackPower = 40, int defense = 20)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {

        }
    }

    public class Invoker : Monster
    {
        public Invoker(string name, int health = 50, int attackPower = 15, int defense = 15)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {

        }
    }
    public class Chen : Monster
    {
        public Chen(string name, int health = 40, int attackPower = 15, int defense = 10)
            : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {

        }
    }


}
