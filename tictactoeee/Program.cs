using System;
using System.Security.Cryptography;

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
            bool JeKonec = false;

            PrintBoard(); // Vykreslí hrací pole
            while (true)
            {
                Hrac();
                PrintBoard(); // Vykreslí hrací pole

                if (JePlna()) // Pokud je deska plná
                {
                    Console.WriteLine("Hra je remíza, protože není volné místo!");
                    break;
                }
                if (HracVyhral == true)
                {
                    Console.WriteLine("Hráč vyhrál!!!");
                    break;
                }
                if (RobotVyhral == true)
                {
                    Console.WriteLine("Hráč vyhrál!!!");
                    break;
                }


            }
            Console.ReadKey();
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
            int RadekHrac = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš sloupec kam chces polozit");
            int SloupecHrac = int.Parse(Console.ReadLine());
            Console.WriteLine();

            
            if (board[RadekHrac, SloupecHrac] == ' ') 
            {
                board[RadekHrac, SloupecHrac] = 'X';
            }
            else
            {
                Console.WriteLine("Toto místo už je obsazeno, zvol jiný.");
                Console.WriteLine();
                Hrac(); // Opakuj tah, pokud místo je obsazené
            }

        }
        static void StavHry()
        {

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        static bool JePlna()
        {
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            
            return true;
        }
    }
}
