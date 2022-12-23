using System;

namespace exercise1223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /**
             * Q1
             * 사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램 작성
             * ex)
             * 첫번째 문자열 : Hello
             * 두번째 문자열 : Woeld
             * 2개의문자열은 다릅니다.
             * Equals 메서드 사용하지말것
             */

            Console.WriteLine("Q1====================\n");

            Console.WriteLine("비교하고 싶은 두 개의 문자열을 입력하세요");
            string inputQ1_1 = Console.ReadLine();
            Console.WriteLine("비교하고 싶은 두 개의 문자열을 입력하세요");
            string inputQ1_2 = Console.ReadLine();

            bool checkQ1 = inputQ1_1 == inputQ1_2;
            if(checkQ1) 
            {
                Console.WriteLine("{0}={1}", inputQ1_1, inputQ1_2);
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("{0}=/={1}", inputQ1_1, inputQ1_2);
                Console.WriteLine("다르다");
            }

            Console.WriteLine("======================\n");
            Console.WriteLine("======================\n");
            Console.ReadKey();

            Console.WriteLine("======================\n");
            Console.WriteLine("Q1-version2====================\n");

            string[] arrayQ1 = new string[2];
            for (int index = 0; index <= 1; index++)
            {
                Console.WriteLine("비교하고 싶은 두 개의 문자열을 입력하세요");
                arrayQ1[index] = Console.ReadLine();
            }
            if (arrayQ1[0] == arrayQ1[1])
            {
                Console.WriteLine("같다");
            }
            else 
            {
                Console.WriteLine("다르다");
            }
            Console.ReadKey();

            /**
             * Q2
             * 5개의 음료(콜라, 물, 스프라이트, 주스, 커피)를 판매하는 자판기 머신을 구현해보기
             * 사용자가 1부터 5까지의 숫자를 입력합
             * 선택한 음료를 출력함
             * 1~5이외의 숫자를 선택하면 오류 메시지 출력
             * ex)
             * 콜라 물 스프라이트 주스 커피(1~5)중에서 하나를 선택하세요
             * 1.
             * 콜라를 선택하였습니다.
             * 프로그램 종료
             * 
             */

            Console.WriteLine("Q2====================\n");

            
            int inputNumberQ2 = 0;
            Console.WriteLine("원하는 음료의 번호를 입력하세요\n1 콜라\n2 물\n3 스프라이트\n4 주스\n5 커피");
            int.TryParse(Console.ReadLine(), out inputNumberQ2);
            if (inputNumberQ2 >= 1 && inputNumberQ2 <= 5)
            {
                switch (inputNumberQ2)
                {
                    case 1:
                        Console.WriteLine("1. 콜라");
                        break;
                    case 2:
                        Console.WriteLine("2. 물");
                        break;
                    case 3:
                        Console.WriteLine("3. 스프라이트");
                        break;
                    case 4:
                        Console.WriteLine("4. 주스");
                        break;
                    case 5:
                        Console.WriteLine("5. 커피");
                        break;
                }
            }
            else
            {
                Console.WriteLine("잘못 입력했습니다.");
            }


            Console.WriteLine("======================\n");
            Console.WriteLine("======================\n");
            Console.ReadKey();



            Console.WriteLine("======================\n");
            Console.WriteLine("Q2-version2====================\n");
            string[] arrayQ2 = {"콜라","물","스프라이트","주스","커피" };
            int numberQ2_1 = 0;
            Console.WriteLine("원하는 음료의 번호를 입력하세요\n1 콜라\n2 물\n3 스프라이트\n4 주스\n5 커피");
            int.TryParse(Console.ReadLine() , out numberQ2_1);
            if(numberQ2_1>=1&& numberQ2_1 <= 5)
            {
                Console.WriteLine("{0}", arrayQ2[numberQ2_1-1]);
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다.");
            }

            Console.WriteLine("======================\n");
            Console.WriteLine("======================\n");
            Console.ReadKey();

            /**
             * Q3
             * 배열 days[]를 아래와 같이 초기화하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성
             * -배열 days[]는 ->31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30. 31
             * ex)
             * 1월은 31일까지 입니다.
             * 2월은 29일까지 입니다.
             * 
             */

            Console.WriteLine("Q3====================\n");

            int inputNumQ3 = 0;
            int[] arrayQ3= {31,29,31,30,31,30,31,31,30,31,30,31 };
            Console.WriteLine("입력한 달의 날짜수는?");
            int.TryParse(Console.ReadLine(),out inputNumQ3);
            
            if (inputNumQ3 > 0 && inputNumQ3 <= 12)
            {
                Console.WriteLine("{0}월은 {1}까지 입니다.", inputNumQ3, arrayQ3[inputNumQ3 - 1]);
            }
            else
            {
                Console.WriteLine("잘못 입력하였습니다.");
            }
            Console.WriteLine("======================\n");
            Console.WriteLine("======================\n");
           

        }
        // Q1-Hint) Length를 비교 한다던지
        // Q2-Hint)switch문이나 if-else문 사용
        // Q3-Hint)배열의 초기화는 중괄호를 사용한다.
    }
}
