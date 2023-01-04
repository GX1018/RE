using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsParameter
{
    internal class Description
    {
        public void ParameterDesc()
        {
            /**
             * 매서드의 매개변수 전달 방식
             * 매서드의 매개변수 전달 방식은 사용하는 방식에 따라 네가지로 분류한다.
             * 지금까지 기본으로 사용한 매개변수 전달 방식은 값 전달 방식이다.
             * 이에 추가해서 ref 키워드를 사용하는 참조형 전달 방식과 out 키워드를 사용하는 반환형 전달 방식, 마지막으로 params키워드를 사용하는 가변형 전달방식이 있다.
             * 
             * - 값 전달 방식 : 말 그대로 값을 그대로 복사해서 전달하는 방식을 의미한다. 지금까지 사용해왔던 매개변수 방식이다.
             * 
             * - 참조 전달 방식 : 실제 데이터는 매개변수가선언된 족에서만 저장하고 호출된 메소드에서는 참조만 하고 변수 이름만 전달하는 방식이다.
             * 
             * - 반환형 전달 방식 : 메소드를 호출하는 쪽에서 선언만 하고 초기화하지 않고 전달하면 메서드 쪽에서 해당 데이터를 초기화해서 넘겨주는 방식이다.
             * 
             * - 가변형 전달 방식(params) : 한개 이상의 항에 매개변수를 가변적으로 받을때 매개변수를 선언하면 params키워드를 준다. 가변적이라는 것은 같은 타입으로 하나 이상을 받을수 있도록 배열형으로 받는다는 의미이다.
             *   가변길이 매개변수는 반드시 매개변수를 선언할 때 마지막에 위치해야 한다.
             * 
             */
        }

        public void ValueTypeParam(int firstNumber, int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("1st{0} 2nd{1}",firstNumber,secondNumber);
        }

        public void RefTypeParam(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("1st{0} 2nd{1}", firstNumber, secondNumber);
        }

        public void OutTypeParam(out int number)
        {
            number = 10;
        }

        public void FlexibleTypeParam(params int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }

    }
}
