namespace KlikkerspillInterface;

public class BuySuperUpgrade : ICommand
{
    public void Run(ClickerGame game)
    {
        game.points -= 100;
        game.pointsPerClickIncrease++;
    }
}