using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0104
{
    internal class InGame
    {
        GameSetting gameSetting= new GameSetting();
        Program program= new Program();
        
        //캐릭터 움직임
        public void MoveCharacter(string[,]arrayName, ref int locationX, ref int locationY, ref bool endCheck, ref bool gameEndCheck)
        {
            string temp;
            endCheck = true;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            
            switch(keyInfo.KeyChar)
            {
                case 'a' :
                    Console.Clear();
                    temp = arrayName[locationX, locationY];
                    arrayName[locationX, locationY] = arrayName[locationX-1, locationY];
                    arrayName[locationX - 1, locationY]=temp;
                    if (arrayName[locationX , locationY]== "▩")
                    {
                        endCheck = false;
                    }
                    if (arrayName[locationX, locationY] == "♥")
                    {
                        endCheck = false;
                        gameEndCheck = false;
                    }
                    break;
                case 'd':
                    Console.Clear();
                    temp = arrayName[locationX, locationY];
                    arrayName[locationX, locationY] = arrayName[locationX + 1, locationY];
                    arrayName[locationX + 1, locationY] = temp;
                    if (arrayName[locationX , locationY] == "▩")
                    {
                        endCheck = false;
                    }
                    if (arrayName[locationX, locationY] == "♥")
                    {
                        endCheck = false;
                        gameEndCheck = false;
                    }
                    break;
                case 'w':
                    Console.Clear();
                    temp = arrayName[locationX, locationY];
                    arrayName[locationX, locationY] = arrayName[locationX, locationY-1];
                    arrayName[locationX, locationY-1] = temp;
                    if (arrayName[locationX, locationY] == "▩")
                    {
                        endCheck = false;
                    }
                    if (arrayName[locationX, locationY] == "♥")
                    {
                        endCheck = false;
                        gameEndCheck = false;
                    }
                    break;
                case 's':
                    Console.Clear();
                    temp = arrayName[locationX, locationY];
                    arrayName[locationX, locationY] = arrayName[locationX, locationY + 1];
                    arrayName[locationX, locationY + 1] = temp;
                    if (arrayName[locationX, locationY] == "▩")
                    {
                        endCheck = false;
                    }
                    if (arrayName[locationX, locationY] == "♥")
                    {
                        endCheck = false;
                        gameEndCheck = false;
                    }
                    break;
            }


        }


        //캐릭터 위치 찾는 함수
        public void CharacterLocation(string[,] arrayName, ref int locationX, ref int locationY)
        {
            for (int index = 0; index < arrayName.GetLength(0); index++)
            {
                for (int index_ = 0; index_ < arrayName.GetLength(1); index_++)
                {
                    if (arrayName[index, index_] == "★")
                    {
                        locationX = index;
                        locationY=index_;
                    }
                }
                Console.WriteLine();
            }
        }

        //게이트 위치 찾는 함수

        public void GateLocation(string[,] arrayName, ref int locationX, ref int locationY)
        {
            for (int index = 0; index < arrayName.GetLength(0); index++)
            {
                for (int index_ = 0; index_ < arrayName.GetLength(1); index_++)
                {
                    if (arrayName[index, index_] == "▩")
                    {
                        locationX = index;
                        locationY = index_;
                    }
                }
                Console.WriteLine();
            }
        }



        
    }
}
