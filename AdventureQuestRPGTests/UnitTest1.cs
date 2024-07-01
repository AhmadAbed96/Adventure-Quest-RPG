using Adventure_Quest_RPG;
namespace AdventureQuestRPGTests
{
    public class Adventure_QuestRPGTests
    {
        [Fact]
        public void playerAttack()
        {
            Player player = new Player();
            Monster monster = new Invoker();
            BattleSystem battel = new BattleSystem();
            int health = battel.Attack(player, monster);

            Assert.Equal(15, health);
        }

        [Fact]
        public void monsterAttack()
        {
            Player player = new Player();
            Monster monster = new Invoker();
            BattleSystem battel = new BattleSystem();
            battel.Attack(monster, player);
            int result = player.Health;

            Assert.Equal(95, result);
        }

        [Fact]
        public void winner()
        {
            Player player = new Player();
            Monster monster = new Invoker();
            BattleSystem battel = new BattleSystem();
            string winner = battel.StartBattle(monster, player);


            Assert.Equal("hero", winner);
        }

    }
}

