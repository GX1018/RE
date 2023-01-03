using System;

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
            Dealer dealer= new Dealer();

            card.MakeCardSet(trumpCard);
            //card.Suffle(300, trumpCard);
            dealer.Suffle(300, trumpCard);

            Console.WriteLine("딜러 카드");
            dealer.CardDraw(dealerHand, 5, trumpCard);
            card.OpenCard(5, dealerHand);


            dealer.OpenCard(trumpCard, int index)


            Console.WriteLine("플레이어 카드");
            dealer.CardDraw(playerHand, 5, trumpCard);
            card.OpenCard(5, playerHand);



            






        }
    }
}