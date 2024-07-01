using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
    }
        public class Player : Character
        {
        public Player()
        {
            Name = "hero";
            Health = 100;
            AttackPower = 30;
            Defense = 15;
        }
    }
        public abstract class Monster : Character
        {
        public Monster() 
        {
            Name = "Invoker";
            Health = 100;
            AttackPower = 20;
            Defense = 15;
        }
        }
        
        public class Invoker : Monster
        {
            
        }
    
}
