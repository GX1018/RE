using System.Diagnostics;

namespace MINDMAPTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {

        // 레퍼런스 게임 직접 해보면서 배운것들로 무엇을 어디까지 구현할 수 있을지
        // 마인드 맵으로 그려보기
        
        //   -타이틀 씬
        //   - 선택지를 포함한 이벤트 =>유저가 뭔가 선택 가능
        
        //   -보상 OR 패널티를 얻을 수 있는 이벤트(골드획득/ 감소 / 아이템 획득 / 스텟증가 / 하락)
        //   -전투씬 =>오크가 등장하거나 늑대가 등장하거나해서 싸워서 결과를 내는 형태

            Console.WriteLine("모험가 이야기\nLife In Adventure");
            Console.WriteLine("\n\n\n");

                        string pressAnykey = string.Empty;
            Console.WriteLine("TAP TO START");
            Console.ReadKey();
            Console.WriteLine("\n\n\n");


            Console.WriteLine("이벤트 설명문입니다");
            Console.ReadKey();


            int playerHp = 100;

            //보상을 위한 스테이터스 설정
            int str = 10;
            int intel = 10;

            int gold = 100;

            string option1 = "가까이간다.";
            string option2 = "도망친다.";
            Console.WriteLine("선택지를 고르시오.\n1.{0}\n2.{1}",option1,option2);
            int choice = 0;
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1)
            {
                Console.WriteLine("1번 선택지 결과 진행");
                //전투로 진입
                int enermyHp = 100;
                int battleDice = 0;
                Random random = new Random();
                while (!(playerHp <= 0 || enermyHp <= 0))
                {
                    battleDice = random.Next(1, 29);
                    if (battleDice <= 21)
                    {
                        enermyHp -= 21;
                        Console.WriteLine("{0}",battleDice);
                        Console.WriteLine("Player HP:{0}\nEnermyHP:{1}", playerHp, enermyHp);
                    }
                    else
                    {
                        playerHp -= 8;
                    }
                }
                if (playerHp < 0)
                {
                    Console.WriteLine("패배");
                    gold -= 30;
                    Console.WriteLine("30Gold를 잃었습니다.");
                    Console.WriteLine("보유 골드:{0}", gold);
                }
                else 
                {
                    Console.WriteLine("승리");

                    str ++;
                    gold += 50;
                    Console.WriteLine("힘이 1증가했습니다\n50Gold를 획득했습니다.");
                    Console.WriteLine("힘:{0}\n골드:{1}",str,gold);

                }
            





            }
            else
            {
                //도망 확률 설정
                Console.WriteLine("2번 선택지 결과 진행");
                //확률 계산을 위한 난수 설정
                int option2Dice;
                Random random = new Random();
                option2Dice = random.Next(1, 1000);
                Console.ReadKey();
                if (option2Dice <= 286)
                {
                    Console.WriteLine("성공했습니다.");
                    Console.ReadKey();
                    Console.WriteLine("성공했을때의 결과 출력");

                }
                else
                {
                    Console.WriteLine("실패했습니다.");
                    Console.ReadKey();
                    //패널티 지급 작업 진행
                    Console.WriteLine("도망치지 못했습니다.");
                    gold -= 30;
                    playerHp -= 20;
                    Console.WriteLine("Hp가 20 감소했습니다.\n30Gold를 잃었습니다.");
                    Console.WriteLine("현재 HP:{1}\n보유 골드:{0}", gold, playerHp);

                }
            }

            

            



        }
    }
}