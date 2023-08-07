namespace KlikkerspillInterface;

public class GetPoints : ICommand
{
    public void Run(ClickerGame game)
    {
        game.points += game.pointsPerClick;
    }
}