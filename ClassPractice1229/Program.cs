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
            Monster monster= new Monster();
            monster.MonsterArray();


            //
            Random random = new Random();
            int incount = random.Next(0, 3);


            bool battleCheck = true;
            while (true)
            {
                Console.WriteLine("플레이어 턴");
                monsters[incount].hp -= player.Offence;
                Console.WriteLine(player.Hp);
                Console.WriteLine(monsters[incount].hp);

                if (monsters[incount].hp <= 0)
                {
                    break;
                }
                Console.ReadKey();

                Console.WriteLine("{0}의 턴", monsters[incount].name);
                player.Hp -= monsters[incount].offence;
                Console.WriteLine(player.Hp);
                Console.WriteLine(monsters[incount].hp);

                if (player.Hp <= 0)
                {
                    break;
                }
                Console.ReadKey();
            }

        }

    }
   


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
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Hp
        {
            get { return this.hp; }
            private set { this.hp = value; }
        }
        public int Offence
        {
            get { return this.offence; }
            private set { this.offence = value; }
        }
        public int Defence
        {
            get { return this.defence; }
            private set { this.defence = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }

        public Player()
        {
            this.name = "Hero";
            this.hp = 100;
            this.offence = 40;
            this.defence = 30;
        }

    }

    class Monster : DefalutValue
    {
        Monster[] monsterArray = new Monster[3];
        Orc orc= new Orc();
        Wolf wolf = new Wolf();
        Slime slime= new Slime();
        public void MonsterArray()
        {
            monsterArray[0] = orc;
            monsterArray[1] = wolf;
            monsterArray[1] = slime;
        }

        public string Array0
        {
            get { return this.monsterArray[0]; }
            private set { this.name = value; }
        }

    }
    
    class Orc : Monster
    {
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Hp
        {
            get { return this.hp; }
            private set { this.hp = value; }
        }
        public int Offence
        {
            get { return this.offence; }
            private set { this.offence = value; }
        }
        public int Defence
        {
            get { return this.defence; }
            private set { this.defence = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }

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
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Hp
        {
            get { return this.hp; }
            private set { this.hp = value; }
        }
        public int Offence
        {
            get { return this.offence; }
            private set { this.offence = value; }
        }
        public int Defence
        {
            get { return this.defence; }
            private set { this.defence = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }
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
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Hp
        {
            get { return this.hp; }
            private set { this.hp = value; }
        }
        public int Offence
        {
            get { return this.offence; }
            private set { this.offence = value; }
        }
        public int Defence
        {
            get { return this.defence; }
            private set { this.defence = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }

        public Wolf()
        {
            this.name = "늑대";
            this.hp = 100;
            this.offence = 7;
            this.defence = 3;
        }
    }




}