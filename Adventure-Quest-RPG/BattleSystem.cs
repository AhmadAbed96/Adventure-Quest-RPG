using Adventure_Quest_RPG;
using System;

public class BattleSystem : IBattleStates
{
    public string Name { get ; set ; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public void Attack(IBattleStates attacker, IBattleStates target)
    {
        int damage = Math.Max(attacker.AttackPower - target.Defense, 0);
        target.Health -= damage;
        if (target.Health < 0)
        {
            target.Health = 0;
        }

        Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage. {target.Name}'s health is now {target.Health}.");

        // Handle item drop if target is a monster and defeated
        //if (target is Monster && target.Health == 0)
        //{
        //    HandleItemDrop(attacker);
        //}
        
    }

    public void HandleItemDrop(Player player)
    {
        Random rand = new Random();
        int dropChance = rand.Next(40);

        if (dropChance < 20) 
        {
            Item droppedItem = GenerateRandomItem();
            player.Inventory.AddItem(droppedItem);
            Console.WriteLine($"{player.Name} found a {droppedItem.Name}!");
        }
    }

    public Item GenerateRandomItem()
    {
        Random rand = new Random();
        int itemType = rand.Next(3);
        switch (itemType)
        {
            case 0:
                return new Weapon("Sword", "A sharp blade.", 10);
            case 1:
                return new Armor("Shield", "A sturdy shield.", 5);
            case 2:
                return new Potion("Health Potion", "Restores health.", 20);
            default:
                return null;
        }
    }




    public void StartBattle(Player player, Monster enemy)
    {
        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("Player's turn:");
            Attack(player, enemy);
            if (enemy.Health == 0)
            {
                Console.WriteLine("You have defeated the enemy!");
                HandleItemDrop(player);
                break;
            }

            Console.WriteLine("Enemy's turn:");
            Attack(enemy, player);
            if (player.Health == 0)
            {
                Console.WriteLine("You have been defeated!");
                break;
            }
        }
    }

}