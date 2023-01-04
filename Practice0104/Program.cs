namespace Practice0104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board;
            

            //캐릭터 좌표
            int charLocationX = 0;
            int charLocationY = 0;

            int gateLocationX = 0;
            int gateLocationY = 0;


            GameSetting gameSetting = new GameSetting();
            InGame inGame = new InGame();

            gameSetting.BoardSizeSetting(out board);
            gameSetting.BoardSetting(board);
            gameSetting.StartLocation(board);

            gameSetting.GateCreate(board);
            gameSetting.PrintBoard(board);

            inGame.CharacterLocation(board, ref charLocationX, ref charLocationY);
            inGame.GateLocation(board, ref gateLocationX, ref gateLocationY);


            bool gameEndCheck = true;

            //첫번째 방
            bool endCheck = true;
            while (endCheck)
            {
                inGame.CharacterLocation(board, ref charLocationX, ref charLocationY);
                inGame.MoveCharacter(board, ref charLocationX, ref charLocationY, ref endCheck, ref gameEndCheck);
                inGame.CharacterLocation(board, ref charLocationX, ref charLocationY);

                gameSetting.PrintBoard(board);
                                
            }
            Console.Clear();

            //

            //이후 

            while (gameEndCheck)
            {
                gameSetting.NextChamberGateLocation(board, ref gateLocationX, ref gateLocationY, ref charLocationX, ref charLocationY);
                gameSetting.BoardSetting(board);
                gameSetting.GateLocationAfterSecond(board, gateLocationX, gateLocationY, charLocationX, charLocationY);
                gameSetting.GateCreate(board);
                gameSetting.CreateTreasureBox(board);
                gameSetting.PrintBoard(board);

                //보물상자 생성
                
                endCheck = true;
                while (endCheck)
                {
                    inGame.CharacterLocation(board, ref charLocationX, ref charLocationY);
                    inGame.MoveCharacter(board, ref charLocationX, ref charLocationY, ref endCheck, ref gameEndCheck);
                    inGame.CharacterLocation(board, ref charLocationX, ref charLocationY);

                    gameSetting.PrintBoard(board);
                }
                Console.Clear();
            }
            Console.WriteLine("게임끝!");
            Console.ReadLine();





























            //board = new string[7, 7];

            //for (int index = 0; index < board.GetLength(0); index++)
            //{
            //    for (int index_ = 0; index_ < board.GetLength(1); index_++)
            //    {
            //        if (index == 0 || index == board.GetLength(0) - 1)
            //        {
            //            board[index_, index] = "■";
            //        }
            //        else if (index_ == 0 || index_ == board.GetLength(1) - 1)
            //        {
            //            board[index_, index] = "■";
            //        }
            //        else
            //        {
            //            board[index_, index] = "□";
            //        }
            //    }
            //}

            //board[board.GetLength(0) / 2, board.GetLength(0) / 2] = "★";


            //for (int index = 0; index < board.GetLength(0); index++)
            //{
            //    for (int index_ = 0; index_ < board.GetLength(1); index_++)
            //    {
            //        Console.Write(board[index_, index]);
            //    }
            //    Console.WriteLine();
            //}


            ////캐릭터 위치 찾기
            //for (int index = 0; index < board.GetLength(0); index++)
            //{
            //    for (int index_ = 0; index_ < board.GetLength(1); index_++)
            //    {
            //        if (board[index, index_] == "★")
            //        {
            //            Console.WriteLine("{0},{1}", index, index_);
            //        }
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}

//사람 움직이는 포탈 만들기