using System.Windows.Input;

namespace KlikkerspillInterface;

public class CommandSet
{
    private ICommand[] CommandArray { get; }

    public CommandSet()
    {
        CommandArray = new ICommand[4]
        {
            new BuySuperUpgrade(),
            new BuyUpgrade(),
            new CloseProgram(),
            new GetPoints()
        };
    }

    public void RunCommand(char Command, ClickerGame game)
    {
        if (Command == 'X')
        {
            CommandArray[2].Run(game);
        }
        else if (Command == ' ')
        { 
            CommandArray[3].Run(game);
        }
        else if (Command == 'K' && game.points >= 10)
        {
            CommandArray[1].Run(game);
        }
        else if (Command == 'S' && game.points >= 100)
        {
            CommandArray[0].Run(game);
        }
    }
}