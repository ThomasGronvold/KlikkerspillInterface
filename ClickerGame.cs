﻿namespace KlikkerspillInterface;

public class ClickerGame
{
    public int points;
    public int pointsPerClick = 1;
    public int pointsPerClickIncrease = 1;

    public void RunGame()
    {
        var runCommand = new CommandSet();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
            Console.WriteLine($"Du har {points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
            var command = Console.ReadKey().KeyChar;
            runCommand.RunCommand(command, this);
        }
    }
}