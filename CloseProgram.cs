namespace KlikkerspillInterface;

public class CloseProgram : ICommand
{
    public void Run(ClickerGame game)
    {
        Environment.Exit(0);
    }
}