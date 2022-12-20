namespace report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * LAB1
             */

            char userInput;             //변수 선언,        유저가 입력하는 변수
            int vowel = 0;              //변수 선언,초기화  모음의 수를 count하기 위한 변수
            int consonant = 0;          //변수 선언,초기화  자음의 수를 count하기 위한 변수

            while (true)    //무한 루프 설정
            {
                Console.WriteLine("알파벳을 입력하세요.\n종료하시려면 . 버튼을 눌러주세요");   //입력 안내문 출력
                char.TryParse(Console.ReadLine(), out userInput);   //입력한 문자열을 char 형태로 변환
                if (userInput == '.')
                    break;                  //입력값이 . 일때 루프 종료
                if (('a' <= userInput && userInput <= 'z') || ('A' <= userInput && userInput <= 'Z'))     //입력한 값이 알파벳인지 확인
                {
                    switch (userInput)
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
                        case 'U':       //모음을 입력했을때
                            vowel++;    //모음 수 추가
                            break;
                        default:        //모음이 아닌 알파벳을 입력했을때
                            consonant++;//자음 수 추가
                            break;
                    }
                }
                else  //알파벳을 입력하지 않았을때
                {
                    Console.WriteLine("알파벳이 아닙니다 다시 입력해주세요.");  //안내 문구 출력
                }
            }
            Console.WriteLine("자음 개수: {0}", consonant);     //입력한 자음 개수 출력
            Console.WriteLine("모음 개수: {0}", vowel);         //입력한 모음 개수 출력

            /**
             * LAB2
             */

            Random randomLab2 = new Random();
            int computer = randomLab2.Next(100) + 1;    //변수 선언, 초기화(1~100까지의 난수)
            int user_input = 0;     //변수 선언, 초기화(유저 입력 값)
            while (true)    //루프 설정
            {
                Console.WriteLine("1에서 100사이의 수를 입력하세요.");  //입력에 대한 안내 문자열 출력
                int.TryParse(Console.ReadLine(), out user_input);   //입력한 값을 int형태로 변환
                if (user_input == computer)
                {
                    Console.WriteLine("정답입니다.");
                    break;                              //입력한 값이 생성된 난수 값과 같으면 문자열 출력 후 루프 종료
                }

                if (user_input > computer)
                {
                    Console.WriteLine("더 작습니다.");   //입력한 값이 생성된 난수 값보다 크면 문구 출력 후 루프
                }
                else
                {
                    Console.WriteLine("더 큽니다.");    //입력한 값이 생성된 난수 값보다 작으면 문구 출력 후 루프
                }
            }

            /**
             * LAB3
             */

            Random random = new Random();
            float ran_num1 = random.Next(100);  //첫번째 피연산자 선언, 초기화(0~99까지의 난수)
            float ran_num2 = random.Next(100);  //두번째 피연산자 선언, 초기화(0~99까지의 난수)
            float userInputLab3 = 0; //변수 선언, 초기화(유저가 입력하는 값)

            Console.WriteLine("{0}+{1}의 값은? :", ran_num1, ran_num2);    //수식(덧셈)에 대한 설명 출력
            while (true)    //루프 설정
            {
                Console.WriteLine("정답 입력: ");   //입력 안내문 출력
                float.TryParse(Console.ReadLine(), out userInputLab3);  //입력값을 float형태로 변환
                float question1 = ran_num1 + ran_num2;  //변수 선언 ,초기화(덧셈)
                if (userInputLab3 == question1)
                {
                    Console.WriteLine("정답입니다.");
                    break;                              //입력한 값이 question1값과 같을때 문자열 출력, 루프 종료
                }
                else
                {
                    Console.WriteLine("오답입니다.");    //같지 않으면 문구 출력 후 루프
                }
            }

            Console.WriteLine("{0}x{1}의 값은? :", ran_num1, ran_num2);    //수식(곱셈)에 대한 설명 출력
            while (true)    //루프 설정
            {
                Console.WriteLine("정답 입력: ");   //입력 안내문 출력
                float.TryParse(Console.ReadLine(), out userInputLab3);  //입력값을 float형태로 변환
                float question2 = ran_num1 * ran_num2;  //변수 선언 ,초기화(곱셈)
                if (userInputLab3 == question2)
                {
                    Console.WriteLine("정답입니다.");
                    break;                              //입력한 값이 question2값과 같을때 문자열 출력, 루프 종료
                }
                else
                {
                    Console.WriteLine("오답입니다.");    //같지 않으면 문구 출력 후 루프
                }
            }

            Console.WriteLine("{0}-{1}의 값은? :", ran_num1, ran_num2);    //수식(뺄셈)에 대한 설명 출력
            while (true)    //루프 설정
            {
                Console.WriteLine("정답 입력: ");   //입력 안내문 출력
                float.TryParse(Console.ReadLine(), out userInputLab3);  //입력값을 float형태로 변환
                float question3 = ran_num1 - ran_num2;  //변수 선언 ,초기화(뺄셈)
                if (userInputLab3 == question3)
                {
                    Console.WriteLine("정답입니다.");
                    break;                              //입력한 값이 question1값과 같을때 문자열 출력, 루프 종료
                }
                else
                {
                    Console.WriteLine("오답입니다.");    //같지 않으면 문구 출력 후 루프
                }
            }


            while (true)    //루프 설정
            {
                Console.WriteLine("{0}/{1}의 값은? :", ran_num1, ran_num2);    //수식(나눗셈)에 대한 설명 출력
                Console.WriteLine("정답 입력: ");   //입력 안내문 출력
                float.TryParse(Console.ReadLine(), out userInputLab3);  //입력값을 float형태로 변환
                float question4 = ran_num1 / ran_num2;  //변수 선언 ,초기화(나눗셈)
                float question4_1 = 0;
                float.TryParse(String.Format("{0:0.00}", question4), out question4_1);  //나눗셈 출력 값 조정(소수점 2번째까지 출력)
                if (ran_num2 == 0)
                {
                    Console.WriteLine("분모가 잘못 설정되었습니다.");
                    ran_num2 = random.Next(100);      //분모의 값에 0이 입력되었을때 문자열 출력과 분모값 리롤 이후 루프
                }
                if (userInputLab3 == question4_1)
                {
                    Console.WriteLine("정답입니다.");
                    break;                              //입력한 값이 question1값과 같을때 문자열 출력, 루프 종료
                }
                else
                {
                    Console.WriteLine("오답입니다.");    //같지 않으면 문구 출력 후 루프
                }
            }

        }
    }
}