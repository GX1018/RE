using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride
{
    internal class Override
    {
        public void OverrideDesc()
        {
            /**
             * 부모 클래스에 만든 메서드를 자식 클래스에서 다시 새롭게 만들어 사용하는 것을 메서드 오버라이드 라고 한다.
             * 
             * 메서드 오버라이드 : 재정의
             * 
             * 클래스 관계를 다지는 상속 개념에서 부모 클래스에 이미 만든 메서드를 동일한 이름으로 자식 클래스에서 다시 정의(재정의)해서
             * 사용한다는 개념이 메서드 오버라이드 라고 한다
             * 
             * -메서드 오버라이드는 메서드를 새롭게 정의하는 것
             * - 오버라이드, 오버라이딩이라는 표현은 동일하다.
             * - 부모 클래스에 virtual 키워드로 선언해 놓은 메서드는 자식 클래스에서 override 키워드로 재정의해서 사용 가능하다.
             * 
             * 
             * 메서드 오버로드와 오버라이드
             * 
             * 처음 프로그래밍 할 때 쉽게 혼동하는 단어가 바로 오버로드(Overload)와 오버라이드(Override)이다.
             * 오버로드는 '여러번' 정의하는 것이고, 오버라이드는 '다시' 정의하는 것이다.
             * 
             * 
             * 가상 메서드
             * 메서드 오버라이드는 다른 표현방식으로 가상(virtual) 메서드라고 한다.
             * 
             */
        }

        public void PropertyDesc()
        {
            /**
             * 속성은 필드 값을 읽거나 쓰고 계산하는 방법을 제공하는 클래스 속성을 나타내는 멤버이다.
             * 아주 간단하게 클래스 속성을 변경하거나 알아보는 기능을 배워보자.
             * 
             * 속성
             * 클래스의 멤버 중에서 속성(property)은 단어 그대로 클래스 속성(특징, 성격, 색상, 크기 등)을 나타낸다.
             * 속성은 가로가 없는 메서드와 비슷하고 개체 필드 중에서 외부에 공개 하고자 할때 사용하는 방법이다.
             * 개체의 성질, 특징, 색상, 크기, 모양 등을 속성으로 외부에 공개할 수 있다.
             * 코드에서는 private 성격이 있는 필드를 public 속성으로 외부에 공개할 때 사용한다.
             * 
             * 클래스 안에 선언된 필드 내용을 설정(set)하거나 참조(get)할 때 사용하는 코드 블록을 속성이라고 한다.
             * 자동차 객체로 비유하자면, 빨간색, 스포츠카, 바퀴 4개 등으로 속성을 표현할 수 있다.
             * 
             * 
             * class [클래스이름]
             * {
             *      public [리턴타입][속성이름]{get; set;}
             * }
             */
        }

    }

    public class Parent
    {
        protected int number = 100;
        public virtual void Say()
        {
            Console.WriteLine("[부모] 안녕하세요.");
        }
        public virtual void Run() 
        {
            Console.WriteLine("[부모] 달리다.");
        }
        public virtual void Walk()                          //
        {                                                   //
            Console.WriteLine("[부모] 걷다.");               //
        }                                                   //
                                                            //
        public virtual void Walk(int count)                 //
        {                                                   //  Overload
            Console.WriteLine("[부모] {0}번 걷다.");         //  같은 함수(?)에 다른 인자를 넣어 여러 번 정의 하는 것
        }                                                   //
                                                            //
        public virtual void Walk(string where_)             //
        {                                                   //
            Console.WriteLine("[부모] {0}에서 걷다.");       //
        }
    }   //class parent

    public class Child : Parent
    {
        public override void Say()
        {
            Console.WriteLine("[자식] 안녕하세요");
        }
        public override void Run()
        {
            base.Run();
            this.number = 10;
            Console.WriteLine("number : {0}", this.number);
        }

        public override void Walk()                                 //
        {                                                           //
            Console.WriteLine("[자식] 걷다.");                       //
        }                                                           //
                                                                    //
        public override void Walk(int count)                        //  Override
        {                                                           //  부모 클래스에서 정의한 함수를 자식 함수에서 재 정의하는것
            Console.WriteLine("[자식] {0}번 걷다");                  //
        }                                                           //
        public override void Walk(string where)                     //
        {                                                           //
            Console.WriteLine("[자식] {0}에서 걷다");                //
        }
    }

    public class Button
    {
        protected int _index = 0;
        public virtual void OnClickButton()
        {
            Console.WriteLine("{0}번 버튼을 눌렀음", _index);
        }
    }

    public class StoreButton : Button
    {
        public override void OnClickButton()
        {
            _index = 1;
            base.OnClickButton();

            Console.WriteLine("이 버튼을 누르면 상점 창이 열림", _index);
        }
    }

    public class QuestButton : Button
    {

        public override void OnClickButton()
        {
            _index= 2;
            base.OnClickButton();

            Console.WriteLine("이 버튼을 누르면 퀘스트 창이 열림", _index);
        }
    }
}
