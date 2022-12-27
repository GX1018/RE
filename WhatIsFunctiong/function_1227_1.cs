using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunctiong
{
    internal class function_1227_1
    {
        public static void Main()
        {
                       
            Hi();
            Multiply(5, 4);

            Maximum(-1,-3,-5);
            Console.WriteLine("\n=====예제1================");
            double sizeZ = Hypot(4, 5);
            Console.WriteLine("{0:0.00}",sizeZ);


            Console.WriteLine("\n=====예제2================");

            Prime();
            Console.WriteLine();


            Console.WriteLine("\n=====예제3================");

            sayHello(5);


            Console.WriteLine("\n=====예제4================");

            Console.WriteLine("전화번호를 입력하세요\n quit입력 시 종료");
            DeleteBracket(Console.ReadLine());

        }

        //화살표 함수(Lamda)
        static void Hi() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a *b);

        // 예제1) 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x,y,z)를 정의할 것

        static void Maximum(int x, int y, int z)
        {
            if(x >= y && x >= z)
            {
                Console.WriteLine("입력한 값 {1}, {2}, {3} 중\n최대값은 : {0}", x, x, y, z);
            }
            else if (y >= x && y >= z)
            {
                Console.WriteLine("입력한 값 {1}, {2}, {3} 중\n최대값은 : {0}", y, x, y, z);
            }
            else
            {
                Console.WriteLine("입력한 값 {1}, {2}, {3} 중\n최대값은 : {0}", z, x, y, z);
            }
        }

        // 예제2) 다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()을 정의할 것
        //      - 매개변수는 2개 타입은 double 형.
        //      - 리턴 타입도 double형        static double Hypot(double , double )
        static double Hypot(double sideX, double sideY)
        {
           
            double squareSideZ = sideX * sideX + sideY * sideY;
            double sizeZ = Math.Sqrt(squareSideZ);

            return sizeZ;
        }

        // 예제3) 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성.
        //      - 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
        //  소수인지 확인-_-
        static void Prime()
        {
            for(int x = 2; x<100; x++)         
            {
                bool primeCheck = true;

                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        primeCheck = false;
                    }
                }
                if(primeCheck)
                {
                    Console.Write("{0}, ", x);
                }

            }

        }
        //
        /**
         * 
         */
        //
        // 예제4) 화면에 "Hello"를 출력하는 sayHello()함수를 작성.
        //      - int 타입 매개변수를 받아서 그 횟수만큼 "Hello"를 반복해서 출력
        static void sayHello(int printNumber)
        {
            for (int x = 0; x < printNumber; x++)
            {
                Console.WriteLine("{0})hello",x+1);
            }
        }

        // 예제 5) 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성(함수 사용)
        //      - 전화번호를 입력받는다 -> 소괄호를 삭제한 형태로 출력한다.
        //      - quit 입력하면 프로그램을 종료한다.
        //      - 프로그램 종료 전까지 전화번호를 입력 받는다.
        
        static void DeleteBracket(string phoneNumber)//010)1234-5678
        {
            while (!(phoneNumber == "quit"))
            {
                string[] modifiedPhoneNumber = phoneNumber.Split(')');
                Console.WriteLine("수정된 전화번호 : {0}-{1}", modifiedPhoneNumber[0], modifiedPhoneNumber[1]);
                Console.WriteLine("전화번호를 입력하세요\n quit입력 시 종료");
                phoneNumber = Console.ReadLine();
            }
        }

        static void Homework()
        {
            /**
             * 슬라이딩 퍼즐 게임
             * 
             * 퍼즐 게임화면
             * 
             * 1 2 3
             * 4 5 6
             * 7 8 x
             * 
             * 완성하면 클리어
             * 
             * wasd방향에따라 x 위치 이동
             * 
             */

            //맵 구현
            //ㅁㅁㅁㅁㅁ
            //ㅁ. . .ㅁ
            //ㅁ. . .ㅁ
            //ㅁ. . .ㅁ
            //ㅁㅁㅁㅁㅁ

            string[,] gameBoard = new string[5, 5];

            for(int x = 0; x<gameBoard.Length; x++)
            {
                for(int y = 0; y < gameBoard.Length; y++)
                {
                    if (x == 0)
                    {
                        gameBoard[x, y] = "□";
                    }
                }
            }
            Console.WriteLine(gameBoard[0,0]);



            //화면 초기화Console.Clear();
        }


    }
}
