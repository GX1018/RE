namespace Prac_0104_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board;
            int playerLocX = 0;
            int playerLocY = 0;

            bool moveCheck = true;

            int hp = 100;
            int score = 0;

            GameSetting gameSetting = new GameSetting();
            Control ctl = new Control();

            gameSetting.BoardSize(out board);
            gameSetting.SettingBoard(board);
            gameSetting.CreateCharacter(board);
            gameSetting.CreateStairs(board);
            gameSetting.Createobstacle(board);
            gameSetting.CreateEnermy(board);
            gameSetting.CreateTrap(board);
            gameSetting.CreateGold(board);
            gameSetting.PrintBoard(board, hp, score);

            //시작층
            gameSetting.playerLocation(board, ref playerLocX, ref playerLocY);
            while (moveCheck)
            {
                moveCheck = true;
                gameSetting.playerLocation(board, ref playerLocX, ref playerLocY);
                ctl.PlayerMove(board, ref playerLocX, ref playerLocY, ref moveCheck, ref hp, ref score);
                gameSetting.playerLocation(board, ref playerLocX, ref playerLocY);
                Console.Clear();

                gameSetting.PrintBoard(board, hp, score);
            }
            Console.Clear();



            //다음층
            bool gameEndingCheck = true;
            while (gameEndingCheck)
            {
                moveCheck = true;
                gameSetting.CleaningMap(board);
                gameSetting.CreateStairs(board);
                gameSetting.Createobstacle(board);
                gameSetting.CreateEnermy(board);
                gameSetting.CreateTrap(board);
                gameSetting.CreateGold(board);
                gameSetting.PrintBoard(board, hp, score);
                while (moveCheck)
                {
                    gameSetting.playerLocation(board, ref playerLocX, ref playerLocY);
                    ctl.PlayerMove(board, ref playerLocX, ref playerLocY, ref moveCheck, ref hp, ref score);
                    gameSetting.playerLocation(board, ref playerLocX, ref playerLocY);
                    Console.Clear();

                    gameSetting.PrintBoard(board, hp, score);
                }
                Console.Clear();

                if (hp == 0)
                {
                    Console.WriteLine("DIE");
                    gameEndingCheck = false;
                }
                else if (score == 100)
                {
                    Console.WriteLine("WIN");
                    gameEndingCheck = false;
                }
            }






        }
    }
}