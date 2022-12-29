using System;
using System.Numerics;

namespace ClassPractice1229
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Player player = new Player();
            Orc orc = new Orc();
            Slime slime = new Slime();
            Wolf wolf = new Wolf();

            DefalutValue[] monsters = { slime, orc, wolf };

            //
            Random random = new Random();
            int incount = random.Next(0, 3);

            Battle(player, monsters[incount]);

            //bool battleCheck = true;
            //while (true)
            //{
            //    Console.WriteLine("플레이어 턴");
            //    monsters[incount].hp -= player.offence;
            //    Console.WriteLine(player.hp);
            //    Console.WriteLine(monsters[incount].hp);

            //    if (monsters[incount].hp <= 0)
            //    {
            //        break;
            //    }
            //    Console.ReadKey();

            //    Console.WriteLine("{0}의 턴", monsters[incount]);
            //    player.hp -= monsters[incount].offence;
            //    Console.WriteLine(player.hp);
            //    Console.WriteLine(monsters[incount].hp);

            //    if (player.hp <= 0)
            //    {
            //        break;
            //    }
            //    Console.ReadKey();
            //}
            //
        }
        public void Battle(Player player, DefalutValue defalutValue)
        {
            bool battleCheck = true;
            while (true)
            {
                Console.WriteLine("플레이어 턴");
                p2.hp -= p1.offence;
                Console.WriteLine(p1.hp);
                Console.WriteLine(p2.hp);

                if (p2.hp <= 0)
                {
                    break;
                }
                Console.ReadKey();

                Console.WriteLine("{0}의 턴", p2.name);
                p1.hp -= p2.offence;
                Console.WriteLine(p1.hp);
                Console.WriteLine(p2.hp);

                if (p1.hp <= 0)
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
   


    class DefalutValue
    {
        public string name;
        public int hp;
        public int offence;
        public int defence;
        public int damage;
    }

    class Player : DefalutValue
    {
        public Player()
        {
            this.name = "Hero";
            this.hp = 100;
            this.offence = 40;
            this.defence = 30;
        }

    }

    
    class Orc : DefalutValue
    {
        public Orc()
        {
            this.name = "오크";
            this.hp = 200;
            this.offence = 20;
            this.defence = 15;
        }
    }
    class Slime : DefalutValue
    {
        public Slime()
        {
            this.name = "슬라임";
            this.hp = 80;
            this.offence = 5;
            this.defence = 2;
        }
    }
    class Wolf : DefalutValue
    {
        public Wolf()
        {
            this.name = "늑대";
            this.hp = 100;
            this.offence = 7;
            this.defence = 3;
        }
    }




}