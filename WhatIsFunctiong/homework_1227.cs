using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunctiong
{
    internal class homework_1227
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();

            const int BOARD_SIZE_X = 5;
            const int BOARD_SIZE_Y = 5;
            int z = 0;

            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    gameBoard[y, x] = 0;

                    if (x == BOARD_SIZE_X / 2 && y == BOARD_SIZE_Y / 2)
                    {
                        gameBoard[y, x] = 0;
                        Console.Write("★");
                    }

                    else if (x == 0 || y == 0 || x == BOARD_SIZE_X - 1 || y == BOARD_SIZE_Y - 1)
                    {
                        gameBoard[y, x] = 1;
                        Console.Write("□");

                    }
                    else 
                    {
                        gameBoard[y, x] = arr[z];
                        Console.Write("{0} ", arr[z]);
                        z++;
                    }
                }
                Console.WriteLine();
                
            }
            int temp = 0;
            int a = BOARD_SIZE_X / 2; int b = BOARD_SIZE_X / 2;
            while (true)
            {
                Console.WriteLine("이동하고 싶은 방향을 입력하세요\n .을 누르면 종료합니다");
                string inputDirection = Console.ReadLine();
                switch (inputDirection)
                {
                    case "a":
                        if (b == 1)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else
                        {
                            temp = gameBoard[a, b - 1];
                            gameBoard[a, b - 1] = gameBoard[a, b];
                            gameBoard[a, b] = temp;
                            b--;
                        }
                        break;
                    case "d":
                        if (b == gameBoard.GetLength(0) - 2)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else
                        {
                            temp = gameBoard[a, b + 1];
                            gameBoard[a, b + 1] = gameBoard[a, b];
                            gameBoard[a, b] = temp;
                            b++;
                        }
                        break;
                    case "w":
                        if (a == 1)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else
                        {
                            temp = gameBoard[a - 1, b];
                            gameBoard[a - 1, b] = gameBoard[a, b];
                            gameBoard[a, b] = temp;
                            a--;
                        }
                        break;
                    case "s":
                        if (a == gameBoard.GetLength(1) - 2)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else
                        {
                            temp = gameBoard[a + 1, b];
                            gameBoard[a + 1, b] = gameBoard[a, b];
                            gameBoard[a, b] = temp;
                            a++;
                        }
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }


                for (int u = 0; u < gameBoard.GetLength(0); u++)
                {
                    for (int o = 0; o < gameBoard.GetLength(1); o++)
                    {
                        Console.Write("{0}", gameBoard[u, o]);
                    }
                    Console.WriteLine();
                }
                if (inputDirection == ".") { break; }
            }
        }


        }
    }





//  11  21  31
//  12  22  32
//  13  23  33