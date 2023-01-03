namespace Poker_new
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> trumpCard = new List<int>();
            List<int> dealerHand = new List<int>();
            List<int> playerHand = new List<int>();



            CardSetting card = new CardSetting();

            card.MakeCardSet(trumpCard);
            card.Suffle(300, trumpCard);
            //card.PrintCardSet(trumpCard);
            card.CardDraw(dealerHand, 5, trumpCard);
            card.OpenCard(5, dealerHand);

            card.CardDraw(playerHand, 5, trumpCard);
            card.OpenCard(5, playerHand);






        }
    }
}