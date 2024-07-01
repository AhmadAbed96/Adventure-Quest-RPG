using Adventure_Quest_RPG;

public class BattleSystem
{
    public string StartBattle(Character player, Character monster)
    {
        while (player.Health > 0 && monster.Health > 0)
        {
            Console.WriteLine("");
            Console.WriteLine($"It's {player.Name} turn");
            Attack(player, monster);
            if (monster.Health <= 0)
            {
                Console.WriteLine($"{player.Name} wins");
                return player.Name;
            }

            Console.WriteLine($"It's {monster.Name} turn");
            Attack(monster, player);
            if (player.Health <= 0)
            {
                Console.WriteLine($"{player.Name} lost");
                return monster.Name;
            }
        }
        return "";
    }
    public int Attack(Character attack, Character target)
    {
        int Damage = attack.AttackPower - target.Defense;
        if (Damage < 0)
        {
            Damage = 0;

        }

        target.Health -= Damage;
        if (target.Health < 0)
        {
            target.Health = 0;
        }
        Console.WriteLine($"{attack.Name} attacks {target.Name}");
        Console.WriteLine($"The damage is {Damage}");
        Console.WriteLine($"The health is {target.Health}");
        return Damage;
    }
}