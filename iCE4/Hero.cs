using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCE4
{
    public abstract class Hero
    {
        protected int hp;
        protected int atk;
        protected int crit;
        protected int def;
        private int type;
        protected string name;
        protected string battleCry;
        public Random r = new Random();

        public int Hp { get => hp; set => hp = value; }
        public int Atk { get => atk; set => atk = value; }
        public int Crit { get => crit; set => crit = value; }
        public int Def { get => crit; set => crit = value; }

        public string Name { get => name; set => name = value; }
        public string BattleCry { get => battleCry; set => battleCry = value; }
        public int Type { get => type; set => type = value; }

        public Hero(int hp,int atk,int crit,int def ,string name,string battleCry,int type)
        {
            this.Hp = hp;
            this.Atk = atk;
            this.Crit = crit;
            this.Def = def;
            this.Name = name;
            this.BattleCry = battleCry;
            this.Type = type;
        }

        public int AskHP()
        {
            Console.WriteLine("Enter Hp");
            int hp = Int32.Parse(Console.ReadLine());
            return hp;
        }

        public int AskAtk()
        {
            Console.WriteLine("Enter Atk");
            int atk = Int32.Parse(Console.ReadLine());
            return atk;
        }

        public int AskCrit()
        {
            Console.WriteLine("Enter Crit");
            int crit = Int32.Parse(Console.ReadLine());
            return crit;
        }

        public int AskDef()
        {
            Console.WriteLine("Enter def");
            int def = Int32.Parse(Console.ReadLine());
            return def;
        }

        public string AskName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            return name;
        }
        public string AskBattleCry()
        {
            Console.WriteLine("Enter BattleCry");
            string cry= Console.ReadLine();
            return cry;
        }

        public void createHero()
        {
            Boolean condition = false;
            while (condition == false)
            {
                try
                {
                    this.Name = AskName();
                    this.Hp = AskHP();
                    this.Atk = AskAtk();
                    this.Def = AskDef();
                    this.Crit = AskCrit();
                    this.BattleCry = AskBattleCry();
                    condition = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid information, please reenter information from the start again.");
                    condition = false;
                }
              }
        }
        public void Display()
        {
            string typeHero = "" + GetType();
            typeHero = typeHero.Remove(0,5);
            Console.WriteLine("Name: "+Name+" the "+typeHero);
            Console.WriteLine("Atk: " + Atk);
            Console.WriteLine("Def:" + Def);
            Console.WriteLine("Crit: "+Crit);

            Console.WriteLine("BattelCry: " + BattleCry);

            Console.WriteLine("_______________________________________________________________________");
                

        }
        public override string ToString()
        {
            

            return (this.hp+","+this.Atk+","+this.Def+","+this.Crit+","+this.name+","+this.BattleCry+","+this.Type);
        
        }
    }
}
