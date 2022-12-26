using System;

namespace WhatIsFunctiong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[,] starArray = new string[5, 5];

            ////별 찍기 -직각 삼각형

            ////별을 초기화하는 코드
            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        starArray[y, x] = "*";
            //    }
            //}

            ////별을 출력하는 코드
            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < y + 1; x++)
            //    {
            //        if (starArray[y, x].Equals("*"))
            //        {
            //            Console.Write("{0}", starArray[y, x]);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //어서와c++은 처음이지 109p Lab


            //과제
            /**
             * 5x5 보드(사이즈 줘도 ok)
             * □ □ □ □  □
             * □ . .  . □
             * □ . 읏 . □    02 12 22 32 42 [x, y] 
             * □ . .  . □
             * □ □ □  □ □
             * .(닷) 은 빈 곳, □는 벽을 의미
             * 
             * 빈 곳 중에 아무곳(정 중앙)이나 사람(이모티콘 또는 옷)을 초기화해서
             * w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성
             * - 사람은 빈곳을 다닐 수 있음
             * - 사람은 벽을 넘어다닐 수 없음
             * readkey? a->x-1 d-> x+1 w-> y-1 s -> y+1  temp a b 돌려넣기?
             */

            /**
             * 함수(Functiong) 또는 메서드(Method)는 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다.
             * 함수를 부르는 다양한 명칭
             * 함수(Function)
             * 메서드(Method)      class 멤버?인 함수만 메서드로 표현
             * 프로시저(Procedure)
             * 서브루틴(subroutine)
             * 서브모듈(submodule)
             * 
             * 프로그래밍을 하다 보면 같은 유형의 코드를 반복할 때가 많다. 
             * 이 코드들을 매번 입력하면 불편하고 입력하다 실수도 할 수 있다. 이때 ‘함수’를 사용한다.
             * 
             * 프로그래밍 언어에서 함수는 어떤 동작 및 행위를 표현한다. 
             * 함수의 사용 목적은 코드 재사용에 있다. 한 번 만들어 놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다. 
             * 지금까지 사용한 Main()메서드는 C#의 시작 지점을 나타내는 특수한 목적의 함수로 볼 수 있다.
             * 또, Console 클래스의 WriteLine()메서도도 함수로 볼 수 있다.
             * 
             * - 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결괏값을 반환시켜 주는 코드
             * - 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.
             * 
             * 함수의 종류(내장 함수와 사용자 정의 함수)
             * 함수에는 내장 함수와 사용자 정의 함수가 있다. 내장 함수는 C#이 자주 사용하는 기능을 미리 만들어서
             * 제공하는 함수로, 특정 클래스의 함수로 표현된다.
             * 내장 함수도 그 용도에 따라 문자열 관련함수, 날짜 및 시간 관련 함수, 수학관련 함수, 형식 변환 관련 함수
             * 등으로 나눌 수 있다. 이러한 내장 함수를 API(Application Programming Interface)로 표현한다.
             * 사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수이다.
             * 
             * 함수 정의하고 사용하기
             * 함수 정의(Define)는 함수를 만드는 작업이다. 함수 호출(Call)은 함수를 사용하는 작업이다.
             * 함수 생성 및 호출은 반드시 소괄호가 들어간다.
             * 함수를 정의하는 형태는 지금까지 사용한 Main()메서드와 유사하다.
             * 다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다.
             * 
             * static void [함수이름]()
             * {
             *      함수내용
             * }
             * 
             * 만든 함수를 호출하는 형태는 다음 세 가지가 있다.
             * [함수이름]();
             * [함수이름](매개변수);
             * 변수(결과값) = [함수이름](매개변수);
             * 
             */

            Show();

            //보드 세팅
            Console.WriteLine("보드의 크기(홀수)를 입력하세요 [N] X [N]");
            int boardSize = int.Parse(Console.ReadLine());
            string[,] arrayHomework = new string[boardSize, boardSize];
            string temp = "";
            if (boardSize % 2 == 0) 
            { Console.WriteLine("잘못 입력하셨습니다."); }
            else
            {
            for (int x = 0; x < arrayHomework.GetLength(0); x++)
            {
                for (int y = 0; y < arrayHomework.GetLength(1); y++)
                {
                    if (y == arrayHomework.GetLength(1)/2 && x == arrayHomework.GetLength(0)/2)
                    {
                        arrayHomework[x, y] = "옷";      //[2,2]
                    }
                    else if (x==0||y == 0||x== arrayHomework.GetLength(0)-1 || y== arrayHomework.GetLength(1)-1)
                    {
                        arrayHomework[x, y] = "□";
                    }
                    else
                    {
                        arrayHomework[x, y] = ". ";

                    }
                }
            }

            //시각화
            for (int x = 0; x < arrayHomework.GetLength(0); x++)
            {
                for (int y = 0; y < arrayHomework.GetLength(1); y++)
                {
                    Console.Write("{0}", arrayHomework[x, y]);
                }
                Console.WriteLine();
            }
            int a = arrayHomework.GetLength(0)/2; int b = arrayHomework.GetLength(1)/2;
            while (true)
            {
                Console.WriteLine("이동하고 싶은 방향을 입력하세요\n .을 누르면 종료합니다");
                    string inputDirection = Console.ReadLine();
                    switch (inputDirection)
                    {
                        case "a":
                            if(b==1)
                            { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                            else
                            {
                                temp = arrayHomework[a, b - 1];
                                arrayHomework[a, b - 1] = arrayHomework[a, b];
                                arrayHomework[a, b] = temp;
                                b--;
                            }
                            break;
                        case "d":
                            if(b == arrayHomework.GetLength(0)-2)
                            { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                            else
                            { 
                            temp = arrayHomework[a, b + 1];
                            arrayHomework[a, b + 1] = arrayHomework[a, b];
                            arrayHomework[a, b] = temp;
                            b++;
                            }
                            break;
                        case "w":
                            if(a==1)
                            { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                            else
                            {
                            temp = arrayHomework[a - 1, b];
                            arrayHomework[a - 1, b] = arrayHomework[a, b];
                            arrayHomework[a, b] = temp;
                            a--;
                            }
                            break;
                        case "s":
                            if(a== arrayHomework.GetLength(1)-2)
                            { Console.WriteLine("\n[System]이동할수없습니다.\n"); }
                            else
                            {
                            temp = arrayHomework[a + 1, b];
                            arrayHomework[a + 1, b] = arrayHomework[a, b];
                            arrayHomework[a, b] = temp;
                            a++;
                            }
                            break;
                        default:
                            Console.WriteLine("잘못 입력하셨습니다.");
                            break;
                    }
                
                
                for (int x = 0; x < arrayHomework.GetLength(0); x++)
                {
                    for (int y = 0; y < arrayHomework.GetLength(1); y++)
                    {
                        Console.Write("{0}", arrayHomework[x, y]);
                    }
                    Console.WriteLine();
                }
                if (inputDirection == ".") { break; }
                }
            }







        }//main()

        static void Show()  //static을 빼고 설정하면 main()에서 사용할수 없음
        {
            Console.WriteLine("Hello world");
        }

        /**
         * 이 함수는 가장 간단한 형태의 함수로, 매개변수(Paramater)도 없고 변환값(Return value)도 없는 형태이다.
         */

    }//class
}



//git fetch -p
//깃 기능 중에 패치를 받아오는 기능
//->깃에서 기록한 변경사항(수정사항)을 내려 받아서 어떤 것이 변경된 것인지 확인할 수 있도록 하는 기능

//git pull origin main
//got pull[원격 리포지토리 이름]
//pull 기능은 push와는 반대의 기능
//내 로컬 리포지토리를 원격 리포지토리 내용으로 덮어 쓰는 기능