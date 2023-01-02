using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0102
{
    internal class Poker
    {
        public int point = 10000;
        public int betPoint = 0;

        public int[] cardArray = new int[52];

        public int[] scoreCheckArray = new int[13];

        public string[] cardPattern = { "♠", "◆", "♥", "♣" };
        int temp;
        List<int> comList = new List<int>();
        List<int> comList_ = new List<int>();

        List<string> comListPattern = new List<string>();
        List<string> comListPattern_ = new List<string>();

        List<int> playerList = new List<int>();
        List<string> playerListPattern = new List<string>();



        public void Cardset()
        {
            for (int index = 0; index < cardArray.Length; index++)
            {
                cardArray[index] = index+1;
            }
        }

        public int[] Suffle(int[] cardArray)
        {
            Random random = new Random();
            int firstSuffle = random.Next(0,cardArray.Length);
            int secondSuffle = random.Next(0,cardArray.Length);
            temp= cardArray[firstSuffle];
            cardArray[firstSuffle] = cardArray[secondSuffle];
            cardArray[secondSuffle] = temp;
            return cardArray;
        }

        public void Suffle(int number)
        {
            for(int index = 0; index <= number; index++)
            {
                cardArray = Suffle(cardArray);
            }
        }

        public void SufflingCard()
        {
            Suffle(200);
        }

        //public void OpenCard(int index)
        //{
        //    int openCard = cardArray[index];
        //    int openCardNumber = (int)Math.Ceiling(openCard % 13.1);
        //    string openCardPattern = cardPattern[openCard%13];
        //}

        public void GameSetting()
        {
            Cardset();
            SufflingCard();
        }

        public void ComputerCardDraw()
        {
            //드로우 카드 넘버
            for (int index = 0; index < 5; index++)
            {
                comList.Add((int)Math.Ceiling(cardArray[index] % 13.1));
            }
            //드로우 카드 문양
            for (int index = 0; index < 5; index++)
            {
                comListPattern.Add(cardPattern[(cardArray[index] - 1) / 13]);
            }
            //
            //스트레이트체크용
            //comList.Add(1);
            //comList.Add(2);
            //comList.Add(3);
            //comList.Add(4);
            //comList.Add(5);
            //스트레이트 체크용

            //플러시 체크용
            //comListPattern.Add(cardPattern[0]);
            //comListPattern.Add(cardPattern[0]);
            //comListPattern.Add(cardPattern[0]);
            //comListPattern.Add(cardPattern[0]);
            //comListPattern.Add(cardPattern[0]);



            //foreach (int index in comList)
            //{
            //    Console.Write("{0} ", index);

            //}
            //Console.WriteLine();

            //foreach (string index in comListPattern)
            //{
            //    Console.Write("{0} ", index);

            //}
            //Console.WriteLine();

            for(int index_1 = 0; index_1<5; index_1++)
            {
                CardOpen(index_1);
            }

            //출력확인용
            //ComScoreCheck();

            Console.WriteLine();

        }

        public void PlayerCardDraw()
        {
            
            //드로우 카드 넘버
            for (int index = 5; index < 10; index++)
            {
                playerList.Add((int)Math.Ceiling(cardArray[index] % 13.1));
            }
                        
            //드로우 카드 문양
            for (int index = 5; index < 10; index++)
            {
                playerListPattern.Add(cardPattern[(cardArray[index] - 1) / 13]);
            }

            //출력확인용
            foreach (int index in playerList)
            {
                Console.Write("{0} ", index);
            }
            Console.WriteLine();

            foreach (string index in playerListPattern)
            {
                Console.Write("{0} ", index);
            }


            Console.WriteLine();
            //PlayerScoreCheck();
            Console.WriteLine();

        }

        public void PointBetting()
        {
            bool bettingCheck = true;
            while (bettingCheck)
            {

                Console.WriteLine("베팅하실 포인트를 입력하세요");
                betPoint = int.Parse(Console.ReadLine());
                if(betPoint > point || betPoint<=0)
                {
                    Console.WriteLine("잘못 입력하셨습니다. 다시 입력하세요");
                }
                else
                {
                    bettingCheck= false;
                }
            }
        }



        public void ComScoreCheck()
        {

            for (int index=1; index<14; index++)                    
            {
                int cnt=0;

                for (int index_=0; index_<7; index_++)
                {
                    if(comList[index_] == index)
                    {
                        cnt++;
                    }
                    scoreCheckArray[index-1] = cnt;
                }
            }

            Console.WriteLine("스코어 체크용");
            foreach(int scroeCheck in scoreCheckArray)
            {
                Console.Write("{0} ", scroeCheck);
            }

            int pairCheck = 0;
            int tripleCheck = 0;
            int fourCardCheck = 0;
            int straightCheck= 0;
            int flush = 0;
            //
            //

            //
            Console.WriteLine();
            for(int target = 0; target<4; target++)
            {
                int count = comListPattern.Where(x => x.Equals(cardPattern[target])).Count();

                Console.WriteLine("Element {0} occurs {1} times", cardPattern[target], count);

                if (count == 5)
                {
                    flush++;
                }
            }

            //

            for (int indexStraight = 0; indexStraight<9; indexStraight++)
            {
                if(scoreCheckArray[indexStraight] == 1 &&
                    scoreCheckArray[indexStraight] == scoreCheckArray[indexStraight + 1] && scoreCheckArray[indexStraight + 1] == scoreCheckArray[indexStraight + 2] &&
                    scoreCheckArray[indexStraight + 2] == scoreCheckArray[indexStraight + 3] && scoreCheckArray[indexStraight + 3] == scoreCheckArray[indexStraight + 4])
                {
                    straightCheck++;
                }
            }
            
            for (int index=0; index<13; index++)
            {
                if(scoreCheckArray[index] == 2)
                {
                    pairCheck++;
                }
                else if(scoreCheckArray[index] == 3)
                {
                    tripleCheck++;
                }
                else if (scoreCheckArray[index] == 4)
                {
                    fourCardCheck++;
                }

            }
            if (tripleCheck==1)
            {
                Console.WriteLine("트리플");
            }
            else if(flush == 1)
            {
                Console.WriteLine("플러시");
            }
            else if (straightCheck == 1)
            {
                Console.WriteLine("스트레이트");
            }
            else if (fourCardCheck == 1)
            {
                Console.WriteLine("포카드");
            }
            else if(pairCheck == 1)
            {
                Console.WriteLine("원페어");
            }
            else if (pairCheck == 2)
            {
                Console.WriteLine("투페어");
            }
            else
            {
                Console.WriteLine("노페어");
            }

        }


        public void PlayerScoreCheck()
        {

            for (int index = 1; index < 14; index++)
            {
                int cnt = 0;

                for (int index_ = 0; index_ < 5; index_++)
                {
                    if (playerList[index_] == index)
                    {
                        cnt++;
                    }
                    scoreCheckArray[index - 1] = cnt;
                }
            }

            Console.WriteLine("스코어 체크용");
            foreach (int scroeCheck in scoreCheckArray)
            {
                Console.Write("{0} ", scroeCheck);
            }

            int pairCheck = 0;
            int tripleCheck = 0;
            int fourCardCheck = 0;
            int straightCheck = 0;
            int flush = 0;


            Console.WriteLine();
            for (int target = 0; target < 4; target++)
            {
                int count = playerListPattern.Where(x => x.Equals(cardPattern[target])).Count();

                Console.WriteLine("Element {0} occurs {1} times", cardPattern[target], count);

                if (count == 5)
                {
                    flush++;
                }
            }

            for (int indexStraight = 0; indexStraight < 9; indexStraight++)
            {
                if (scoreCheckArray[indexStraight] == 1 &&
                    scoreCheckArray[indexStraight] == scoreCheckArray[indexStraight + 1] && scoreCheckArray[indexStraight + 1] == scoreCheckArray[indexStraight + 2] &&
                    scoreCheckArray[indexStraight + 2] == scoreCheckArray[indexStraight + 3] && scoreCheckArray[indexStraight + 3] == scoreCheckArray[indexStraight + 4])
                {
                    straightCheck++;
                }
            }

            for (int index = 0; index < 13; index++)
            {
                if (scoreCheckArray[index] == 2)
                {
                    pairCheck++;
                }
                else if (scoreCheckArray[index] == 3)
                {
                    tripleCheck++;
                }
                else if (scoreCheckArray[index] == 4)
                {
                    fourCardCheck++;
                }

            }
            if (tripleCheck == 1)
            {
                Console.WriteLine("트리플");
            }
            else if (flush == 1)
            {
                Console.WriteLine("플러시");
            }
            else if (straightCheck == 1)
            {
                Console.WriteLine("스트레이트");
            }
            else if (fourCardCheck == 1)
            {
                Console.WriteLine("포카드");
            }
            else if (pairCheck == 1)
            {
                Console.WriteLine("원페어");
            }
            else if (pairCheck == 2)
            {
                Console.WriteLine("투페어");
            }
            else
            {
                Console.WriteLine("노페어");
            }

        }

        public void ComDrawCard2()
        {
            comList.Add((int)Math.Ceiling(cardArray[10] % 13.1));
            comList.Add((int)Math.Ceiling(cardArray[11] % 13.1));

            comListPattern.Add(cardPattern[(cardArray[10] - 1) / 13]);
            comListPattern.Add(cardPattern[(cardArray[11] - 1) / 13]);


            foreach (int index in comList)
            {
                Console.Write("{0} ", index);

            }
            Console.WriteLine();

            foreach (string index in comListPattern)
            {
                Console.Write("{0} ", index);

            }
            ComScoreCheck();
        }

        public void PlayerChangeCard()
        {

            foreach (int index_ in playerList)
            {
                Console.Write("{0} ", index_);

            }
            Console.WriteLine();

            foreach (string index_ in playerListPattern)
            {
                Console.Write("{0} ", index_);

            }
            int inputKey = 0;
            int changeCardIndex = 12;

            for (int index = 0; index<2; index++)
            {
                Console.WriteLine("바꾸실 카드의 번호를 입력하세요 [1~5//바꾸지 않으시려면 9]");
                inputKey = int.Parse(Console.ReadLine());
                switch (inputKey-1)
                {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    playerList[inputKey-1] = (int)Math.Ceiling(cardArray[changeCardIndex] %13.1);
                    playerListPattern[inputKey-1] = cardPattern[(cardArray[changeCardIndex] - 1) / 13];
                    changeCardIndex++;
                    break;
                case 8:
                    break;
                default:
                    break;
                }

                foreach (int index_ in playerList)
                {
                    Console.Write("{0} ", index_);

                }
                Console.WriteLine();

                foreach (string index_ in playerListPattern)
                {
                    Console.Write("{0} ", index_);

                }
                PlayerScoreCheck();

            }
        }


        public void GameStart()
        {
            GameSetting();
            ComputerCardDraw();
            PlayerCardDraw();
            PointBetting();
            ComDrawCard2();
            PlayerChangeCard();
        }






        //public void SuffleCheck()
        //{
        //    Cardset();
        //    SufflingCard();

        //    foreach (int card in cardArray)
        //    {
        //        Console.Write("{0} ",card);
        //    }
        //}


        public void CardOpen(int index)
        {
            Console.WriteLine();
            int openCard = comList[index];
            string openCardMark = comListPattern[index];
            char jqk = 'a';
            if (openCard > 10)
            {
                switch (openCard)
                {
                    case 11:
                        jqk = 'J';
                        break;
                    case 12:
                        jqk = 'Q';
                        break;
                    case 13:
                        jqk = 'K';
                        break;
                    default:
                        break;
                }
                Console.WriteLine(@"┌───────────────────┐
│                   │
│  {0} {1}             │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
└───────────────────┘", openCardMark, jqk);
            }
            else
            {
                Console.WriteLine(@"┌───────────────────┐
│                   │
│  {0}{1:00}             │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
│                   │
└───────────────────┘", openCardMark, openCard);

            }
        }


    }
}
