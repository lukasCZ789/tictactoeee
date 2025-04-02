using System;

namespace tictactoeee
{
    internal class Program
    {
        static char[,] board = {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Vítej ve hře piškvorky!!");
            Console.WriteLine();
            PrintBoard(); // Vykreslí hrací pole
        }

        static void PrintBoard()
        {
            Console.WriteLine("  0 1 2"); // Číslování sloupců
            Console.Write("0 "); // Číslo řádku

            for (int i = 0; i < 3; i++)
            {
                Console.Write(board[ 0,i]);
                if ( i == 0) Console.Write("|");
            }

            Console.WriteLine(); // Přechod na nový řádek
        }
    }
}
