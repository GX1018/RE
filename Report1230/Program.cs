using report1226;
using static report1226.CoinCreate;

namespace Report1230
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoardSet boardset = new BoardSet();
            CoinCreate coinCreate = new CoinCreate();
            PlayPhase play = new PlayPhase();

            boardset.BoardSet_();

            coinCreate.arrayHomework = boardset.arrayHomework;

            coinCreate.createCoin();

            play.arrayHomework = coinCreate.arrayHomework;

            play.coinNumber = coinCreate.coinNumber;

            play.locationX = boardset.locationX;
            play.locationY = boardset.locationY;

            while (play.endChcek)
            {
                play.MoveCharacter();
                play.EndCheck();
            }
        }
    }
}