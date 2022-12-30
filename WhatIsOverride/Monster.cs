using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride
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
        public string Name
        {
            get { return this.name; }
            
            private set { this.name = value; }
        }
        
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
