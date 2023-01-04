using System;

namespace WhatIsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Description desc = new Description();
            int number1 = 10;
            int number2 = 20;

            desc.ValueTypeParam(number1,number2);
            Console.WriteLine("1st{0} 2nd{1}", number1, number2);
            //값타입 매개변수 전달 ==== 함수 내에서 값 변동, but 원본변수는 변동x

            desc.RefTypeParam(ref number1,ref number2);
            Console.WriteLine("1st{0} 2nd{1}", number1, number2);
            //참조타입 매개변수 전달 ==== 함수 내에서 값 변동 & 원본변수도 변동


            //반환형 전달 방식
            int number;
            desc.OutTypeParam(out number);
            Console.WriteLine("[main]number : {0}",number);

            //++
            string strNumber = "100";
            int intNumber;
            int.TryParse(strNumber, out intNumber);


            //가변형 전달 방식

            desc.FlexibleTypeParam(1, 2, 3, 10, 40, 100, 111, 123);

        }
    }
}