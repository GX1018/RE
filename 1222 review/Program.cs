using System.Reflection.Metadata;

namespace _1222_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 사용하여 국어 점수의 총점과평균 구하기
            //학생 3명의 점수를 저장하는 배열 선언해서 각 학생별로 점수를 할당하고(범위는 1~100점)
            //모든 점수의 총점과 평균을 구해서 출력하는 프로그램
            Console.WriteLine("==============");
            Console.WriteLine("연습==========");

            int testScore = 0;
            int[] scoreList;
            scoreList= new int[3];
            int sumOfScore = 0;
            
            for (int studentNumber = 0; studentNumber <= 2; studentNumber++)
            {
                Console.WriteLine("시험 점수를 입력하세요");
                string check = Console.ReadLine();
                bool checkToTestScore = int.TryParse(check, out testScore);
                //Console.WriteLine("{0}", checkToTestScore);
                if (checkToTestScore&&testScore>0&&testScore<=100)
                {
                    scoreList[studentNumber] = testScore;
                    sumOfScore += testScore;

                }
                else
                {
                    Console.WriteLine("잘못입력했습니다. 다시 입력하세요");
                    break;
                }
            }
            Console.WriteLine("{0},{1},{2}", scoreList[0], scoreList[1], scoreList[2]);
            Console.WriteLine("총점은 : {0}점\n평균은 : {1}점", sumOfScore, sumOfScore/3 );
            Console.WriteLine("==============");
            Console.WriteLine("==============\n");


            //예제 #1 - 구구단 출력하는 프로그램 작성. User input 받아서 해당 단을 출력
            Console.WriteLine("예제1=========");

            int inputNumber = 0;
            Console.WriteLine("숫자를 입력하세요");
            int.TryParse(Console.ReadLine(), out inputNumber);
            Console.WriteLine("{0}단\n==============",inputNumber);
            for (int gugu=1; gugu<=9; gugu++)
            {
                Console.WriteLine("{0} x {1} = {2}",inputNumber, gugu, inputNumber * gugu);
            }
            Console.WriteLine("==============");
            Console.WriteLine("==============\n");



            // * 문제 1
            // * 프로그램 사용자로부터 양의 정수를 하나 입력받아서 그 수만큼 "Hello. world!"를 출력하는 프로그램(양의 정수 -> 예외처리 까지)

            Console.WriteLine("문제1=========");

            int numberOfQuestion1 = 0;

            Console.WriteLine("양의 정수를 입력하세요");
            string inputCheck = Console.ReadLine();
            bool checkQ1 = int.TryParse(inputCheck, out numberOfQuestion1);
            if(checkQ1 && numberOfQuestion1>0)
            {
                for (int index = 1; index <= numberOfQuestion1; index++)
                {
                    Console.WriteLine("Hello. World!");
                }
            }
            else
            {
                Console.WriteLine("잘못된 값입니다.\n양의 정수를 다시 입력하세요");
            }
            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            // * 문제 2
            // * 프로그램 사용자로부터 양의 정수를 하나 입력받은 다음 그 수만큼 3의 배수를 출력하는 프로그램
            Console.WriteLine("문제2=========");

            int inputNumberQ2 = 0;
            Console.WriteLine("양의 정수를 입력하세요");
            string inputCheckQ2 = Console.ReadLine();
            bool CheckForQ2 = int.TryParse(inputCheckQ2, out inputNumberQ2);
            if(CheckForQ2&& inputNumberQ2>0)
            {
                for(int index=1; index <= inputNumberQ2; index++) 
                {
                    Console.Write("{1}) {0}\n", index * 3, index);
                }
            }
            else
            {
                Console.WriteLine("다시 입력하세요");
            }
            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            // * 문제 3
            // * 프로그램 사용자로부터 계속해서 정수를 입력받는다. 그리고 그 값을 계속해서 더해 나간다. 
            // * 이러한 작업은 프로그램 사용자가 0을 입력할때까지 계속되어야 하며 0이 입력되면 모든 정수의 합을 출력하고 프로그램 종료
            Console.WriteLine("문제3=========");

            int inputNumberQ3 = 0;
            int sumOfINputNumberQ3 = 0;
            int countQ3 = 1;
            Console.WriteLine("입력한 정수의 총 합 구하기");
            while (true) 
            {
                Console.WriteLine("{0}) 정수를 입력하세요\n[.]을 누르면 중단합니다.", countQ3);
                string inputCheckQ3 = Console.ReadLine();
                bool CheckForQ3 = int.TryParse(inputCheckQ3, out inputNumberQ3);
                if (CheckForQ3)
                {
                    sumOfINputNumberQ3 += inputNumberQ3;
                    countQ3++;
                }
                else if (inputCheckQ3 == ".")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력하였습니다.\n정수를 입력하세요");
                }
                
            }
            Console.WriteLine("입력한 정수의 총 합은 {0}입니다", sumOfINputNumberQ3);

            Console.WriteLine("==============");
            Console.WriteLine("==============\n");


            // * 문제 4
            // * 입력받은 숫자에 해당하는 구구단을 출력하되 역순으로 출력하는 프로그램 작성
            Console.WriteLine("문제4=========");


            int inputNumberQ4= 0;
            Console.WriteLine("알고 싶은 구구단의 [단 수]를 입력하세요\n(역순으로 출력됩니다.)");
            int.TryParse(Console.ReadLine(), out inputNumberQ4);
            Console.WriteLine("[{0}단]", inputNumberQ4);
            for (int index = 9; index>=1; index-- )
            {
                Console.WriteLine("{0} x {1} = {2}", inputNumberQ4, index, inputNumberQ4 * index);
            }

            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            // * 문제 5
            // * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되 두가지의 조건을 만족할 것
            // * - 먼저 몇개의 정수를 입력할 것인지 사용자에게 묻는다. 그리고 그 수만큼 정수를 입력 받는다.
            // * - 평균 값은 소수점 이하까지 계산해서 출력한다. float
            // * ex) user input(Loop count) ->3
            // *     user input -> 10
            // *     user input -> 10 
            // *     user input -> 10 
            // *     "평균 값:10.0"
            // */

            Console.WriteLine("문제5=========");

            int inputNumberQ5ForCount = 0;
            float inputNumberQ5ForValue = 0.00f;

            float sumOfNumberQ5 = 0.00f;

            Console.WriteLine("평균을 구하고자 하는 값의 개수를 입력해주세요");
            int.TryParse(Console.ReadLine(), out inputNumberQ5ForCount);
            for(int inputNumberQ5_1=1; inputNumberQ5_1<=inputNumberQ5ForCount; inputNumberQ5_1++)
            {
                Console.WriteLine("{0}번째) 수를 입력 하세요 ",inputNumberQ5_1);
                float.TryParse(Console.ReadLine(),out inputNumberQ5ForValue);
                sumOfNumberQ5 += inputNumberQ5ForValue;
            }

            Console.WriteLine("입력한 값의 총 합은 : {0}입니다.", sumOfNumberQ5);
            Console.WriteLine("입력한 값의 평균은 : {0}입니다.", sumOfNumberQ5/inputNumberQ5ForCount); //실수값 소수점 n자리까지 출력하는 방법**** 다시 체크

            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            // * 문제 6
            // * 두 실수를 입력받아서 값이 같은지 다른지 출력하는 프로그램 작성(Equals 등 메서드 사용x)
            // *
            Console.WriteLine("문제6=========");

            float inputNumberQ6 = 0.0f;
            float[] q6Array= new float[2];
            for(int index = 0; index<=1; index++ ) 
            {
                Console.WriteLine("비교하고 싶은 수를 입력하세요");
                float.TryParse(Console.ReadLine(), out inputNumberQ6);
                q6Array[index] = inputNumberQ6;
            }
            if (q6Array[0] == q6Array[1]) 
            {
                Console.WriteLine("입력한 두 수의 값이 같습니다.");
            }
            else
            {
                Console.WriteLine("입력한 두 수의 값이 다릅니다.");
            }


            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            // * 문제 7
            // * 1~100까지의 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            // * 
            Console.WriteLine("문제6=========");
            Console.WriteLine("1~100까지의 수 중 3의 배수를 제외한 수들의 합은 구하기.");
            Console.ReadKey();

            int sumOfNumberQ7 = 0;

            for(int index = 1; index<=100; index++)
            {
                if(index%3 ==0) {/*do nothing*/}
                else
                {
                    sumOfNumberQ7 += index;
                }
            }
            Console.WriteLine("1~100까지의 수 중 3의 배수를 제외한 수들의 합은 {0}입니다.", sumOfNumberQ7);

            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            // LAB문제1
            // 자음과 모음 개수 세기
            // 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
            // -대 소문자 모두 카운트
            //      ex) a
            //          b
            //          c
            //          d
            //          Z
            //          모음 :1
            //          자음 :4
            // 

            Console.WriteLine("Lab 1=========");

            Console.WriteLine("입력한 자음과 모음의 수를 표시합니다.");

            char inputCharLab1;
            int vowelCount = 0;
            int consonantCount = 0;
            while (true)
            {
                Console.WriteLine("알파벳 중 한 글자를 입력하세요.");
                char.TryParse(Console.ReadLine(), out inputCharLab1);
                Console.WriteLine("{0}", inputCharLab1);
                if (inputCharLab1 >= 'a' && inputCharLab1 <= 'z' || inputCharLab1 >= 'A' && inputCharLab1 <= 'Z')
                {
                    switch (inputCharLab1)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            vowelCount++;
                            break;
                        default:
                            consonantCount++;
                            break;
                    }
                }
                else if (inputCharLab1 == '.')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력했습니다.\n다시 입력해주세요");
                }

            }
            Console.WriteLine("자음 개수: {0}", consonantCount);
            Console.WriteLine("모음 개수: {0}", vowelCount);

            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

            //LAB2. 사과를 제일 좋아하는 사람 찾기

            /**
             * 사람들 5명(사람1, 사람2....)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
             * 데이터 입력이 마무리 되면 누가 가장 많은 사과를 아침으로 먹었는지 출력한다.
             * 
             * 이상한 입력 예외처리
             * 제일 적게 먹은 사람도 찾도록 수정해보기(변형1)
             * 
             * 
             * 먹은 사과의 개수 순으로 정렬.
             * 알고리즘을 잘 모르겠다면 버블 정렬을 도전(변형2)
             * 
             * 알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것.(Hard)
             *      -유저 입력 없애고 난수로 100~1000개 정도의 값
             *      -중복 제거
             *      시간초는 전혀 상관 없음
             */

            Console.WriteLine("Lab 2=========");


            Console.WriteLine("==============");
            Console.WriteLine("==============\n");

        }
    }
}