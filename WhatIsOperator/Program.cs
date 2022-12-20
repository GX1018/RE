using System;

namespace WhatIsOperator
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    string stringBinary = Convert.ToString(10, 2);
        //    Console.WriteLine(stringBinary);
        //    int intBinary = Convert.ToInt32("0111", 2);
        //    Console.WriteLine(intBinary);

        //    /**
        //     * 연산자
        //     * 데이터로 연산 작업을 수행할 때 연산자(Operator)를 사용한다.
        //     * 기능에 다라 대입, 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나누며 이용 형태에 따라 항 1개로 연산을 하는
        //     * 단항(Unary) 연산자와 2개의 항으로 연산을 하는 이항(Binary)연산자, 항 3개로 연산을 하는 삼항(Ternary)연산자로 나눈다.
        //     * 
        //     * 단항 연산자
        //     * 단항 연산자는 연산자와 피연산자 하나로 식을 처리
        //     * ex) [연산자][피연산자]
        //     * +연산자 : 특정 정수형 변수 값을 그대로 출력
        //     * -연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력. 음수 값이 들어 있다면 양수로 변환
        //     * 
        //     * 이항 연산자
        //     * 이항 연산자는 연산자와 피연산자 2개로 식을 처리
        //     * ex) [피연산자1][연산자][피연산자2]
        //     * 
        //     * 삼항 연산자
        //     * 삼항 연산자는 식 1개의 항(Expression)과 그 결과에 따른 피연산자 각 1갰기 총 2개 항으로 식을 처리
        //     * ex) (식) ? 피연산자1 : 피연산자2
        //     * 
        //     * 식과 문
        //     * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(expression) 또는 표현식이라고 한다. ex) 3 + 5
        //     * 표현식을 사용하여 명령 하나를 진행하는 구문을 문(statement) 또는 문장이라 한다. ex ) x = 3 + 5;
        //     */

        //    //단항 연산자

        //        const int PLUS_FIVE = +5;
        //        const int MINUS_FIVE = -5;


        //    //이항 연산자
        //    const int PLUS_TEN = 5 + 5;

        //    //삼항 연산자
        //    string compareTen = (PLUS_FIVE > 10) ? "{0}은(는) 10보다 크다" : "{0}은(는) 10보다 크지 않다";
        //    Console.WriteLine(compareTen, PLUS_FIVE);


        //    //변환 연산자
        //    //()기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.
        //    const int PI_INT = (int)3.141592;
        //    const float PI_FLOAT = (float)3.141592;

        //    Console.WriteLine("PI_INT: {0}, PI_FLOAT: {1}", PI_INT, PI_FLOAT);

        //    /**
        //     * 산술 연산자
        //     * 더하기(Add), 빼기(subtract), 곱하기(Muliply), 나누기(Divided), 나머지(Remainder, Modules)등
        //     * 수학적 연산을 하는 데 사용한다. 보통 정수 형식과 실수 형식의 산술 연산에 사용
        //     * ex) +, -, *, /, %
        //     * 
        //     * 문자열 연결 연산자
        //     * 산술 연산자 중 하나인 +연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연사을 수행
        //     * 
        //     * +연산자 : 두 항이 숫자일대는 산술(+)연산 가능, 문자열일 때는 문자열 연결 가능
        //     */

        //    string addMessage = "string " + "plus " + "string";
        //    Console.WriteLine(addMessage);

        //    /**
        //     * 할당 연산자
        //     * 할당연산자(Assignment operator)는 변수에 데이터를 대입하는 데 사용.
        //     * 할당 연산자를 대입 연산자 라고도 한다.
        //     * C#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에 할당하라고 지시하는 것
        //     * ex) =, +=, -=, *=, /=, %=
        //     * 
        //     * 증감연산자(Increment / Decrement Operator)
        //     * 변수 값을 1 증가시키거나 1감소시키는 연산자
        //     * 증감 연산자가 변수 앞에 위치하느냐, 뒤에 위치하느냐에 따라 연산 처리 우선순위가 결정.
        //     * 
        //     * ++(증감 연산자) : 변수 값에 1을 더한다.
        //     * --(감소 연산자) : 변수 값에 1을 뺀다.
        //     * 
        //     * 증감연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후위 증감 연산자라고 한다.
        //     * 
        //     * 전위(Prefix) 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을 수행 ex) ++a;
        //     * 후위(postfix) 증감 연산자 : 정수형 변수 뒤에 연산자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에 변수 값을 증감 ex) a++;
        //     */

        //    int number1 = 3;
        //    Console.WriteLine(number1++);  //3
        //    Console.WriteLine(number1);    //4

        //    int number = 0;
        //    number++;
        //    Console.WriteLine(number);

        //    /**
        //     * 관계형 연산자
        //     * 관계형 연산자(relational operator) 또는 비교 연산자(comparative operator)는 두 항이 큰지, 작은지 또는 같은지 등을 비교하는 데 사용
        //     * 관계형 연산자의 결과값은 논리 데이터 형식인 참(True) 또는 거짓(False)으로 출력
        //     * ex) <, <=, >, >=, ==,!= (https://thebook.io/006890/part02/ch11/01/)
        //     * 
        //     * 논리 연산자
        //     * 논리 연산자(logical operator)는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을 수행
        //     * 연산의 결과 값은 참(True) 또는 거짓(False)의 bool 형식으로 반환되어 Boolean(불리언) 연산자라고도 한다.
        //     * ex) &&, ||, ! (https://thebook.io/006890/part02/ch11/02/)
        //     * 
        //     * 비트 연산자
        //     * 비트 연산자(bit operator)는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용
        //     * ex) &, +, ^, ~ (https://thebook.io/006890/part02/ch12/01/)
        //     * 
        //     * 시프트 연산자
        //     * 시프트 연산자(shift operator)는 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽(<<) 또는 오른쪽( >>)으로 지정한 비트만큼 이동시킨다.
        //     * ex) <<, >> (https://thebook.io/006890/part02/ch12/02/)
        //     * 
        //     * 조건 연산자
        //     * 조건 연산자(conditional operator)는 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환하며, 
        //     * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자이다. if~else문의 축약형이기도 하다. (https://thebook.io/006890/part02/ch12/03/)
        //     * 
        //    // * 
        //    // */
        //    //bool isBigger = false;
        //    //isBigger = (5 == 10) && (5 < 10);
        //    //Console.WriteLine(isBigger);    //false

        //    //isBigger = (5 == 10) || (5 < 10);
        //    //Console.WriteLine(isBigger);    //true

        //    //int bitNumber = 10;
        //    //int bitResult = 0;
        //    //bitResult = bitNumber << 1;
        //    //Console.WriteLine(bitResult);

        //    ///**
        //    // * 나열(콤마) 연산자
        //    // * 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용
        //    // */

        //    //int intnumber1, intnumber2, intnumber3;

        //    ///**
        //    // * sizeof 연산자
        //    // * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다.
        //    // * sizeof([데이터 타입]) 형태로 사용하며, 운영 제제의 CPU 아키텍쳐 종류에 따라 결과값이 다르게 나올 수 있다.
        //    // */

        //    //Console.WriteLine("int의 메모리 크기는 {0}바이트 입니다.", sizeof(Int32));

        //    ///**
        //    // * 연산자 우선순위
        //    // * 연산자 여러개를 함께 사용할 때는 연산자 우선순위(Precedence)에 따라 계산된다.
        //    // * 연산자 우선순위를 잘 모를 때는 일단 괄호 연산자부터 잘 사용하도록 연습하는게 좋다.
        //    // * 
        //    // * 
        //    // */

        //    ///**사용자에게 주어 동사 목적어를 각각 물어보고 이것들을 합하여 (주어 + 동사 +목적어) 형태로 출력하는 프로그램을 작성해보자.
        //    // * 주어 I 동사 have 목적어 book -> i have a book
        //    // */

        //    //Console.Write("주어: ");
        //    //string sub = Console.ReadLine();
        //    //Console.Write("동사: ");
        //    //string verb = Console.ReadLine();
        //    //Console.Write("목적어: ");
        //    //string obj = Console.ReadLine();

        //    //Console.WriteLine("{0} {1} a {2}", sub, verb, obj);


        //    ////사용자의 나이를 물어보고 10년뒤에 몇 살이 되는지 출력하는 프로그램을 작성

        //    //Console.Write("나이를 입력하시오: ");
        //    //string age = Console.ReadLine();
        //    //int intnumberx = default;
        //    //int.TryParse(age, out intnumberx);
        //    //Console.WriteLine("10년 후에는 {0}살이 됩니다.", intnumberx + 10);





        //    ////직각 삼각형의 양변 길이를 읽어서 빗변의 길이를 계산하는 프로그램을 작성

            
        //    //int lengthx = 3;
        //    //int lengthy = 4;
        //    //var sqrt_test = Math.Sqrt(lengthx * lengthx + lengthy * lengthy);

        //    //Console.WriteLine(sqrt_test);


        //    /**
        //     * 상자의 길이 너비 높이 입력하라는 메세지 표시,
        //     * 부피와 표면적 계산해서 출력
        //     * 길이 3 너비 4 높이 5
        //     * 부피?
        //     * 표면적
        //     */
        //    Console.Write("상자의 길이: ");
        //    string lengthBox = Console.ReadLine();
        //    int intNumber1 = default;
        //    int.TryParse(lengthBox, out intNumber1);

        //    Console.Write("상자의 너비: ");
        //    string wideBox = Console.ReadLine();
        //    int intNumber2 = default;
        //    int.TryParse(wideBox, out intNumber2);

        //    Console.Write("상자의 높이: ");
        //    string heightBox = Console.ReadLine();
        //    int intNumber3 = default;
        //    int.TryParse(heightBox, out intNumber3);

        //    int volumeBox = intNumber1 * intNumber2 * intNumber3;
        //    int surfaceBox = 2*intNumber1* intNumber2+2*intNumber2*intNumber3+2*intNumber3*intNumber1;
        //    Console.WriteLine("상자의 부피 = {0} \n상자의 표면적 = {1}", volumeBox, surfaceBox);
            

        //    /**우리나라에서 많이 사용되는 면적의 단위인 평을 평방미터로 환산
        //     * 평 25
        //     * 평방미터
        //     */

        //    const float ONE_PYUNG = 3.3058F;
        //    float userInput = 0.0F;

        //    Console.Write("평: ");
        //    float.TryParse(Console.ReadLine(), out userInput);

        //    Console.WriteLine("평방미터: {0}", userInput * ONE_PYUNG);


        //    /**
        //     * 시 분 초로 표현된 시간을 초 단위의 시간으로 변환
        //     * 시 :1 분 : 1초 :1
        //     * 전체 초 :
        //     */

        //    Console.Write("시: ");
        //    string hour = Console.ReadLine();
        //    int intNumber4 = default;
        //    int.TryParse(hour, out intNumber4);
        //    Console.Write("분: ");
        //    string minute = Console.ReadLine();
        //    int intNumber5 = default;
        //    int.TryParse(minute, out intNumber5);
        //    Console.Write("초: ");
        //    string second = Console.ReadLine();
        //    int intNumber6 = default;
        //    int.TryParse(second, out intNumber6);

        //    int time_second = 3600* intNumber4 + 60*intNumber5 + intNumber6;

        //    Console.WriteLine("시/분/초를 초 단위로 변환하면 : {0}초", time_second);

        //    /**
        //     * 퀴즈 중간고사 기말고사 성적을 사용자로부터 입력받아 성적 총합 계산
        //     * 
        //     * 퀴즈 #1 성적 : 10
        //     * 퀴즈 #2 성적 : 20
        //     * 퀴즈 #3 성적 : 30
        //     * 증간고사 : 80
        //     * 기말고사 : 80
        //     */

        //    Console.Write("퀴즈 #1 성적: ");
        //    string quiz_one = Console.ReadLine();
        //    int intNumber7 = default;
        //    int.TryParse(quiz_one, out intNumber7);

        //    Console.Write("퀴즈 #2 성적: ");
        //    string quiz_two = Console.ReadLine();
        //    int intNumber8 = default;
        //    int.TryParse(quiz_two, out intNumber8);

        //    Console.Write("퀴즈 #3 성적: ");
        //    string quiz_three = Console.ReadLine();
        //    int intNumber9 = default;
        //    int.TryParse(quiz_two, out intNumber9);

        //    Console.Write("중간고사 성적: ");
        //    string mid_exam = Console.ReadLine();
        //    int intNumber10 = default;
        //    int.TryParse(mid_exam, out intNumber10);

        //    Console.Write("기말고사 성적: ");
        //    string final_exam = Console.ReadLine();
        //    int intNumber11 = default;
        //    int.TryParse(final_exam, out intNumber11);

        //    int total_record = intNumber7 + intNumber8 + intNumber9 + intNumber10 + intNumber11;

        //    Console.Write("성적 총 합계: {0}", total_record);

        //    /**
        //     * 
        //     */





        //}
    }
}