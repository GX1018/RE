using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_new
{
    public class CardSetting
    {
        List<int> trumpCard = new List<int>();

        List<int> dealerHandNumber = new List<int>();
        List<int> playerHandNumber = new List<int>();
        List<int> dealerHandPattern = new List<int>();
        List<int> playerHandPattern = new List<int>();

        List<int> dealerHand = new List<int>();
        List<int> playerHand = new List<int>();

        int cardNumber;
        int cardPattern;




        public void MakeCardSet(List<int>listName)
        {
            for (int index = 0; index < 52; index++)
            {
                listName.Add(index + 1);
            }
        }

        //섞는 함수
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

        public void PrintCardSet(List<int> listName)
        {
            foreach (int card in listName)
            {
                Console.WriteLine(card);
            }
        }

        
        public void SettingCard()
        {
            //MakeCardSet();
            //Suffle(300);
        }


        //트럼프카드에서 5장을 빼서 나눠준다
        public void CardDraw(List<int>listName, int number, List<int> listName1)
        {
            for (int index = 0; index < number; index++)
            {
                listName.Add(listName1[0]);
                listName1.RemoveAt(0);
            }

            //체크용
            //foreach(int card in dealerHand)
            //{
            //    Console.WriteLine("{0} 확인용", card);
            //}

            //foreach (int card1 in trumpCard)
            //{
            //    Console.WriteLine("{0}카드덱 남은카드{1}", card1,trumpCard.Count);
            //}
            //체크용
        }

        //뽑은 카드를 오픈
        public void OpenCard(List<int>listName, int index)
        {
            cardNumber = (int)Math.Ceiling(listName[index]%13.1);
            cardPattern = (listName[index]-1)/13;
            string[] printPattern = { "♠", "♥", "♣", "◆" };

            switch (cardNumber)
            {
                case 1:
                    Console.WriteLine("{0}{1}", printPattern[cardPattern]," A");
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


        int Point = 10000;
        int betPoint;
        public void Betting()
        {
            bool bettingCheck = true;
            while (bettingCheck)
            {
                Console.WriteLine("베팅하실 포인트를 입력하세요");
                betPoint = int.Parse(Console.ReadLine());
                if (betPoint > Point || betPoint <= 0)
                {
                    Console.WriteLine("[System] 잘못 입력하셨습니다.\n다시 입력해주세요");
                }
                else
                {
                    bettingCheck= false;
                }
            }
        }

        public void PlayerChangeCard()
        {
            Console.WriteLine("바꾸고 싶은 카드의 개수를 입력하세요\n[최대 2장]");
            int changeCardCount=int.Parse(Console.ReadLine());
            if (changeCardCount == 0) { }
            else if (changeCardCount == 1) 
            {
                Console.WriteLine("바꾸려는 카드의 번호를 입력하세요");
                int changeCardNumber1 = int.Parse(Console.ReadLine());
                playerHand[changeCardNumber1] = trumpCard[0];
                trumpCard.RemoveAt(0);


            }
            else if (changeCardCount == 2) 
            {
                Console.WriteLine("[첫번째]바꾸려는 카드의 번호를 입력하세요\n[0~4]");
                int changeCardNumber1 = int.Parse(Console.ReadLine());
                Console.WriteLine("[두번째]바꾸려는 카드의 번호를 입력하세요[0~4]");
                int changeCardNumber2 = int.Parse(Console.ReadLine());
                playerHand[changeCardNumber1] = trumpCard[0];
                trumpCard.RemoveAt(0);
                playerHand[changeCardNumber2] = trumpCard[0];
                trumpCard.RemoveAt(0);
            }
        }


        //점수체크(//플러시 체크//페어가 있을때 -> 원페어 2페어 트리플 포카드// 페어가 없을때 ->스트레이트 체크)
        
        

        public void HandSeparateList(List<int> listName, List<int> listName1, List<int> listName2)
        {
            for(int index=0; index< listName.Count; index++)
            {
                listName1.Add((int)Math.Ceiling(listName[index] % 13.1));

                listName2.Add((listName[index] - 1) / 13);
                //플러시 체크용 listName2.Add(0);

            }
        }



        //포카드 7 풀하우스 6  플러시 5 스트레이트 4 트리플 3 투페어 2 원카드 1

        int dealerScore=0;
        int playerScore=0;
        public void ScoreCheck(List<int> listName, List<int> listName1, List<int> listName2, int whoseScore)
        {

            //스코어 체크를 위한 배열 생성
            List<int> scoreCheckList= new List<int>();
            
            HandSeparateList(listName, listName1, listName2);
            List<int> pattern = new List<int>();
            for(int index=0; index<4; index++)
            {
                pattern.Add(index);
            }

            for (int index = 1; index < 14; index++)
            {
                int cnt = 0;

                for (int index_ = 0; index_ < listName1.Count; index_++)
                {
                    if (listName1[index_] == index)
                    {
                        cnt++;
                    }
                }
                scoreCheckList.Add(cnt);
            }
            //스코어 체크를 위한 배열 생성



            //플러시 체크

            for (int index = 0; index < pattern.Count; index++)
            {
                int count = listName2.Where(x => x.Equals(pattern[index])).Count();

                //Console.WriteLine("Element {0} occurs {1} times", pattern[index], count);

                if (count >= 5)
                {
                    whoseScore += 5;
                    Console.WriteLine("플러시");
                }
            }

            for (int index = 0; index < 13; index++)
            {
                if (scoreCheckList.IndexOf(4) == 1)
                {
                    Console.WriteLine("포카드");
                    whoseScore += 7;
                }
                else if (scoreCheckList.IndexOf(3) == 1 && scoreCheckList.IndexOf(2) == 1)
                {
                    Console.WriteLine("풀하우스");
                    whoseScore += 6;
                }
                else if (scoreCheckList.IndexOf(3) == 1 && scoreCheckList.IndexOf(2) == 0)
                {
                    Console.WriteLine("트리플");
                    whoseScore += 3;
                }

                else if (scoreCheckList[index] == 2)
                {
                    whoseScore += 1;
                }
                else { /*do nothing*/ }
            }
            if(whoseScore == 1)
            {
                Console.WriteLine("원페어");
            }
            else if (whoseScore == 2)
            {
                Console.WriteLine("투페어");
            }
            else if (whoseScore == 0)
            {
                Console.WriteLine("노페어");
            }
            else {/*do nothing*/}
        }

        public void DealerScoreCheck()
        {
            Console.WriteLine();

            //스코어 체크를 위한 배열 생성
            List<int> scoreCheckList = new List<int>();

            HandSeparateList(dealerHand, dealerHandNumber, dealerHandPattern);
            List<int> pattern = new List<int>();
            for (int index = 0; index < 4; index++)
            {
                pattern.Add(index);
            }

            for (int index = 1; index < 14; index++)
            {
                int cnt = 0;

                for (int index_ = 0; index_ < dealerHandNumber.Count; index_++)
                {
                    if (dealerHandNumber[index_] == index)
                    {
                        cnt++;
                    }
                }
                scoreCheckList.Add(cnt);
            }
            //스코어 체크를 위한 배열 생성



            //플러시 체크

            for (int index = 0; index < pattern.Count; index++)
            {
                int count = dealerHandPattern.Where(x => x.Equals(pattern[index])).Count();

                //Console.WriteLine("Element {0} occurs {1} times", pattern[index], count);

                if (count >= 5)
                {
                    dealerScore += 5;
                    Console.WriteLine("플러시");
                }
            }

            for (int index = 0; index < 13; index++)
            {
                if (scoreCheckList.IndexOf(4) == 1)
                {
                    Console.WriteLine("포카드");
                    dealerScore += 7;
                }
                else if (scoreCheckList.IndexOf(3) == 1 && scoreCheckList.IndexOf(2) == 1)
                {
                    Console.WriteLine("풀하우스");
                    dealerScore += 6;
                }
                else if (scoreCheckList.IndexOf(3) == 1 && scoreCheckList.IndexOf(2) == 0)
                {
                    Console.WriteLine("트리플");
                    dealerScore += 3;
                }

                else if (scoreCheckList[index] == 2)
                {
                    dealerScore += 1;
                }
                else { /*do nothing*/ }
            }
            if (dealerScore == 1)
            {
                Console.WriteLine("원페어");
            }
            else if (dealerScore == 2)
            {
                Console.WriteLine("투페어");
            }
            else if (dealerScore == 0)
            {
                Console.WriteLine("노페어");
            }
            else {/*do nothing*/}
        }


        public void PlayerScoreCheck()
        {
            Console.WriteLine();

            //스코어 체크를 위한 배열 생성
            List<int> scoreCheckList = new List<int>();

            HandSeparateList(playerHand, playerHandNumber, playerHandPattern);
            List<int> pattern = new List<int>();
            for (int index = 0; index < 4; index++)
            {
                pattern.Add(index);
            }

            for (int index = 1; index < 14; index++)
            {
                int cnt = 0;

                for (int index_ = 0; index_ < playerHandNumber.Count; index_++)
                {
                    if (playerHandNumber[index_] == index)
                    {
                        cnt++;
                    }
                }
                scoreCheckList.Add(cnt);
            }
            //스코어 체크를 위한 배열 생성



            //플러시 체크

            for (int index = 0; index < pattern.Count; index++)
            {
                int count = playerHandPattern.Where(x => x.Equals(pattern[index])).Count();

                //Console.WriteLine("Element {0} occurs {1} times", pattern[index], count);

                if (count >= 5)
                {
                    playerScore += 5;
                    Console.WriteLine("플러시");
                }
            }

            for (int index = 0; index < 13; index++)
            {
                if (scoreCheckList.IndexOf(4) == 1)
                {
                    Console.WriteLine("포카드");
                    playerScore += 7;
                }
                else if (scoreCheckList.IndexOf(3) == 1 && scoreCheckList.IndexOf(2) == 1)
                {
                    Console.WriteLine("풀하우스");
                    playerScore += 6;
                }
                else if (scoreCheckList.IndexOf(3) == 1 && scoreCheckList.IndexOf(2) == 0)
                {
                    Console.WriteLine("트리플");
                    playerScore += 3;
                }

                else if (scoreCheckList[index] == 2)
                {
                    playerScore += 1;
                }
                else { /*do nothing*/ }
            }
            if (playerScore == 1)
            {
                Console.WriteLine("원페어");
            }
            else if (playerScore == 2)
            {
                Console.WriteLine("투페어");
            }
            else if (playerScore == 0)
            {
                Console.WriteLine("노페어");
            }
            else {/*do nothing*/}
        }
        //임시 테스트




        public void WinnerCheck()//미작동
        {

            if (dealerScore > playerScore)
            {
                Console.WriteLine("PLAYER DEFEAT");
                Point -= betPoint;
            }
            else if(dealerScore < playerScore) 
            {
                Console.WriteLine("PLAYER WIN");
                Point += betPoint;
            }
            else
            {
                Console.WriteLine("DRAW");
            }
        }


        //=============================================================================================\\
        //=============================================================================================\\
        //=============================================================================================\\




        public void GameStart()
        {
            SettingCard();
            //CardDraw(dealerHand,5);
            //CardDraw(playerHand,5);

            Console.WriteLine("딜러 카드");
            OpenCard(5, dealerHand);

            Console.WriteLine();
            Console.WriteLine("플레이어 카드");
            OpenCard(5, playerHand);


            Console.WriteLine();
            Betting();


            Console.WriteLine();
            Console.WriteLine("딜러 카드");
            //CardDraw(dealerHand,2);
            OpenCard(7,dealerHand);
            DealerScoreCheck();
            //ScoreCheck(dealerHand, dealerHandNumber, dealerHandPattern, dealerScore);


            Console.WriteLine();
            Console.WriteLine("플레이어 페이즈");
            PlayerChangeCard();
            Console.WriteLine();
            OpenCard(5, playerHand);
            PlayerScoreCheck();
            //ScoreCheck(playerHand, playerHandNumber, playerHandPattern, playerScore);



            WinnerCheck();

        }

    }
}
