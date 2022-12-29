using System;

namespace WhatIsClass
{
    internal class Exercise2
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Slime slime= new Slime();

            hero.PlayerMoveAndAttack();
            Console.WriteLine("{0}", hero);
        }
        class Player
        {
            protected string name;
            protected int hp;
            protected int damage;
            protected int defence;

            protected void Move(string name)
            {
                Console.WriteLine("{0}가 움직인다", name);
            }
            protected void Attack(string name, int damage)
            {
                Console.WriteLine("{0}가 {1}의 공격력으로 공격했다", name, damage);
            }
            public void PlayerMoveAndAttack()
            {
                this.Move(this.name);
                this.Attack(this.name, this.damage);
            }
        }

        class Hero : Player
        {
            public Hero()
            {
                this.name = "용사";
                this.hp = 300;
                this.damage = 50;
                this.defence = 30;
            }

        }

        class Monster
        {
            protected string name;
            protected int hp;
            protected int damage;
            protected int defence;

            protected void Move(string name)
            {
                Console.WriteLine("{0}가 움직인다", name);
            }
            protected void Attack(string name, int damage)
            {
                Console.WriteLine("{0}가 {1}의 공격력으로 공격했다", name, damage);
            }
            public void MonsterMoveAndAttack()
            {
                this.Move(this.name);
                this.Attack(this.name, this.damage);
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                this.name = "푸른 슬라임";
                this.hp = 100;
                this.damage = 10;
                this.defence = 5;
            }
        }

        class Wolf : Monster
        {
            public Wolf()
            {
                this.name = "늑대";
                this.hp = 200;
                this.damage = 15;
                this.defence = 8;
            }
        }
    }
}

