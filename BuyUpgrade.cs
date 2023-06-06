namespace KlikkerspillInterface;

public class BuyUpgrade : ICommand
{
    public void Run(ClickerGame game)
    {
        game.points -= 10;
        game.pointsPerClick += game.pointsPerClickIncrease;
    }
}