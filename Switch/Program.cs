using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 선택문(switch와 case, default 키워드를 사용하여 다양한 조건 처리)인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 
             * 조건을 처리할 내용이 많은 경우 유용하다.
             */

            //Console.WriteLine("정수 1, 2, 3 중에 하나를 입력하시오 :");
            //int switchNumber = 0;
            //int.TryParse(Console.ReadLine(), out switchNumber);

            //switch(switchNumber)    //if - else 로 처리하기 너무 많을 경우 유용
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2을(를) 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;

            /**
             * 02.5 중간점검
             * 1.case 절에서 break문을 생략하면 어떻게 되는가?
             * 에러 발생 (/but case 절이 비어있는경우 에러가 발생하지 않는다)
             */

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는? ");
            //Console.Write("1. C\t");
            //Console.Write("2. C++\t");
            //Console.Write("3. C#\t");
            //Console.Write("4. Java\n");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("C 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("C++ 선택");
            //        break;
            //    case 3:
            //        Console.WriteLine("C# 선택");
            //        break;
            //    case 4:
            //        Console.WriteLine("Java 선택");
            //        break;
            //    default:
            //        Console.WriteLine("C, C++, C#, Java가 아니군요.");
            //        break;


            //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            //string weather = Console.ReadLine();

            //switch(weather) 
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오는군요.");
            //        break;
            //    default:
            //        Console.WriteLine("혹시 눈이 내리나요?");
            //        break;
            //}

            ////while 문은 조건식이 참일 동안 문장을 반복 실행한다.

            ////while 문은 반복문인데 5번 실행 예정
            //int loopCounter = 0;
            //while(loopCounter < 5) 
            //{
            //    Console.WriteLine("{0} 반복문이 정말로 5번만 실행되나?", loopCounter+1);
            //    loopCounter++;
            //}       //loop :5번만 도는 루프


            ////10~1카운트 후 발사 출력하는 프로그램
            //loopCounter = 10;
            //while (loopCounter >0)
            //{
            //    Console.WriteLine("{0} ", loopCounter);
            //    loopCounter -= 1;
            //}
            ////Console.WriteLine("발사");

            //////예제 #1 - 구구단 출력하는 프로그램 작성. User input 받아서 해당 단을 출력
            ////int userGugudan = 0;
            ////Console.Write("구구단 중에 출력하고 싶은 단 입력: ");
            ////int.TryParse(Console.ReadLine(), out userGugudan);

            ////const int GUGU_LOOP_COUNT = 9;
            ////int guguLoopIdx = 1;
            ////while(guguLoopIdx <=GUGU_LOOP_COUNT)
            ////{
            ////    Console.WriteLine("{0}*{1}={2}", userGugudan, guguLoopIdx, userGugudan * guguLoopIdx);
            ////    guguLoopIdx++;
            ////}

            ///**
            // * 문제 1
            // * 프로그램 사용자로부터 양의 정수를 하나 입력받아서 그 수만큼 "Hello. world!"를 출력하는 프로그램(양의 정수 -> 예외처리 까지)
            // */

            //float inputNumber = 0f;
            //Console.Write("Q1.양의 정수를 입력하시오: ");
            //float.TryParse(Console.ReadLine(), out inputNumber);

            //if (inputNumber <= 0)
            //{
            //    Console.WriteLine("다시 입력하시오");
            //}
            //else
            //{
            //    while (inputNumber > 0)
            //    {
            //        Console.WriteLine("Hello. world!");
            //        inputNumber -= 1;
            //    }
            //}


            ///**
            // * 프로그램 사용자로부터 양의 정수를 하나 입력받은 다음 그 수만큼 3의 배수를 출력하는 프로그램
            // * ex) input =5
            // * "3 6 9 12 15"
            // */
            //int inputNumber1 = 0;
            //int startNumber = 1;
            //Console.Write("Q2.양의 정수를 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out inputNumber1);
            //if (inputNumber1 <= 0)
            //{
            //    Console.WriteLine("다시 입력하시오");
            //}
            //else
            //{
            //    while (startNumber < inputNumber1 + 1)
            //    {
            //        Console.WriteLine("{0}*3={1}", startNumber, startNumber * 3);
            //        startNumber++;
            //    }
            //}



            ///**
            // * 프로그램 사용자로부터 계속해서 정수를 입력받는다. 그리고 그 값을 계속해서 더해 나간다. 
            // * 이러한 작업은 프로그램 사용자가 0을 입력할때까지 계속되어야 하며 0이 입력되면 모든 정수의 합을 출력하고 프로그램 종료
            // * user input ->1
            // * user input -> 10
            // * user input -> 0
            // * "모든 정수의 합: 11"
            // */

            //int sum = 0;
            //int endNumber = 0;
            //while (true)
            //{
            //    Console.Write("Q3.수를 입력하세요: ");
            //    int.TryParse(Console.ReadLine(), out endNumber);
            //    if (endNumber == 0) break; 
            //    sum += endNumber; 
            //}

            //Console.WriteLine("지금까지 입력된 수를 모두 더합니다: " + sum);


            ///**
            // * 입력받은 숫자에 해당하는 구구단을 출력하되 역순으로 출력하는 프로그램 작성
            // */
            //int rvsGugudan = 0;
            //Console.Write("Q4.구구단 중에 출력하고 싶은 단 입력: ");
            //int.TryParse(Console.ReadLine(), out rvsGugudan);

            //const int RVS_GUGU_LOOP_COUNT = 1;
            //int rvsGuguLoopIdx = 9;
            //while (rvsGuguLoopIdx >= RVS_GUGU_LOOP_COUNT)
            //{
            //    Console.WriteLine("{0}*{1}={2}", rvsGugudan, rvsGuguLoopIdx, rvsGugudan * rvsGuguLoopIdx);
            //    rvsGuguLoopIdx--;
            //}

            ///**
            // * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되 두가지의 조건을 만족할 것
            // * - 먼저 몇개의 정수를 입력할 것인지 사용자에게 묻는다. 그리고 그 수만큼 정수를 입력 받는다.
            // * - 평균 값은 소수점 이하까지 계산해서 출력한다. float
            // * ex) user input(Loop count) ->3
            // *     user input -> 10
            // *     user input -> 10 
            // *     user input -> 10 
            // *     "평균 값:10.0"
            // *     
            // */

            //float sum1 = 0;
            //float inputNumber5 = 0;
            //int loopCounter = 0;
            //int zero = 0;
            //Console.Write("Q5.루프 수 입력: ");
            //int.TryParse(Console.ReadLine(), out loopCounter);
            //while (loopCounter > zero)
            //{

            ////    Console.WriteLine("Q5.정수를 입력하시오 :");
            ////    float.TryParse(Console.ReadLine(), out inputNumber5);
            ////    sum1 += inputNumber5;
            ////    zero++;
            ////}
            ////float fin = (+sum1) / loopCounter;
            ////string.Format("{0:0.#0}", fin);
            ////Console.WriteLine("입력한 값의 평균: {0} ", fin);    //소수점 출력 ㅡㅡ

            ///**
            // * 두 실수를 입력받아서 값이 같은지 다른지 출력하는 프로그램 작성(Equals 등 메서드 사용x)
            // */

            //float num1 = 0;
            //Console.Write("첫번째 실수 입력: ");
            //float.TryParse(Console.ReadLine(), out num1);
            //float num2 = 0;
            //Console.Write("두번째 실수 입력: ");
            //float.TryParse(Console.ReadLine(), out num2);
            //float value = num1 - num2;
            //if(value > 0)
            //{
            //    Console.WriteLine("다르다");
            //}
            //else if(value < 0)
            //{
            //    Console.WriteLine("다르다");
            //}
            //else 
            //{
            //    Console.WriteLine("같다");
            //}
            ///**
            // * 블로그 - 부동소수점 에러/앱실론
            // */

            ///**
            // * for 문은 일정한 횟수만큼 반복할 때 유용하다.
            // * 초기식을 실행한 후에 조건식이 참인 동안 문장을 반복한다
            // * 한번 반복이 끝날 때마다 증감식이 실행
            // */
            //int sumNumber = 0;

            //for(int index = 1; index <=10; index++) 
            //{
            //    sumNumber += index;
            //}
            //Console.WriteLine($"1부터 10까지의 정수의 합 = {sumNumber}");
            //Console.WriteLine("1부터 10까지의 정수의 합 = {0}", sumNumber);

            /**
             * 1~100까지의 숫자 중에서 3의 배수를 제외한 수의 합 구하기
             */

            //int sumNumber1 = 0;
            //for (int index1 = 1; index1 <= 100; index1++)
            //{
            //    sumNumber1 += index1;
            //}

            //int sumNumber2 = 0;
            //for (int index2 = 1; index2 <= 100/3; index2++)
            //{
            //    sumNumber2 += index2*3;
            //}
            //Console.WriteLine("{0}", sumNumber1 - sumNumber2);

            //int sumNumber = 0;
            //for(int index = 1; index <=100; index++) 
            //{
            //    if(index % 3 ==0) { /*Do nothing(일부러 비워놓음)*/ }
            //    else 
            //    { 
            //        sumNumber += index; 
            //    }
            //}
            //Console.WriteLine(sumNumber);

            /**
             * break문
             * break 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
            // * continue 문
            // * continue 문은 현재 수행하고 있는 반복과정의 나머지를 건너뒤고 다음 반복 과정을 강제적으로 시작하게 만든다.
            // * 반복 루프에서 continue 문은 만나게 되면  continue 문 다음에 있는 후속 코드들은 실행되지 않고 건너뛰게 된다.
            // */

            //for(int index = 1; index <=10; index++) 
            //{
            //    Console.WriteLine("현재 인덱스 {0}", index);
            //    if (index == 4) { break; }
            //    Console.WriteLine("현재 인덱스 {0}", index);
            //}

            /**
             * LAB문제1
             * 자음과 모음 개수 세기
             * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
             * -대 소문자 모두 카운트
             *      ex) a
             *          b
             *          c
             *          d
             *          Z
             *          모음 :1
             *          자음 :4
            // */

            //char alphabet = 'a';
            //int vowel = 0;
            //int consonant = 0;
            //while (alphabet != 'Z')
            //{
            //    Console.Write("알파벳을 입력하세요: ");
            //    char.TryParse(Console.ReadLine(), out alphabet);
            //    switch (alphabet)
            //    {
            //        case 'a':
            //            vowel++;
            //            break;
            //        case 'e':
            //            vowel++;
            //            break;
            //        case 'i':
            //            vowel++;
            //            break;
            //        case 'o':
            //            vowel++;
            //            break;
            //        case 'u':
            //            vowel++;
            //            break;
            //        default:
            //            consonant++;
            //            break;
            //    }


            //    Console.WriteLine("자음 개수: {0}", consonant);
            //    Console.WriteLine("모음 개수: {0}", vowel);




                //}

                //char alphabet = default;
                //char input_char = default;
                //while (true)
                //{
                //    Console.Write("Q1.알파벳을 입력하세요: ");
                //    char.TryParse(Console.ReadLine(), out input_char);
                //    if (input_char == 'Z') break;
                //}
                /**
                 * LAB2
                 * 숫자 맞추기 게임
                 * 숫자 알아맞히기 게임이다 프로그램은 1~100사이의 정수를 저장하고 잇음
                 * 사용자는 질문을 통해서 숫자를 알아 맞힌다. 사용자가 답을 제시하면 프로그램은 제시된 정수가 더 낮은 값인지
                 * 높은 값인지 알려준다.
                 * 사용자가 알아맞힐때까지 루프 한다.(기본형)
                 * 
                 * - Q2-1.프로그램을 수정하여 컴퓨터가 생성한 숫자를 사용자가 추측하는 대신에 사용자가 결정한 번호를 
                 *   컴퓨터가 추측하도록 수정한다. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를 컴퓨터에 알려야 한다.
                 *   컴퓨터가 맞힐때까지 반복(어려운 난이도)
                 * - Q2-2사용자가 결정한 범위는 (1~100) 어떤 숫자를 생각하던 7번 이하의 추측으로 컴퓨터가 맞출 수 있도록 
                 *   Q2-1프로그램을 수정  
                 */

                //Random random = new Random();
                //int computer = random.Next(100) + 1;
                //int user_input = 0;
                //for (; ; )
                //{
                //    Console.WriteLine("1에서 100사이의 수를 입력하세요.");
                //    int.TryParse(Console.ReadLine(), out user_input);
                //    if (user_input == computer)
                //    {
                //        Console.WriteLine("축하합니다. 맞혔습니다.");
                //        break;
                //    }

                //    if (user_input > computer)
                //    {
                //        Console.WriteLine("더 작습니다.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("더 큽니다.");
                //    }

                //}

                /**
                 * LAB3. 산수 문제 자동 출제
                 * 산수 문제를 자동으로 출제하는 프로그램을 작성해보자. 덧셈 문제들을 자동으로 생성 하여야 한다.
                 * 피연산자는 0~99사이의 숫자(난수) 한번이라도 맞으면 종료. 틀리면 리트라이
                 * -추가) 뺄셈 곱셈 나눗셈 문제도 출제(나눗셈 예외처리:무한대값 주의)
                 */

            //Random random = new Random();
            //float ran_num1 = random.Next(100);  
            //float ran_num2 = random.Next(100);  
            //float question1 = ran_num1 + ran_num2;  
            //float question2 = ran_num1 * ran_num2;
            //float question3 = ran_num1 - ran_num2;
            //float question4 = ran_num1 / ran_num2;

            //float question4_1 = 0;
            //float.TryParse(String.Format("{0:0.00}", question4), out question4_1);

            //float answer = 0;

            //Console.WriteLine("{0}+{1}의 값은? :", ran_num1, ran_num2);
            //for (; ; )
            //{
            //    Console.WriteLine("정답 입력: ");
            //    float.TryParse(Console.ReadLine(), out answer);
            //    if (answer == question1)
            //    {
            //        Console.WriteLine("축하합니다. 맞혔습니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("오답입니다.");
            //    }
            //}

            //Console.WriteLine("{0}*{1}의 값은? :", ran_num1, ran_num2);
            //for (; ; )
            //{
            //    Console.WriteLine("정답 입력: ");
            //    float.TryParse(Console.ReadLine(), out answer);
            //    if (answer == question2)
            //    {
            //        Console.WriteLine("축하합니다. 맞혔습니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("오답입니다.");
            //    }
            //}

            //Console.WriteLine("{0}-{1}의 값은? :", ran_num1, ran_num2);
            //for (; ; )
            //{
            //    Console.WriteLine("정답 입력: ");
            //    float.TryParse(Console.ReadLine(), out answer);
            //    if (answer == question3)
            //    {
            //        Console.WriteLine("축하합니다. 맞혔습니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("오답입니다.");
            //    }
            //}


            //Console.WriteLine("{0}/{1}의 값은? :", ran_num1, ran_num2);
            //for (; ; )
            //{
            //    Console.WriteLine("정답 입력: ");   
            //    float.TryParse(Console.ReadLine(), out answer);
            //    if (answer == question4_1)
            //    {
            //        Console.WriteLine("축하합니다. 맞혔습니다.");
            //        break;
            //    }
            //    else if (ran_num2 == 0)
            //    {
            //        Console.WriteLine("답을 구할 수 없습니다.");
            //        //ran_num2 = random.Next(100);      분모 0일때 주사위 리롤(상단에 추가)
            //        //continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("오답입니다.");
            //    }
            //}


            /**
             * 오늘의 과제 LAB문제1 ~LAB문제 3의 모든 라인에서 각 라인이 어떤 역할을 하는지 주석으로 설명해서 제출할 것
             * 형티는 zip파일 *gitignore참고' 용량 잘 보고 올릴 것
             * 파일명 과제_이름_날짜.zip
             */


            //foreach
            //string 에서 글자를 하나씩 출력
            string stringText = "Hello. world!";
            
            int loopCount = 0;
            foreach(char oneCharactor in stringText) 
            {
                Console.Write("{0} ", oneCharactor);

                loopCount++;
            }   //loop : stringText의 길이만큼 도는 루프
            Console.WriteLine("\nLoopCount: {0}, stringText's length: {1}", loopCount,stringText.Length);

            /**
             * 1~100숫자 중 3의 배수이면서 4의 배수인 정수 합 구하기
             */

            
            /**
             * 두개의 정수를 입력 받아서 두 수의 차를 출력하는 프로그램 작성
             * 항상 큰 수에서 작은 수를 뺀 결과를 출력할것(결과는 0 이상)
             */

            /**
             * 구구단을 출력하되 짝수(2단, 4단, 6단, 8단)만 출력되도록 하는 프로그램을 작성
             * 2단은 2x2까지만 4단은 4x4까지만...~8단은 8x8까지만 출력한다
             * break와 continue를 사용할 것
             */

            /**
             * 다음 식을 만족하는 모든 A와 Z를 구하는 프로그램을 작성
             *          A Z
             *       +  Z A
             *       -------
             *          9 9
             */
        }
    }
    }