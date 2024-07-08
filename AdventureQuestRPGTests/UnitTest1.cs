using Adventure_Quest_RPG;

namespace AdventureQuestRPGTests
{
    public class Adventure_QuestRPGTests
    {
        [Fact]
        public void TestEncounterBossMonster()
        {
            // Arrange
            Player player = new Player("TestHero");
            Adventure adventure = new Adventure(player);

            List<Monster> monsters = new List<Monster>
        {
            new Invoker("Invoker"),
            new Chen("Chen"),
            new BossMonster("Dragon")
        };

            Monster bossMonster = monsters.Find(monster => monster is BossMonster);

            // Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.StartBattle(player, bossMonster);

            // Assert
            Assert.Equal("Dragon", bossMonster.Name);
        }

        [Fact]
        public void TestDiscoverNewLocation()
        {
            // Arrange
            Player player = new Player(name: "Hero");
            var adventure = new Adventure(player);
            string input = "3"; 
            var inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            // Act
            adventure.DiscoverNewLocation();

            // Assert
            Assert.Equal("Cave", adventure.CurrentLocation);
        }
    }
}
