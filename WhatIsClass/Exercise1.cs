using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WhatIsClass
{
        class DefalutValue
        {
            protected string name;
            protected int hp;
            protected int offence;
            protected int defence;
            protected int damage;
        }

        

        class Player : DefalutValue
        {
            public Player()
            {
                this.name = "Player";
                this.hp = 100;
                this.offence = 40;
                this.defence = 30;
            }
            
        }

        class Monster : DefalutValue
        {

        }
        class Orc : Monster
        {
            public Orc()
            {
                this.name = "오크";
                this.hp = 200;
                this.offence = 20;
                this.defence = 15;
            }
        }
        class Slime : Monster
    {
            public Slime()
            {
                this.name = "슬라임";
                this.hp = 80;
                this.offence = 5;
                this.defence = 2;
            }
        }

        class Wolf : Monster
    {
            public Wolf()
            {
                this.name = "늑대";
                this.hp = 100;
                this.offence = 7;
                this.defence = 3;
            }
        }



    class ActionPhase
    {

        public void ActionSellect()
        {
            Console.WriteLine("다음 행동을 선택하세요.\n [1] 전투\n [2] 회복");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Battle();
                    break;
                case 2:
                    Restore();
                    break;
                default:
                    break;
            }
        }

        public void Battle()
        {
            Random random= new Random();
            int incount = random.Next(0,3);
            Battle(incount);
        }


        public void Battle(int i)
        {
            
            
        }

        public void Battle(string arrayname, int number) 
        {
            
        }

        public void Restore()
        {

        }
    }


    



        //public void Battle(string name)
        //{
        //    Console.WriteLine("{0}와 전투 시작", name);
        //    int action = int.Parse(Console.ReadLine());
        //    if (action == 1)
        //    {
                
        //    }
        //    else
        //    {
        //        //방어
        //    }

            //몬스터 공격 실행

        }


        /*public void Incount()
        {

        }*/

    

