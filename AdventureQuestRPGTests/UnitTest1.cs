using Adventure_Quest_RPG;
namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void playerAttack()
        {
            Player player = new Player();
            Monster monster = new Invoker();
            BattleSystem battel = new BattleSystem();
            battel.Attack(player, monster);
            int result = monster.Health;

            Assert.Equal (85, result);
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
            

            Assert.Equal( "hero",winner);
        }
    }
}