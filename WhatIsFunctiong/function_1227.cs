using System;

namespace WhatIsFunctiong
{
    internal class function_1227
    {
        static void Main(string[] args)
        {
            
            SumNumber(10, 20);

            Console.WriteLine("======");
            CompareNumber(-50, -100);
            Console.WriteLine();

            Console.WriteLine("======");
            Multi();
            Console.WriteLine();
            Multi("반갑습니다.");
            Console.WriteLine();
            Multi("또 만나요.", 3);


            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine("{0}", Factorial(10));


            Console.WriteLine();
            Console.WriteLine("======");

            int number1 = 1;
            int number2 = 3;

            Swap(number1, number2);//함수 내(지역)에서 변경된 변수는((지역변수 number1 : 1->3, 지역변수 number2 : 3->1))

            Console.WriteLine("Main의 number 값은? {0}, {1}", number1 , number2);//전역 변수에 변동을 주지 않는다.(전역변수 number1 : 1, number : 3)
        }
        
        //전역변수와 지역 변수 확인
        static void Swap(int number1, int number2)      //지역 변수 number1, number2
        {
            Console.WriteLine("바뀌기 전의 값 : {0}, {1}", number1, number2);

            //스왑 과정
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("바뀐 후의 값 : {0}, {1}", number1, number2);  //지역 변수 number1 ->number2, number2 -> number1로 변경
        }
        //입력한 매개 변수의 합을 구하는 함수
        static int SumNumber(int number_1, int number_2)
        {
            int sum = (number_1 + number_2);
            Console.WriteLine("첫번째 수 : {0}\n두번째 수 : {1}\n합 : {2}", number_1, number_2, sum);
            return sum;
        }
        //입력한 매개 변수의 크기를 비교하고 각 변수의 절대값을 출력하는 함수
        static void CompareNumber(int number_1, int number_2)
        {
            if (number_1 > number_2)
            {
                Console.WriteLine("큰 값 : {0}", number_1);
                Console.WriteLine("작은 값 : {0}", number_2);
            }
            else if (number_2 > number_1)
            {
                Console.WriteLine("큰 값 : {0}", number_2);
                Console.WriteLine("작은 값 : {0}", number_1);
            }
            else
            {
                Console.WriteLine("같다");
            }

            //절대값
            if (number_1 >= 0 && number_2 >= 0)
            {
                Console.WriteLine("[{0}]의 절대값{0}, [{1}]의 절대값{1}", number_1, number_2);
            }
            else if (number_1 >= 0 && number_2 < 0)
            {
                Console.WriteLine("[{0}]의 절대값{0}, [{1}]의 절대값{2}", number_1, number_2, -number_2);
            }
            else if (number_1 < 0 && number_2 >= 0)
            {
                Console.WriteLine("[{0}]의 절대값{1}, [{2}]의 절대값{2}", number_1, -number_1, number_2);
            }
            else
            {
                Console.WriteLine("[{0}]의 절대값{1}, [{2}]의 절대값{3}", number_1, -number_1, number_2, -number_2);
            }
            //절대값 x if(x 양수)else// y if(y 양수) else
            //절대값 Console.WriteLine("[{0}]의 절대값{1}, [{2}]의 절대값{3}"", number_1, Math.Abs(number_1), number_2, Math.Abs(number_2)");
        }


        /**
             * 함수를 만들고 반복해서 사용하기
             * 함수를 만드는 목적 중 하나는 반복 사용에 있다. 함수를 만들고 여러 번 호출해서 사용하는 방법을 알아보자
             */

        //예제 안녕하세요 출력하는 함수
        static void Hi()
        {
            Console.WriteLine("안녕하세요");

        }
        //이름이 동일한 함수라도 매개변수를 다르게 설정하면 중복 생성이 가능하다.
        static void Hi(string text)
        {
            Console.WriteLine(text);
        }

        //매개변수도 있고 반환값도 있는 함수
        static int SquareFunction(int x)        //매개변수
        {
            int r = x * x;
            return r;   //:반환값
        }


        //! 매개변수와 반환값 설명

        static void ParameterAndReturn()
        {
            /**
             * 함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다. 호출할 때마다 조금씩 다른 기능을 적용할 때는
             * 함수의 매개변수를 달리하여 호출할 수 있다. 매개변수(인자. 파라미터)는 함수에 어던 정보를 넘겨주는 데이터를 나타낸다.
             * 이러한 매개변수는 콤마를 기준으로 여러 개 설정할 수 있으며, 문자열과 숫자 등 모든 데이터 형식을 사용할 수 있다.
             * 
             * 매개변수(인자, 파라미터)가 없는 함수 : 매개변수도 없고 반환값도 없는 함수 형태는 가장 단순한 형태의 함수이다.
             * 앞에서 사용한 함수 중에서 모든 변수에 있는 값을 문자열로 변환시키는 ToString() 메서드처럼 빈 괄호만 있는 함수 형식을 나타낸다.
             * 
             * 매개변수가 잇는 함수 : 특정 함수에 인자 값을 1개 이상 전달하는 방식이다. 
             * 정수형, 실수형, 문자형, 문자열형, 개체형 등 여러가지 데이터 형식을 인자 값으로 전달할 수 있다.
             * 
             * 반환값이 있는 함수(결과값이 있는 함수) : 함수의 처리 결과를 함수를 호출한 쪽으로 반환할 때는 return 키워드를 사용하여 데이터를 돌려줄 수 있다.
             * 
             * 매개변수가 가변(여러 개)인 함수 : c#에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한 함수를 여러 개 만들 수 있다.
             * 이를 가리켜 함수 중복 또는 함수 오버로드(overload)라고 한다.
             * 
             */

            //두 수의 합을 구하는 함수 작성하기
            // 함수를 사용하여 큰 값과 작은 값, 절대값 구하기
        }

        static void FunctionOverloading()
        {
            /**
             * 함수 오버로드 : 다중 정의
             * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러 개를 정의할 수 있는데 이를 함수 오버로드라고 한다.
             * 우리말로는 여러 번 정의한다는 의미이다.
             */
        }

        //! 숫자를 받아서 출렷하는 함수
        /**
         * @param number int type number of print
         */
        static void GetNumber(int number)
        {
            Console.WriteLine($"int32: {number}");
            Console.WriteLine($"4byte 정수: {number}");
}

        static void GetNumber(long number)
        {
            Console.WriteLine($"int64:{number}");
            Console.WriteLine($"8byte 정수: {number}");
        }


        // 함수 오버로드 매개변수 (empty), (string message), (string message, int count)
        static void Multi()
        {
            Console.WriteLine("안녕하세요");
        }

        static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        static void Multi(string message, int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}", message);
            }
        }

        static void RecursionFunction()
        {
            /**
             * 함수에서 함수 자신을 호출하는 것을 재귀(Recursion) 또는 재귀함수 라고 한다.
             */
        }

        // factorial 구하는 함수

        static int Factorial(int n)
        {
            //탈출조건
            if(n == 0 || n == 1)
            {
                return 1;
            }

            //Console.WriteLine("n의 값은 : {0}", n);      <<n값 변동 상황 출력 할 경우 입력

            return n * Factorial(n-1);    //여기서 재귀 호출
        }

        static void FuctionScope()
        {
            /**
             * 함수 범위 : 전역 변수와 지역 변수
             * 클래스와 같은 레벨에서 선언된 변수를 전역 변수(Global Variable) 또는 필드(Field)라고 하며,
             * 함수 레벨에서 선언된 변수를 지역 변수(Local Variable)라고 한다.
             * 이때 동일한 이름으로 변수를 전역 변수와 함수 내의 지역 변수로 선언할 수 있다. 함수 내에서는 함수 범ㅇ뒤에 있는 지역 변수를 사용하고,
             * 함수 범위 내에 선언된 변수가 없으면 전역 변수 내에 선언된 변수를 사용한다.
             * 단, C#에서는 전역 변수가 아닌 필드라는 단어를 주로 사용하며, 전역 변수는 언더스코어(_) 또는 m_ 접두사를 붙이는 경향이 있다.
             */
        }

        static void ArrowFunction()
        {
            /**
             * 화살표 함수
             * 
             * 화살표 모양의 연산자인 화살표 연산자(=>)를 사용하여 메서드 코드를 줄일 수 있다.
             * 이를 화살표 함수(Arrow function)라고 한다.
             * 프로그래밍에서 화살표 함수 또는 화살표 메서드느 람다 식(Lamda expression)의 도다른 이름이다.
             * 화살표 함수를 사용하면 함수를 줄여서 표현할 수 있다. 함수 고유의 표현을 줄여서 사용하면 처음에는 어색할 수 있지만
             * 이 방식에 익숙해지면 차후에는 코드의 간결함을 유지할 수 있다.
             */
        }

    }
}