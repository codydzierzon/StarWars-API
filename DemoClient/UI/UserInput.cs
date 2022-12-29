using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient.UI
{
    public class UserInput
    {
        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void PauseOnScreen()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
        public static void MainMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What do you want to see?");
            Console.WriteLine("1) Characters");
            Console.WriteLine("2) Planets");
            Console.WriteLine("3) Star Ships");
            Console.WriteLine("4) Vehicles");
            Console.WriteLine("5) Films");
            Console.WriteLine("0) Quit");
            Console.WriteLine();
            Console.Write("Make a selection: ");
        }
        public static void CharacterSelection()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a character number: ");
        }

        public static void PlanetSelection()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a planet number: ");
        }

        public static void ShipSelection()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a ship number: ");
        }

        public static void VehicleSelection()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a vehicle number: ");
        }
        public static void FilmSelection()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a film number: ");
        }

    }
}
