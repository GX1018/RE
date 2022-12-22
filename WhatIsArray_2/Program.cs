using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Reflection;

namespace WhatIsArray_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 사용하여 국어 점수의 총점과평균 구하기
            //학생 3명의 점수를 저장하는 배열 선언해서 각 학생별로 점수를 할당하고(범위는 1~100점)
            //모든 점수의 총점과 평균을 구해서 출력하는 프로그램


            //userinput(학생의 점수) 받아서 프로그램 작성
            //userinput은 3회
            //이상한 입력 예외처리

            //int student1 = 0;
            //int student2 = 0;
            //int student3 = 0;

            //int sum = 0;
            //int average = 0;


            //Console.WriteLine("첫번째 학생의 점수를 입력하세요");
            //int.TryParse(Console.ReadLine(), out student1);
            //Console.WriteLine("두번째 학생의 점수를 입력하세요");
            //int.TryParse(Console.ReadLine(), out student2);
            //Console.WriteLine("세번째 학생의 점수를 입력하세요");
            //int.TryParse(Console.ReadLine(), out student3);

            //bool isInteger = student1 >= 0 && student1 <= 100 && student2 >= 0 && student2 <= 100 && student3 >= 0 && student3 <= 100;



            //if (!isInteger)
            //{
            //    Console.WriteLine("다시 입력하세요");
            //}
            //else
            //{

            //    int[] intArray;
            //    intArray = new int[3] { student1, student2, student3 };

            //    sum = intArray[0] + intArray[1] + intArray[2];
            //    Console.WriteLine("총점 {0}", sum);

            //    average = sum / 3;
            //    Console.WriteLine("평균 {0}", average);
           /* }*///***정수 아닌 것 입력했을때 예외 처리하기//



            //LAB1.배열에서 최대값 찾기

            /**
             * 크기가 100인 배열을 1부터 100사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램 작성
             * -보기 좋게 출력
            // */
            //int[] intArray_;
            //intArray_ = new int[100];

            //for (int index = 1; index <= 100; index++)
            //{
            //    int index1 = index - 1;
            //    Random random = new Random();
            //    int input_ = random.Next(1, 100);
            //    intArray_[index1] = input_;
            //    Console.Write("{0}, ", intArray_[index1]);
            //    if(index%10==0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("배열 중 최대값은{0} 입니다.", intArray_.Max());
            //Console.WriteLine();
            //Console.WriteLine();



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
            //int apple = 0;
            //int[] appleArray;
            //appleArray= new int[5];

            //for (int index = 0; index <= 4; index++)
            //{
            //    Console.WriteLine("사과를 몇개 드셨나요?");
            //    int.TryParse(Console.ReadLine(), out apple);
            //    appleArray[index] = apple;
            //}
            //Console.WriteLine();
            //for(int index = 0; index<=4; index++)
            //{
            //    Console.WriteLine("사람{0} :{1}개", index+1, appleArray[index]);
            //}
            //Console.WriteLine("배열 중 최대값은{0} 입니다.", appleArray.Max());

            //
            //

            int apple = 0;
            int[] appleArray;
            appleArray = new int[5];

            for (int index = 0; index <= 4; index++)
            {
                Console.WriteLine("사람{0}\n사과를 몇개 드셨나요?", index+1);
                string input_apple = Console.ReadLine();
                bool check = int.TryParse(input_apple, out apple);
                if (check)
                {
                    appleArray[index] = apple;
                }

                else
                {
                    Console.WriteLine("잘못 입력했습니다.");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("=================입력순============================\n");

            foreach (int output__ in appleArray)
            {
                Console.Write("{0}개 ", output__);
            }
            Console.Write("\n================================================\n");

            Array.Sort(appleArray);
            Array.Reverse(appleArray);

            Console.Write("\n=================내림차순=========================\n");

            foreach (int output__ in appleArray)
            {
                Console.Write("{0}개 ", output__);
            }
            Console.Write("\n================================================\n");

            Console.WriteLine("배열 중 최대값은{0} 입니다.", appleArray.Max());
            Console.WriteLine("배열 중 최소값은{0} 입니다.", appleArray.Min());

            int x = Array.IndexOf(appleArray, appleArray.Max());


            Console.WriteLine("사람\"{0}\"가(이) 가장 많은 사과를 먹었습니다..",
                  appleArray.Max());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            
            Random random1= new Random();
            int ran_input = random1.Next(100, 120);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("먹은 순서대로 나열");
            Console.WriteLine("===============================================================");


            int[] apple_Array;
            apple_Array = new int[ran_input];     //편의상 150으로 설정


            for (int index = 1; index <= ran_input; index++)
            {
                int index1 = index - 1;
                Random random = new Random();
                int input_ = random.Next(0, ran_input);
                apple_Array[index1] = input_;
                Console.Write("{0}개 ", apple_Array[index1]);
                if (index % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            Console.WriteLine("===============================================================");
            Console.WriteLine("======================내림차순 정렬============================");
            Console.WriteLine("===============================================================");
            //Array.Sort(apple_Array);
            
            for(int index =1; index <ran_input; index++)
            {
                for(int index1=0; index1<index; index1++)
                {
                    if (apple_Array[index1] > apple_Array[index])
                    {
                        int temp_space = apple_Array[index1];
                        apple_Array[index1] = apple_Array[index];
                        apple_Array[index] = temp_space;
                    }
                }
            }
            
            
            for (int index = 1; index < ran_input+1; index++)
            {
                int index1=index - 1;
                Console.Write("{0}개 ", apple_Array[index1]);

                if (index % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine("===============================================================");
            Console.WriteLine("===============================================================");

            //중복 제거
            int[] uniqueArr = apple_Array.Distinct().ToArray();
            int a = uniqueArr.GetLength(0);
            for (int index = 1; index < a; index++)
            {
                int index1 = index - 1;
                Console.Write("{0}개 ", uniqueArr[index1]);

                if (index % 10 == 0)
                {
                    Console.WriteLine();
                }
            }


            //foreach (int output1_ in uniqueArr)
            //{
            //    Console.Write("{0}개 ", output1_);
            //}




            //foreach (int print in apple_Array)
            //{
            //    Console.Write("{0}개 ", print);
            //}
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("배열 중 최대값은{0} 입니다.", apple_Array.Max());
            Console.WriteLine();
            Console.WriteLine();

            ///LAB 1,2 코딩 했던 내용 주석 달아서 해석 해서 제출
            ///-미완성인 경우 이해하고 있는 내용까지만이라도 적어서 제출
        }
    }
}