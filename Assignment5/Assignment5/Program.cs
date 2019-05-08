using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        public const int SIZE = 8;
        public static string[][] board;

        static void Main(string[] args)
        {
            CreateBoard();
            PrintBoard();
            movePiece();
            Console.ReadKey();

            //while (user inputs int within array)
            //{
        //      printBoard();
        //      movePiece();
        //     }
            


            void CreateBoard()
            {
                Program.board = new string[SIZE][];
                for (int i = 0; i < SIZE; i++)
                {
                    board[i] = new string[SIZE];
                    for (int j = 0; j < SIZE; j++)
                    {
                        board[i][j] = (i < 2 || i > 5) ? "X" : " ";
                    }
                }
            }

            void printDivider()
            {
                Console.WriteLine("----------------------------------");
            }

            void PrintBoard()
            {
                Console.Clear();
                Console.WriteLine("   0   1   2   3   4   5   6   7");
                for (int i = 0; i < SIZE; i++)
                {
                    printDivider();

                    Console.Write(i + "| ");

                    for (int j = 0; j < SIZE; j++)
                    {
                        Console.Write(board[i][j] + " | ");

                    }

                    Console.WriteLine();
                }
                printDivider();
            }

            void promtUser(string axis)
            {
                Console.WriteLine("Enter a " + axis + " coordinate between 0 and 7: ");
            }

            string pickPiece()
            {
                promtUser("x");
                int coordinateX = int.Parse(Console.ReadLine());
                promtUser("y");
                int coordinateY = int.Parse(Console.ReadLine());

                return board[coordinateY][coordinateX] = " ";
                
            }

            string pickDestination()
            {
                Console.WriteLine("Pick a location to move your piece. ");
                promtUser("x");
                int newcoordinateX = int.Parse(Console.ReadLine());
                promtUser("y");
                int newcoordinateY = int.Parse(Console.ReadLine());

                return board[newcoordinateY][newcoordinateX] = "X";
            }

            void movePiece()
            {
                
                pickPiece();
                pickDestination();
                PrintBoard();
            }

         }
    }
}
