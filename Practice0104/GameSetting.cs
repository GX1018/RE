using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0104
{
    internal class GameSetting
    {

        //보드판 생성

        //시작
        public void BoardSizeSetting(out string[,] boardName)
        {
            Console.WriteLine("보드의 크기를 입력하세요\n[N]X[N]Size");
            int boardSize;
            int.TryParse(Console.ReadLine(), out boardSize);

            boardName = new string[boardSize, boardSize];
        }


        public void BoardSetting(string[,] boardName)
        { 

            for (int index = 0; index < boardName.GetLength(0); index++)
            {
                for (int index_ = 0; index_ < boardName.GetLength(1); index_++)
                {
                    if (index == 0 || index == boardName.GetLength(0) - 1)
                    {
                        boardName[index_, index] = "■";
                    }
                    else if (index_ == 0 || index_ == boardName.GetLength(1) - 1)
                    {
                        boardName[index_, index] = "■";
                    }
                    else
                    {
                        boardName[index_, index] = "□";
                    }
                }
            }
        }
        
        
        //보드 시각화
        public void PrintBoard(string[,] arrayName)
        {
            for (int index = 0; index < arrayName.GetLength(0); index++)
            {
                for (int index_ = 0; index_ < arrayName.GetLength(1); index_++)
                {
                    Console.Write(arrayName[index_, index]);
                }
                Console.WriteLine();
            }
        }
        
        
        //시작 위치 설정
        public void StartLocation(string[,] arrayName)
        {
            arrayName[arrayName.GetLength(0) / 2, arrayName.GetLength(0) / 2] = "★";
        }

        
        //게이트 생성
        public void GateCreate(string[,]boardName)
        {
            Random random = new Random();
            int location = random.Next(0,4);
            switch (location)
            {
                case 0:
                    boardName[0, boardName.GetLength(0) / 2] = "▩";
                    break;
                case 1:
                    boardName[boardName.GetLength(0)-1, boardName.GetLength(0) / 2] = "▩";
                    break;
                case 2:
                    boardName[boardName.GetLength(0)/2, 0] = "▩";
                    break;
                case 3:
                    boardName[boardName.GetLength(0)/2, boardName.GetLength(0)-1] = "▩";
                    break;
                default:
                    break;
            }
        }

        //게이트 진입 후 보드 게이트 설정  //게이트
        public void NextChamberGateLocation(string[,] boardName, ref int gateLocationX, ref int gateLocationY, ref int charLocationX, ref int charLocationY)
        {
            if(boardName[1, boardName.GetLength(0) / 2] == "▩")     //0,3
            {
                gateLocationX = boardName.GetLength(0)-1;
                gateLocationY = boardName.GetLength(0)/2;     //3,6
                boardName[gateLocationX, gateLocationY] = "▩";
                charLocationX=gateLocationX-1; 
                charLocationY= gateLocationY;
                boardName[charLocationX, charLocationY] = "★";

            }
            else if (boardName[boardName.GetLength(0) - 2, boardName.GetLength(0) / 2] == "▩")  //5,3
            {
                gateLocationX = 0;
                gateLocationY = boardName.GetLength(0) / 2;
                charLocationX = gateLocationX+1;
                charLocationY = gateLocationY;
                boardName[charLocationX, charLocationY] = "★";

            }
            else if (boardName[boardName.GetLength(0) / 2, 1] == "▩")  //3,0
            {
                gateLocationX = boardName.GetLength(0)/2;
                gateLocationY = boardName.GetLength(0)-1;
                charLocationX = gateLocationX;
                charLocationY = gateLocationY-1;
                boardName[charLocationX, charLocationY] = "★";

            }
            else if (boardName[boardName.GetLength(0) / 2, boardName.GetLength(0) - 2] == "▩")
            {
                gateLocationX = boardName.GetLength(0) / 2;
                gateLocationY = 0;
                charLocationX = gateLocationX;
                charLocationY = gateLocationY+1;
                boardName[charLocationX, charLocationY] = "★";

            }
        }

        //게이트+캐릭터
        public void GateLocationAfterSecond(string[,] boardName, int gateLocationX, int gateLocationY,int charLocationX, int charLocationY)
        {
            boardName[gateLocationX, gateLocationY] = "▩";
            boardName[charLocationX, charLocationY] = "★";
        }



        //보물상자 생성
        public void CreateTreasureBox(string[,]arrayName)
        {
            Random random= new Random();
            //확률 10%
            int dice = random.Next(1, 101);
            if (dice <= 10) 
            {
                arrayName[arrayName.GetLength(0) / 2, arrayName.GetLength(0) / 2] = "♥";
            }
            else
            {

            }
        }

    }
}
