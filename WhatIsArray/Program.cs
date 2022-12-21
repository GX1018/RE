using System;

namespace WhatIsArray
{
    //클래스, C#에서는 모든 요소들이 클래스 안에 있어야 함.

    internal class Program
    {
        //
        static void Main(string[] args)
        {
            //프로그램은 여기서 부터 읽기 시작
            Console.WriteLine("Hello, World!");

            //여기서 끝

            //3의 배수를 제외한 수
            //int variable_ = 100;

            int sumOfNumber = 0;

            for (int variable_ = 1; variable_ <= 100; variable_++)
            {
            //    bool multiplethree = (variable_ % 3 == 0);
            //    Console.WriteLine("{0}->is isRealMultipleOfThree: {1}", variable_, multiplethree);  //3의 배수인지 확인
                if (variable_%3==0)
                {
                    //        //3의 배수인 것들
                }
                else
                {
                    sumOfNumber += variable_;            
                    Console.Write($"{variable_}, ");
                }

            }
            Console.WriteLine($"\n{sumOfNumber}");


            ////조건문에 대해
            ////if(/*여기서 조건문 검사*/)  //조건문A
            //{
            //    //조건문A가 참(true)이면 여기로 옴
            //    //조건문A가 여기서부터 읽기 시작
            //    //조건문A는 여기서 끝난다.
            //}
            ////else if (/*여기서 조건문 검사*/)    //조건문B
            //{
            //    //조건문B가 참(true)이면 여기로 옴
            //    //조건문B가 여기서부터 읽기 시작
            //    //조건문B는 여기서 끝난다.
            //}
            ////else 
            //{
            //    //조건문이 거짓(false)이면 여기로 옴
            //    //조건문은 여기서부터 읽기 시작
            //    //조건문은 여기서 끝난다.
            //}

            ////조건문을 실행했으면 이제 다시 여기서부터 프로그램 시작한다.
            ////프로그램은 여기서 끝난다.


            ////예제

            //string gender = "여자";
            //if (gender == "남자")
            //{
            //    Console.WriteLine("남성이시군요");
            //}
            //else if (gender == "여자")
            //{
            //    Console.WriteLine("여성이시군요");
            //}
            //else
            //{
            //    Console.WriteLine("남성도 여성도 아니시네요");
            //}
            ////

            ////프로그램 사용자로부터 양의 정수를 하나 입력받아서
            ////그 수만큼 "Hello world!"를 출력하는 프로그램 작성.
            //int someNumber = 100;
            //bool isPositiveInteger = (0 < someNumber);  //someNumber 가 양의 정수인지 확인 (T/F)

            int inputPositive = 0;
            Console.WriteLine("양의 정수를 입력하세요.");
            int.TryParse(Console.ReadLine(), out inputPositive);

            if(inputPositive > 0)
            {
                while (inputPositive > 0) 
                {
                    Console.WriteLine("Hello. world!");
                    inputPositive--;
                }
            }
            else
            {
                Console.WriteLine("다시 입력하세요.");
            }

            ///**
            // * 프로그램 사용자로부터 계속해서 정수를 입력 받는다.
            // * 그리고 그 값을 계속해서 더해 나간다.
            // * 이러한 작업은 사용자가 0을 입력할때까지 계속 진행,
            // * 0이 입력되면 입력된 모든 정수의 합을 출력후 프로그램 종료
            // */
            //bool isNumberZero = (someNumber == 0);

            ////프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되,
            ////역순으로 출력하는 프로그램을 작성.
            //int userInputNumber = 3;
            //for (int index = 9; index >= 1; index--)//9번 도는 루프
            //{
            //    Console.WriteLine("{0}x{1}={2}", userInputNumber, index, userInputNumber * index);
            //}

            ///**
            // * 코드 맞추기
            // * 컴퓨터가 숨기고 있는 코드를 추측
            // * 비밀 코드는 a~z사이의 문자 //if문 필요
            // * 컴퓨터는 사용자의 추측을 읽고서 앞에있는지, 뒤에있는지 알려줌
            // */
            //char scretCode = 'y';
            //char userInPutAlphabet = 'y';
            //bool isSmallAlphabet =
            //    ('a' <= userInPutAlphabet && userInPutAlphabet <= 'z');
            //bool isAlphabetFore = (userInPutAlphabet < scretCode);
            //bool isAlphabetBack = (userInPutAlphabet > scretCode);

            //if (isSmallAlphabet) { /*do nothing*/}
            //else
            //{
            //    Console.WriteLine("{0}, {1}",
            //        "[system]입력을 처리할 수 없습니다.",
            //        "알파벳 소문자만을 입력해주세요");
            //}

            //if (isAlphabetFore)
            //{
            //    Console.WriteLine("입력한 값이 시크릿 코드보다 앞에 있습니다.");
            //}
            //else { }
            //if (isAlphabetBack)
            //{
            //    Console.WriteLine("입력한 값이 시크릿 코드보다 뒤에 있습니다.");
            //}
            //else { }
            //if (userInPutAlphabet == scretCode)
            //{
            //    Console.WriteLine("정답입니다.");

            //}
            //else { }

            ////1~100숫자 중 3의배수이면서 4의 배수인 정수 합 구하기

            int sumNum = 0;

            for(int var_=0; var_<=100; var_++)
            {
                if (var_ % 3 == 0 && var_ % 4 == 0)
                {
                    sumNum+=var_;
                }
            }
            Console.WriteLine("1~100숫자 중 3의배수이면서 4의 배수인 정수 합은 {0}이다", sumNum);


            //int sumNumber = 0;
            //int someNumber_2 = 100;
            //bool isMultipleOfThree = (someNumber % 3 == 0);
            //bool isMultipleOfFour = (someNumber % 4 == 0);

            //bool isSatisfyCondition = isMultipleOfFour && isMultipleOfThree;

            //if (isSatisfyCondition)
            //{
            //    sumNumber += someNumber_2;
            //}       //if :3의 배수이면서 4의 배수인 값

            ////별 100개 찍는법
            //for (int index = 1; index <= 100; index++)
            //{
            //    Console.Write("{0}", "*");
            //}

            ////
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.Write("{0}", "*");
            //    }       //loop: 밖의 루프가 1번 도는 동안 10번 도는 루프
            //    Console.WriteLine();
            //}           //10번 도는 루프


            ////
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //int hundredCount = 0;
            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        for (int index3 = 1; index3 <= 10; index3++)
            //        {
            //            hundredCount++;
            //            if (101 <= hundredCount) { break; }
            //            else { }
            //            //별을 찍는 지점
            //            Console.Write("{0}", "*");

            //            //10번마다 한줄씩 띄우기
            //            if(hundredCount %10 == 0)
            //            {
            //                Console.WriteLine();
            //            }
            //        }       //loop: 밖의 루프가 1번 도는 동안 10번 도는 루프
            //    }           //10번 도는 루프
            //}

            ////유저 입력 받아서 (1~20줄 이내).유저 입력은 줄의 개수
            ////등차 수열로 한 단 내려갈때마다 별 1개씩 추가로 증가하는 프로그램 작성

            int userInput1_ = 0;
            Console.WriteLine("1~20 사이의 정수를 입력하세요.");
            int.TryParse(Console.ReadLine(), out userInput1_);
            int upperPyramid = (userInput1_ - 1) / 2 + 1;
            if (1 <= userInput1_ && userInput1_ <= 20)
            {
                for (int index = 1; index <= upperPyramid; index++)
                {
                    for(int index1=1; index1<=upperPyramid-index; index1++)
                    {
                        Console.Write(" ");
                    }
                    for (int index1 = 1; index1 <= 2*index-1; index1++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");

                }
            }


            //int userInput = 0;
            //Console.WriteLine("숫자 입력: ");
            //int.TryParse(Console.ReadLine(), out userInput);
            //for (int index = 1; index <= userInput; index++)
            //{
            //    for (int index1 = 1; index1 <= index; index1++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////
            //int userInput1 = 0;
            //Console.WriteLine("숫자 입력: ");
            //int.TryParse(Console.ReadLine(), out userInput1);
            //int output = userInput1/2+1;
            //for (int index = 1; index <= output; index++)
            //{
            //    for (int index1 = 1; index1 <= output - index; index1++)    //
            //        Console.Write(" ");
            //    for (int index1 = 1; index1 <= 2 * index - 1; index1++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //for(int index= output - 1; index >=1; index--)
            //{
            //    for (int index1 = 1; index1 <= output - index; index1++)
            //        Console.Write(" ");
            //    for (int index1 = 1; index1 <= 2 * index - 1; index1++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}

            ////
            //int userInput2 = 0;
            //Console.WriteLine("숫자 입력: ");
            //int.TryParse(Console.ReadLine(), out userInput2);
            //int output1 = userInput2 / 2 + 1;
            //bool odd = (userInput2%2 > 0);
            //if (odd == true)        //홀수일때 출력
            //{
            //    for (int index = 1; index <= output1; index++)
            //    {
            //        for (int index1 = 1; index1 <= output1 - index; index1++)    //
            //            Console.Write(" ");
            //        for (int index1 = 1; index1 <= 2 * index - 1; index1++)
            //            Console.Write("*");
            //        Console.WriteLine();
            //    }
            //    for (int index = output1 - 1; index >= 1; index--)
            //    {
            //        for (int index1 = 1; index1 <= output1 - index; index1++)
            //            Console.Write(" ");
            //        for (int index1 = 1; index1 <= 2 * index - 1; index1++)
            //            Console.Write("*");
            //        Console.WriteLine();
            //    }
            //}
            //else    //짝수일때 출력
            //{
            //    for (int index = 1; index <= output1-1; index++)
            //    {
            //        for (int index1 = 1; index1 <= output1-1 - index; index1++)    //
            //            Console.Write(" ");
            //        for (int index1 = 1; index1 <= 2 * index - 1; index1++)
            //            Console.Write("*");
            //        Console.WriteLine();
            //    }
            //    for (int index = output1- 1; index >= 1; index--)
            //    {
            //        for (int index1 = 1; index1 <= output1-1 - index; index1++)
            //            Console.Write(" ");
            //        for (int index1 = 1; index1 <= 2 * index - 1; index1++)
            //            Console.Write("*");
            //        Console.WriteLine();
            //    }
            //}

            //Console.WriteLine();

            //int 입력 = 0;
            //Console.WriteLine("숫자입력하시오: ");
            //int.TryParse(Console.ReadLine(), out 입력);
            //int 줄_관련 = (입력 - 1) / 2;

            //for (int x = 1; x <= 줄_관련 + 1; x++)     //피라미드상단
            //{
            //    for (int y = 1; y <= 줄_관련+(1-x); y++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int y=1; y <= 2 * x - 1; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //숫자야구
            //
            int a = 0;
            int b = 0;
            int c = 0;
            int com_num1 = 1;
            int com_num2 = 2;
            int com_num3 = 3;

            for (int count = 1; count <= 10; count++)
            {
                if (a == com_num1 && b == com_num2 && c == com_num3)
                {
                    Console.WriteLine("승리");
                    break;
                }
                else if (count == 10)
                {
                    Console.WriteLine("패배");
                    break;
                }
                else
                {
                    int str = 0;
                    int ball = 0;
                    Console.WriteLine("{0}번째 기회", count);
                    while (true)
                    {
                        Console.WriteLine("첫번째 숫자를 입력하시오: ");
                        int.TryParse(Console.ReadLine(), out a);
                        if (a == com_num1)
                        {
                            ++str;
                            break;
                        }
                        else if (a == com_num2)
                        {
                            ++ball;
                            break;
                        }
                        else if (a == com_num3)
                        {
                            ++ball;
                            break;

                        }
                        else
                        {
                            break;

                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("두번째 숫자입력하시오: ");
                        int.TryParse(Console.ReadLine(), out b);
                        if (b == com_num2)
                        {
                            ++str;
                            break;

                        }
                        else if (b == com_num1)
                        {
                            ++ball;
                            break;

                        }
                        else if (b == com_num3)
                        {
                            ++ball;
                            break;

                        }
                        else
                        {
                            break;

                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("세번째 숫자입력하시오: ");
                        int.TryParse(Console.ReadLine(), out c);
                        if (c == com_num3)
                        {
                            ++str;
                            break;

                        }
                        else if (c == com_num1)
                        {
                            ++ball;
                            break;

                        }
                        else if (c == com_num2)
                        {
                            ++ball;
                            break;

                        }
                        else
                        {
                            break;

                        }
                    }
                    
                    if (str == 0 && ball == 0)
                    {
                        Console.WriteLine("아웃");
                    }

                    else if(str<3)
                    {
                        Console.WriteLine("{0}s {1}b", str, ball);
                    }                
                }
            }
               

            /**
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료  구조를 컬렉션(Collection) 또는
             * 컨테이너(Container)라고 한다. C#에서 다루는 컬렉션은 배열(Array). 리스트(List),
             * 사전(Dictionary)등이 있다.
             * 
             * 배열
             * 배열(Array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다.
             * 각각의 데이터들은 인덱스(번호)를 사용하여 독립적으로 접근된다.
             * 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징들
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2. 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호([[[]]]])와 0부터 시작하는 정수형 인덱스를
             *      사용하여 접근할 수 있다.
             * 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(item)으로 표현한다.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상된다.
             * 
             * 배열에는 세가지 종류가 있다.
             * 1차원 배열 : 배열의 첨자를 하나하나 사용하는 배열
             * 다차원 배열 : 첨자 2개 이상을 사용하는 배열 (2차원, 3차원, ...n차원 배열)
             * 가변(Jagged) 배열 : 배열의 배열 이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.
             */

            //배열의 선언과 초기화
            int[] numbers = new int[5] { 100, 200, 300, 400, 500 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;

            Console.WriteLine(numbers);

            //numbers.Length
            //Console.WriteLine(numbers[numbers.Length-1]);

            //for(int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine("{0}", numbers[index]);
            //}

            //foreach(int element in numbers)     //element? 배열의 개체를 저장?
            //{
            //    Console.WriteLine("{0}", element);
            //}


        }// ctl+k+f 줄 정리
    }
}