using System;
using DecoratorPattern.Skateboard;
using DecoratorPattern.Skateboard.Bearings;
using DecoratorPattern.Skateboard.BoardTypes;
using DecoratorPattern.Skateboard.BoardGraphics;
using DecoratorPattern.Skateboard.Griptape;
using DecoratorPattern.Skateboard.Trucks;
using DecoratorPattern.Skateboard.Wheels;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISkateboard board = new BaseSkateboard();
            board = new Shortboard(board);
            board = new GraphicBoard(board);
            board = new PremiumBearings(board);
            board = new StandardGriptape(board);
            board = new ShortboardTrucks(board);
            board = new ShortboardWheels(board);

            Console.WriteLine("DESC:\t " + board.GetDescription());
            Console.WriteLine("COST:\t " + board.GetCost());
        }
    }
}
