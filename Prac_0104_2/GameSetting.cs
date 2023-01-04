using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_0104_2
{
    internal class GameSetting
    {
        //보드 사이즈 설정
        public void BoardSize(out string[,] arrayName)
        {
            Console.WriteLine("맵 크기 설정");
            int size = int.Parse(Console.ReadLine());

            arrayName = new string[size, size];
        }

        //프린트 보드
        public void SettingBoard(string[,] arrayName)
        {
            for(int locX=0; locX<arrayName.GetLength(0); locX++)
            {
                for(int locY=0; locY<arrayName.GetLength(1); locY++)
                {
                    if (locX == 0 || locX == arrayName.GetLength(0) - 1)
                    {
                        arrayName[locX, locY] = "■";
                    }
                    else if (locY == 0 || locY == arrayName.GetLength(1) - 1)
                    {
                        arrayName[locX, locY] = "■";
                    }
                    else
                    {
                        arrayName[locX, locY] = "□";
                    }
                }
            }
        }

        public void PrintBoard(string[,] arrayName,int hp, int score)
        {
            Console.WriteLine("[HP : {0}]", hp);
            Console.WriteLine("[SCORE : {0}]", score);


            for (int locX = 0; locX < arrayName.GetLength(0); locX++)
            {
                for (int locY = 0; locY < arrayName.GetLength(1); locY++)
                {
                    Console.Write(arrayName[locX,locY]);
                }
                Console.WriteLine();
            }
        }

        //캐릭터 설정//빈칸중 랜덤으로 생성
        public void CreateCharacter(string[,] arrayName)
        {
            bool createdCheck = true;
            while (createdCheck)
            {
                Random random= new Random();
                int locationX = random.Next(0, arrayName.GetLength(0));
                int locationY = random.Next(0, arrayName.GetLength(1));
                if (arrayName[locationX, locationY] == "□")
                {
                    arrayName[locationX, locationY] = "★";
                    createdCheck = false;
                }
                else { /*Do nothing*/ }
            }
        }

        public void CreateStairs(string[,] arrayName)
        {
            bool createdCheck = true;
            while (createdCheck)
            {
                Random random = new Random();
                int locationX = random.Next(0, arrayName.GetLength(0));
                int locationY = random.Next(0, arrayName.GetLength(1));
                if (arrayName[locationX, locationY] == "□")
                {
                    arrayName[locationX, locationY] = "▼";
                    createdCheck = false;
                }
                else { /*Do nothing*/ }
            }
        }

        public void Createobstacle(string[,] arrayName)
        {
            bool createdCheck = true;
            int numberOfObstacle = 0;
            while (createdCheck)
            {
                Random random = new Random();
                int locationX = random.Next(0, arrayName.GetLength(0));
                int locationY = random.Next(0, arrayName.GetLength(1));
                if (arrayName[locationX, locationY] == "□")
                {
                    arrayName[locationX, locationY] = "■";
                    numberOfObstacle++;
                }
                else { /*Do nothing*/ }
                if (numberOfObstacle==arrayName.GetLength(0)) 
                {
                    createdCheck = false;
                }
            }
        }

        public void CreateEnermy(string[,] arrayName)
        {
            bool createdCheck = true;
            int numberOfObstacle = 0;
            while (createdCheck)
            {
                Random random = new Random();
                int locationX = random.Next(0, arrayName.GetLength(0));
                int locationY = random.Next(0, arrayName.GetLength(1));
                if (arrayName[locationX, locationY] == "□")
                {
                    arrayName[locationX, locationY] = "! ";
                    numberOfObstacle++;
                }
                else { /*Do nothing*/ }
                if (numberOfObstacle == arrayName.GetLength(0)/3)
                {
                    createdCheck = false;
                }
            }
        }

        public void CreateTrap(string[,] arrayName)
        {
            bool createdCheck = true;
            int numberOfObstacle = 0;
            while (createdCheck)
            {
                Random random = new Random();
                int locationX = random.Next(0, arrayName.GetLength(0));
                int locationY = random.Next(0, arrayName.GetLength(1));
                if (arrayName[locationX, locationY] == "□")
                {
                    arrayName[locationX, locationY] = "ㅗ";
                    numberOfObstacle++;
                }
                else { /*Do nothing*/ }
                if (numberOfObstacle == arrayName.GetLength(0) / 4)
                {
                    createdCheck = false;
                }
            }
        }

        public void CreateGold(string[,] arrayName)
        {
            bool createdCheck = true;
            int numberOfGold = 0;
            Random gold= new Random();
            int goldNum = gold.Next(0, 3);
            while (createdCheck)
            {
                Random random = new Random();
                int locationX = random.Next(0, arrayName.GetLength(0));
                int locationY = random.Next(0, arrayName.GetLength(1));
                if (arrayName[locationX, locationY] == "□")
                {
                    arrayName[locationX, locationY] = "◎";
                    numberOfGold++;
                }
                else { /*Do nothing*/ }
                if (numberOfGold == goldNum)
                {
                    createdCheck = false;
                }
            }
        }


        //플레이어 좌표
        public void playerLocation(string[,] arrayName, ref int locX, ref int locY)
        {
            for(int x = 0; x < arrayName.GetLength(0); x++)
            {
                for(int y = 0; y < arrayName.GetLength(1); y++)
                {
                    if (arrayName[x, y] == "★")
                    {
                        locX = x; 
                        locY = y;
                    }
                }
            }
        }

        public void CleaningMap(string[,]arrayName)
        {
            for (int locX = 0; locX < arrayName.GetLength(0); locX++)
            {
                for (int locY = 0; locY < arrayName.GetLength(1); locY++)
                {
                    if(locX == 0 || locX == arrayName.GetLength(0) - 1|| locY == 0 || locY == arrayName.GetLength(1) - 1) { /*do nothing*/}

                    else if (arrayName[locX, locY] == "▼")
                    {
                        arrayName[locX, locY] = "▲";
                    }
                    
                    else if (arrayName[locX, locY]=="■"|| arrayName[locX, locY]=="ㅗ" || arrayName[locX, locY] == "! " || arrayName[locX, locY] == "▲" || arrayName[locX, locY] == "◎")
                    {
                        arrayName[locX, locY] = "□";
                    }
                }
            }
        }
    }
}
