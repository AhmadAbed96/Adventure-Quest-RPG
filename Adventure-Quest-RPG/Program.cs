namespace Adventure_Quest_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RPG world!");
            Console.WriteLine("player vs monster");
            Console.WriteLine("fight");
            Console.WriteLine();
            Characters character = new Characters();
            Player player = new Player();
            Monster monster = new Invoker();
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.StartBattle(player, monster);

        }
    }
}
