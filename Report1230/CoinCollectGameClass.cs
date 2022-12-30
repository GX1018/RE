using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace report1226
{
    public class Parts
    {
        public int score = 0;
        public string[,] arrayHomework;
        public string temp = "";
        public string dot = ".";
        public int coinNumber;
        public int locationX = 0;
        public int locationY = 0;
        public bool endChcek = true;
    }


    public class BoardSet : Parts
    {
        public void BoardSet_()
        {
            Console.WriteLine("보드의 크기(홀수)를 입력하세요 [N] X [N]");
            int boardSize = int.Parse(Console.ReadLine());
            arrayHomework = new string[boardSize, boardSize];


            if (boardSize % 2 == 0)
            { Console.WriteLine("잘못 입력하셨습니다."); }
            else
            {
                for (int x = 0; x < arrayHomework.GetLength(0); x++)
                {
                    for (int y = 0; y < arrayHomework.GetLength(1); y++)
                    {
                        if (y == arrayHomework.GetLength(1) / 2 && x == arrayHomework.GetLength(0) / 2)
                        {
                            arrayHomework[x, y] = "옷";      //[2,2]
                        }
                        else if (x == 0 || y == 0 || x == arrayHomework.GetLength(0) - 1 || y == arrayHomework.GetLength(1) - 1)
                        {
                            arrayHomework[x, y] = "■";
                        }
                        else
                        {
                            arrayHomework[x, y] = ". ";

                        }
                    }
                }
            }

            Console.WriteLine("[SCORE : {0}]", score);
            for (int x = 0; x < arrayHomework.GetLength(0); x++)
            {
                for (int y = 0; y < arrayHomework.GetLength(1); y++)
                {
                    Console.Write("{0}", arrayHomework[x, y]);
                }
                Console.WriteLine();
            }
            locationX = arrayHomework.GetLength(0) / 2;
            locationY = arrayHomework.GetLength(1) / 2;

        }

    }

    public class CoinCreate : BoardSet
    {

        public void createCoin()
        {

            Console.WriteLine("코인을 몇개 생성하시겠습니까?");
            coinNumber = int.Parse(Console.ReadLine());
            while (true)
            {
                int countCoin = 0;
                Random random = new Random();
                int indexX = random.Next(1, arrayHomework.GetLength(0) - 1);
                int indexY = random.Next(1, arrayHomework.GetLength(1) - 1);
                if (arrayHomework[indexX, indexY] == "옷") { /*Do Nothing*/ }
                else { arrayHomework[indexX, indexY] = "◎"; }

                Console.Clear();
                ////딜레이??
                Console.WriteLine("[SCORE : {0}]", score);
                for (int x = 0; x < arrayHomework.GetLength(0); x++)
                {
                    for (int y = 0; y < arrayHomework.GetLength(1); y++)
                    {
                        Console.Write("{0}", arrayHomework[x, y]);
                    }
                    Console.WriteLine();
                }

                for (int x = 0; x < arrayHomework.GetLength(0); x++)
                {
                    for (int y = 0; y < arrayHomework.GetLength(1); y++)
                    {
                        if (arrayHomework[x, y] == "◎")
                        {
                            countCoin++;
                        }
                    }
                }
                Task.Delay(200).Wait();
                if (countCoin == coinNumber)
                {
                    break;
                }

            }
        }

        public class PlayPhase : CoinCreate
        {
            public void MoveCharacter()
            {
                //Console.WriteLine("이동하고 싶은 방향을 입력하세요");

                ConsoleKeyInfo inputKey;
                inputKey = Console.ReadKey(true);
                Console.Clear();
                switch (inputKey.Key)
                {
                    case ConsoleKey.A:
                        if (locationY == 1)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else if (arrayHomework[locationX, locationY - 1] == "◎")
                        {
                            arrayHomework[locationX, locationY - 1] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = ". ";
                            locationY--;
                            score++;
                        }
                        else
                        {
                            temp = arrayHomework[locationX, locationY - 1];
                            arrayHomework[locationX, locationY - 1] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = temp;
                            locationY--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (locationY == arrayHomework.GetLength(0) - 2)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else if (arrayHomework[locationX, locationY + 1] == "◎")
                        {
                            arrayHomework[locationX, locationY + 1] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = ". ";
                            score++;
                            locationY++;
                        }
                        else
                        {
                            temp = arrayHomework[locationX, locationY + 1];
                            arrayHomework[locationX, locationY + 1] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = temp;
                            locationY++;
                        }
                        break;
                    case ConsoleKey.W:
                        if (locationX == 1)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }

                        else if (arrayHomework[locationX - 1, locationY] == "◎")
                        {
                            arrayHomework[locationX - 1, locationY] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = ". ";
                            locationX--;
                            score++;

                        }

                        else
                        {
                            temp = arrayHomework[locationX - 1, locationY];
                            arrayHomework[locationX - 1, locationY] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = temp;
                            locationX--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (locationX == arrayHomework.GetLength(1) - 2)
                        { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                        else if (arrayHomework[locationX + 1, locationY] == "◎")
                        {
                            arrayHomework[locationX + 1, locationY] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = ". ";
                            locationX++;
                            score++;

                        }
                        else
                        {
                            temp = arrayHomework[locationX + 1, locationY];
                            arrayHomework[locationX + 1, locationY] = arrayHomework[locationX, locationY];
                            arrayHomework[locationX, locationY] = temp;
                            locationX++;
                        }
                        break;
                    default:
                        Console.WriteLine("[System]잘못 입력하셨습니다.");
                        break;
                }
                Console.WriteLine("[SCORE : {0}]", score);
                for (int x = 0; x < arrayHomework.GetLength(0); x++)
                {
                    for (int y = 0; y < arrayHomework.GetLength(1); y++)
                    {
                        Console.Write("{0}", arrayHomework[x, y]);
                    }
                    Console.WriteLine();
                }

            }

            public void EndCheck()
            {
                if (coinNumber == score) 
                {
                    Console.WriteLine("PLAYER WIN");
                    
                    endChcek = false; 
                }

            }


        }
    }
}
