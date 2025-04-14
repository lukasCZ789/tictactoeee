using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace tictactoeee
{
    internal class Program
    {
        static char[,] board = {
            { ' ', ' ', ' ' , ' '},
            { ' ', ' ', ' ' , ' '},
            { ' ', ' ', ' ' , ' '},
            { ' ', ' ', ' ' , ' '}
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
                if (HracVyhral == true)//HracVyhral?
                {
                    Console.WriteLine("Hráč vyhrál!!!");
                    break;
                }
                if (RobotVyhral == true)//RobotVyhral?
                {
                    Console.WriteLine("Hráč vyhrál!!!");
                    break;
                }
                Pocitac();
                PrintBoard();

                if (JePlna()) // Pokud je deska plná
                {
                    Console.WriteLine("Hra je remíza, protože není volné místo!");
                    break;
                }
                if (HracVyhral == true)//HracVyhral?
                {
                    Console.WriteLine("Hráč vyhrál!!!");
                    break;
                }
                if (RobotVyhral == true)//RobotVyhral?
                {
                    Console.WriteLine("Hráč vyhrál!!!");
                    break;
                }



            }
            Console.ReadKey();
        } 











        static void PrintBoard() // Vykreslovani hracího pole
        {
            Console.WriteLine("  0 1 2 3");

            // První řádek
            Console.Write("0 ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(board[0, i]);
                if (i < 3) Console.Write("|");
            }
            Console.WriteLine();

            // Druhý řádek
            Console.Write("1 ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(board[1, j]);
                if (j < 3) Console.Write("|");
            }
            Console.WriteLine();
            // tretí řádek
            Console.Write("2 ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(board[2, j]);
                if (j < 3) Console.Write("|");
            }
            Console.WriteLine();
       
            // tretí řádek
            Console.Write("3 ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(board[3, j]);
                if (j < 3) Console.Write("|");
            }
            Console.WriteLine();
          
        }

        static void Pocitac()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0;j<= 1; j++)
                {
                    if (board[i, j] == 'X' && board[i, j+1] == 'X' && board[i,j+2] =='X' && board[i,j+3] == ' ')
                    {
                        board[i, j + 3] = 'O';
                        return;
                    }
                    if (board[i, j] == 'X' && board[i, j + 1] == 'X' && board[i, j + 2] == ' ' && board[i, j + 3] == 'X')
                    {
                        board[i, j + 2] = 'O';
                        return;
                    }
                    if (board[i, j] == 'X' && board[i, j + 1] == ' ' && board[i, j + 2] == 'X' && board[i, j + 3] == 'X')
                    {
                        board[i, j + 1] = 'O';
                        return;
                    }
                    if (board[i, j] == ' ' && board[i, j + 1] == 'X' && board[i, j + 2] == 'X' && board[i, j + 3] == 'X')
                    {
                        board[i, j] = 'O';
                        return;
                    }
                }
            }
            // 2. (svisle)
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i <= 0; i++)
                {
                    if (board[i, j] == 'X' && board[i + 1, j] == 'X' && board[i + 2, j] == 'X' && board[i + 3, j] == ' ')
                    {
                        board[i + 3, j] = 'O'; return;
                    }
                    if (board[i, j] == 'X' && board[i + 1, j] == 'X' && board[i + 2, j] == ' ' && board[i + 3, j] == 'X')
                    {
                        board[i + 2, j] = 'O'; return;
                    }
                    if (board[i, j] == 'X' && board[i + 1, j] == ' ' && board[i + 2, j] == 'X' && board[i + 3, j] == 'X')
                    {
                        board[i + 1, j] = 'O'; return;
                    }
                    if (board[i, j] == ' ' && board[i + 1, j] == 'X' && board[i + 2, j] == 'X' && board[i + 3, j] == 'X')
                    {
                        board[i, j] = 'O'; return;
                    }
                }
            }
            for (int i = 0; i <= 0; i++)
            {
                for (int j = 0; j <= 0; j++)
                {
                    if (board[i, j] == 'X' && board[i + 1, j + 1] == 'X' && board[i + 2, j + 2] == 'X' && board[i + 3, j + 3] == ' ')
                    {
                        board[i + 3, j + 3] = 'O'; return;
                    }
                    if (board[i, j] == 'X' && board[i + 1, j + 1] == 'X' && board[i + 2, j + 2] == ' ' && board[i + 3, j + 3] == 'X')
                    {
                        board[i + 2, j + 2] = 'O'; return;
                    }
                    if (board[i, j] == 'X' && board[i + 1, j + 1] == ' ' && board[i + 2, j + 2] == 'X' && board[i + 3, j + 3] == 'X')
                    {
                        board[i + 1, j + 1] = 'O'; return;
                    }
                    if (board[i, j] == ' ' && board[i + 1, j + 1] == 'X' && board[i + 2, j + 2] == 'X' && board[i + 3, j + 3] == 'X')
                    {
                        board[i, j] = 'O'; return;
                    }
                }
            }

            // 4. Vedlejší diagonála (↙)
            for (int i = 0; i <= 0; i++)
            {
                for (int j = 3; j >= 3; j--)
                {
                    if (board[i, j] == 'X' && board[i + 1, j - 1] == 'X' && board[i + 2, j - 2] == 'X' && board[i + 3, j - 3] == ' ')
                    {
                        board[i + 3, j - 3] = 'O'; return;
                    }
                    if (board[i, j] == 'X' && board[i + 1, j - 1] == 'X' && board[i + 2, j - 2] == ' ' && board[i + 3, j - 3] == 'X')
                    {
                        board[i + 2, j - 2] = 'O'; return;
                    }
                    if (board[i, j] == 'X' && board[i + 1, j - 1] == ' ' && board[i + 2, j - 2] == 'X' && board[i + 3, j - 3] == 'X')
                    {
                        board[i + 1, j - 1] = 'O'; return;
                    }
                    if (board[i, j] == ' ' && board[i + 1, j - 1] == 'X' && board[i + 2, j - 2] == 'X' && board[i + 3, j - 3] == 'X')
                    {
                        board[i, j] = 'O'; return;
                    }
                }
            }
            Random rnd = new Random();
            while (true)
            {
                int x = rnd.Next(0, 4);
                int y = rnd.Next(0, 4);
                if (board[x, y] == ' ')
                {
                    board[x, y] = 'O';
                    return;
                }
            }
        
    }







        static void Hrac()// hrac 
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
                Hrac(); // Opakuj tah
            }

        }





        static void JeVyhra(bool HracVyhral, bool RobotVyhral) // kontrola vyhry
        {
            //Kontrola radku
            for (int i = 0; i < 4; i++)
            {
                if (board[i, 0] == 'X' && board[i, 1] == 'X' && board[i, 2] == 'X' && board[i, 3] == 'X')
                {
                    HracVyhral = true; 
                }
                if (board[i, 0] == 'O' && board[i, 1] == 'O' && board[i, 2] == 'O' && board[i, 3] == 'O')
                {
                    RobotVyhral = true; 
                }
            }
            //Kontrola slopcu
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == 'X' && board[1, i] == 'X' && board[2, i] == 'X' && board[3, i] == 'X')
                {
                    HracVyhral = true; 
                }
                if (board[0, i] == 'O' && board[1, i] == 'O' && board[2, i] == 'O' && board[3, i] == 'O')
                {
                    RobotVyhral = true; 
                }

            }
            if(board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X' && board[3, 3] == 'X')
    {
                HracVyhral = true; // Nastaví, že hráč vyhrál
            }
            if (board[0, 3] == 'X' && board[1, 2] == 'X' && board[2, 1] == 'X' && board[3, 0] == 'X')
            {
                HracVyhral = true; // Nastaví, že hráč vyhrál
            }

            if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O' && board[3, 3] == 'O')
            {
                RobotVyhral = true; // Nastaví, že robot vyhrál
            }
            if (board[0, 3] == 'O' && board[1, 2] == 'O' && board[2, 1] == 'O' && board[3, 0] == 'O')

            {
                RobotVyhral = true; // Nastaví, že robot vyhrál
            }


        }









            static bool JePlna()// kontrola jestli neni tabulka plna
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            
            return true;
        }
    }
}
