using System.Linq.Expressions;

namespace Adventure_Quest_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Player player = new Player(name: "Hero");
                Adventure adventure = new Adventure(player);
                adventure.Start();

                Console.WriteLine("Adventure complete!");

            
           

        }
    }
}
