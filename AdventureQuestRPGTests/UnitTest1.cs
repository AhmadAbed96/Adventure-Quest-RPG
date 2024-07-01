using Adventure_Quest_RPG;
namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void mosterAttack()
        {
            Monster mosterAttack = new Invoker();
            Player player = new Player();
            BattleSystem battleSystem = new BattleSystem();
            int damage = battleSystem.Attack(mosterAttack, player);
            Assert.Equal(5, damage);
        }
        [Fact]
        public void healthWinner()
        {
            Player player = new Player();
            Monster monster = new Invoker();
            BattleSystem healthSystem = new BattleSystem();
            string winner = healthSystem.StartBattle(player, monster);
            Assert.Equal("hero",winner);
        }
    }
}
