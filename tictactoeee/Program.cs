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
            Console.WriteLine("Tvůj znak je X");

            bool RobotVyhral = false;
            bool HracVyhral = false;

            PrintBoard(); // Vykreslí hrací pole
            while (true)
            {
                Hrac();
                PrintBoard(); // Vykreslí hrací pole
            if 
            }
        }

        static void PrintBoard()
        {
            Console.WriteLine("  0 1 2");

            // První řádek
            Console.Write("0 ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(board[0, i]);
                if (i < 2) Console.Write("|");
            }
            Console.WriteLine();

            // Druhý řádek
            Console.Write("1 ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[1, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine(); 
            // tretí řádek
            Console.Write("2 ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[2, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Hrac()
        {
            Console.WriteLine("Napiš řádek kam chces polozit");
            int RadekHrac  = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš sloupec kam chces polozit");
            int SloupecHrac = int.Parse(Console.ReadLine());

            board[RadekHrac, SloupecHrac] = 'X';

        }
    }
}
