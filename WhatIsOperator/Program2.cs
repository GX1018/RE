using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOperator
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            /**
             * 최대한도의 사탕 사기
             * 현재 1000원이 있고 사탕의 가격이 300원 일 때, 최대 살 수 있는 샅창의 개수와 나머지 돈은 얼마인지 출력하는 프로그램
             * 
             * ex) 현재 가지고 있는 돈 1000(유저입력)
             * 캔디 가격 : 300 (상수)
            // * 최대 살 수 있는 캔디의 개수 =3
            // * 캔디 구입 후 남은 돈 = 100
            // */

            //Console.Write("현재 가지고 있는 돈: ");
            //string currunt_money = Console.ReadLine();
            //int intNumber1 = default;
            //int.TryParse(currunt_money, out intNumber1);

            //int candy_number = intNumber1 / 300;
            //int change = intNumber1 - candy_number*300;
            
            //Console.WriteLine("최대로 살 수 있는 캔디의 수: {0}개\n캔디 구입 후 남은 돈{1}", candy_number, change);

            ///**
            // * 화씨온도를 섭씨온도로 바꾸기
            // * 우리나라는 섭씨온도를 사용하지만 미국에서는 화씨 온도를 사용
            // * 화씨 온도를 섭씨 온도로 바꾸는 프로그램을 작성
            // * 
            // * ex) 화씨 60도는 섭씨 xx도
            // */

            //Console.Write("화씨 온도: ");
            //string fahrenheit = Console.ReadLine();
            //float floatNumber1 = default;
            //float.TryParse(fahrenheit, out floatNumber1);

            //float celsius = (floatNumber1 - 32) * 5 / 9;
            //Console.WriteLine("입력한 화씨 온도를 섭씨 온도로 바꾸면 : {0}", celsius);

            ///**
            // * 주사위게임
            // * 2개의 주사위를 던져서 주사위의 합을 표시하는 프로그램을 작성
            // * 주사위를 던지면 랜덤한 수가 나와야 한다.(난수생성 : System.Random~)
            // */

            //Random rand = new Random();
            //Console.Write("1번 주사위를 던집니다");
            //Console.ReadLine();
            //int dice1 = rand.Next(1, 6+1);
            //Console.Write("2번 주사위를 던집니다");
            //Console.ReadLine();
            //int dice2 = rand.Next(1, 6+1);

            //int sum_dice = dice1 + dice2;

            //Console.WriteLine("1번 주사위:{1}\n2번 주사위:{2}\n두 주사위의 합: {0}", sum_dice,dice1,dice2);

            /**
             * 제어문
             * 프로그램을 이루는 3가지 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문), 반복 구조(반복문)가 있다.
             * 
             * 순차문
             * 프로그램은 기본적으로 Main()메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로 실행 후 종료한다.
             * 
             * 제어문
             * 프로그램 실행 순서를 제어하거나 프로그램 내용으 반복하는 작업 등을 처리할 때 사용하는 구문
             * 조건문과 반복문으로 구분한다.
             * 
             ** 조건문(선택문)
             * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조
             * 다른 말로 분기문 또는 비교 판단문이라고도 한다.
             * 
             ** 반복문
             * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용
             */

            /**
             * if /else 문
             * 프로그램 흐름을 여러 가지 갈래로 가지치기(branching)할 수 있는데, 이때 if 문을 사용한다. 
             * if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세 가지 키워드가 있다.
             */

            /**
             * 02.3 예제 #1 (교재 : 어서와 c++은 처음이지)
             * 두개의 정수 중ㅇ[서 더 큰 수를 찾는 프로그램
            // */

            //int numberX, numberY;
            //Console.Write("x값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberX);
            //Console.Write("y값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberY);

            //if(numberY < numberX)
            //{
            //    Console.WriteLine("x가 y보다 큽니다.");
            //}
            //else
            //{
            //    Console.WriteLine("y가 x보다 큽니다.");
            //}

            /**
             * 중간 점검1
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml이상 200ml미만은 medium, 200ml 이상은 large라고 출력하는 if-else 문을 작성
             */

            //int numberX;
            //Console.Write("컵의 사이즈를 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberX);

            //if(0 < numberX && numberX < 100)
            //{
            //    Console.WriteLine("small");
            //}
            //else if (100 <= numberX && numberX < 200)
            //{
            //    Console.WriteLine("medium");
            //}
            //else if (200 <= numberX)
            //{
            //    Console.WriteLine("large");
            //}
            //else
            //{
            //    Console.WriteLine("잘못 입력하셨습니다.");
            //}

            /**
             * 비밀 코드 맞추기
             * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
             * 비밀 코드는 a-z사이의 문자
             * 컴퓨터는 사용자의 추측을 읽고서 앞에있는지 뒤에있는지를 알려준다.(up&down)
             * 
             * ex) 컴퓨터의 비밀 코드 : h
             * 
             * 비밀 코드를 맟줘보세요 c(user input)
             * c 뒤에 있음
             * --프로그램 종료--
             * 비밀 코드를 맞춰보세요 h(user input)
             * 정답입니다.
             */

            //Random rand_code = new Random();
            //int com_code = rand.Next('a', 'z');
            //Console.Write("a-z사이의 문자를 입력하세요");

            //string input_code = Console.ReadLine();
            //char  code = default;
            //char.TryParse(input_code, out code);

            //if(input_code = com_code)

            const char SECRET_CODE = 'h';
            
            bool charBiggerTest = false;



            Console.Write("a-z사이의 문자를 입력하세요");
            string input_code = Console.ReadLine();
            char  code = default;
            char.TryParse(input_code, out code);

            if (code < SECRET_CODE)
            {
                Console.WriteLine("SECRET CODE 는 {0}보다 큽니다.", code);
            }
            else if (SECRET_CODE < code)
            {
                Console.WriteLine("SECRET CODE는 {0}보다 작습니다.", code);
            }
            else
            {
                Console.WriteLine("정답입니다");
            }

            /**
             * 세 개의 정수 중에서 큰 수 찾기
             * 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램 작성
             * 
             * ex) 1.세 개의 정수를 입력하시오 20 10 30  (hard)    split메서드 사용?
             *     (2. 1번 정수 입력 x
             *         2번 정수 입력 y
             *         3번 정수 입력 z)
             *         ===
             *         가장 큰 정수는 :
             */

            int numberX, numberY, numberZ;
            Console.WriteLine("세 개의 정수를 입력하시오. /스페이스로 구분");
            string num = Console.ReadLine();
            string[] str_num = num.Split(' ');
            int.TryParse(str_num[0], out numberX);
            int.TryParse(str_num[1], out numberY);
            int.TryParse(str_num[2], out numberZ);

            //int numberX, numberY, numberZ;
            //Console.Write("x값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberX);
            //Console.Write("y값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberY);
            //Console.Write("z값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberZ);

            if(numberX > numberY && numberX > numberZ)
            {
                Console.WriteLine(numberX);
            }
            else if(numberY > numberX && numberY > numberZ)
            {
                Console.WriteLine(numberY);
            }
            else
            {
                Console.WriteLine(numberZ);
            }

        }       //main()
    }
}
