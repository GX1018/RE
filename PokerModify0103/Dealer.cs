using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_new
{
    internal class Dealer
    {
        public void Suffle(List<int> listName)
        {
            int temp;
            Random random = new Random();
            int firstIdx = random.Next(0, 52);
            int secondIdx = random.Next(0, 52);
            temp = listName[firstIdx];
            listName[firstIdx] = listName[secondIdx];
            listName[secondIdx] = temp;
        }
        //n번 섞는 함수
        public void Suffle(int number, List<int> listName)
        {
            for (int index = 0; index < number; index++)
            {
                Suffle(listName);
            }
        }

        public void CardDraw(List<int> listName, int number, List<int> listName1)
        {
            for (int index = 0; index < number; index++)
            {
                listName.Add(listName1[0]);
                listName1.RemoveAt(0);
            }
        }

        public void OpenCard(List<int> listName, int index)
        {
            cardNumber = (int)Math.Ceiling(listName[index] % 13.1);
            cardPattern = (listName[index] - 1) / 13;
            string[] printPattern = { "♠", "♥", "♣", "◆" };

            switch (cardNumber)
            {
                case 1:
                    Console.WriteLine("{0}{1}", printPattern[cardPattern], " A");
                    break;
                case 11:
                    Console.WriteLine("{0}{1}", printPattern[cardPattern], " J");
                    break;
                case 12:
                    Console.WriteLine("{0}{1}", printPattern[cardPattern], " Q");
                    break;
                case 13:
                    Console.WriteLine("{0}{1}", printPattern[cardPattern], " K");
                    break;
                default:
                    Console.WriteLine("{0}{1:00}", printPattern[cardPattern], cardNumber);
                    break;
            }
        }

        public void OpenCard(int cnt, List<int> listName)
        {
            for (int index = 0; index < cnt; index++)
            {
                OpenCard(listName, index);
            }
        }



    }
}
