using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Adventure
    {
        List<string> monsterChosen = new List<string> { };
        public string CurrentLocation = "Forest";
        public Player player;
        public List<Location> locations = new List<Location> { new Location("Town"), new Location("Forest"), new Location("Cave"), new Location("Castle") };

        public List<Monster> monsters;

        public Adventure(Player player)
        {
            this.player = player;
            //InitializeMonsters();
            monsters = new List<Monster>
        {

            new Chen("Chen"),
            new Invoker("Invoker"),
            new BossMonster("Bane")
        };
        }

        //private void InitializeMonsters()
        //{

        //}



        public void Start()
        {
            Console.WriteLine("Welcome to the Adventure Quest RPG!");

            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine($"You are in the {CurrentLocation}.");
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Start to play");
                Console.WriteLine("2. View inventory");
                Console.WriteLine("3. Discover a new location");
                Console.WriteLine("4. End game");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EncounterMonster();
                        break;
                    case "2":
                        player.Inventory.Display();
                        Console.WriteLine("Enter the name of the item to use or 'back' to return:");
                        string? itemName = Console.ReadLine();
                        if (itemName.ToLower() != "back")
                        {
                            player.UseItem(itemName);
                        }
                        break;
                    case "3":
                        DiscoverNewLocation();
                        break;
                    case "4":
                        gameOver = true;
                        Console.WriteLine("Ending game...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private void EncounterMonster()
        {
            bool isMonster = true;
            Random rand = new Random();
            Monster enemy = null;
            while (isMonster)
            {
             enemy =  monsters[rand.Next(monsters.Count)];
                if (!monsterChosen.Contains(enemy.Name))
                {
                    isMonster = false;
                }

            }
            monsterChosen.Add(enemy.Name);
            Console.WriteLine($"You have encountered a {enemy.Name}!");

            BattleSystem battleSystem = new BattleSystem();
            battleSystem.StartBattle(player, enemy);

            if (player.Health == 0)
            {
                Console.WriteLine("You have been defeated! Game over.");
                Environment.Exit(0);
            }
        }
        public void DiscoverNewLocation()
        {
                Console.WriteLine($"Enter a location to discover");
            for (int i = 0; i < locations.Count; i++)
            {
                Console.WriteLine($"{i+1} ==> {locations[i].Name}");
            } 
            int choiseLocation = Convert.ToInt32( Console.ReadLine() ) ;
            CurrentLocation = locations[ choiseLocation -1 ].Name;
        }

    }
    public class Location
    {
        public string Name { get; set; }
        public Location(string name)
        {
            Name = name;
        }
    }
}
