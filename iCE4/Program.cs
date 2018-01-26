using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iCE4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the character creator");
            SaveFileCreate();
            int classHero = HeroStart();
            switch (classHero)
            {

                case 1:
                    Hero rouge = new Rogue(0,0,0,0,"","",1);
                    rouge.createHero();
                    rouge.Display();
                    WriteToFile(rouge);
                    break;
                case 2:
                    Hero templar = new Templar(0, 0, 0, 0, "", "",2);
                    templar.createHero();
                    templar.Display();
                    WriteToFile(templar);
                    break;
                case 3:
                    Hero shaman = new Shaman(0, 0, 0, 0, "", "",3);
                    shaman.createHero();
                    shaman.Display();
                    WriteToFile(shaman);
                    break;
                case 4:
                    Hero wizard = new Wizard(0, 0, 0, 0, "", "",4);
                    wizard.createHero();
                    wizard.Display();
                    WriteToFile(wizard);
                    break;
                case 5:
                    Hero barb = new Barbarian(0, 0, 0, 0, "", "",5);
                    barb.createHero();
                    barb.Display();
                    WriteToFile(barb);
                    break;
                case 6:
                    Hero monk = new Monk(0, 0, 0, 0, "", "",6);
                    monk.createHero();
                    monk.Display();
                    WriteToFile(monk);
                    break;

            }
        }
        public static void SaveFileCreate()
        {
            if (!Directory.Exists("SAVES"))
            {
                Console.WriteLine("BAttleFiled is Empty");
                Directory.CreateDirectory("SAVES");
                Console.WriteLine("SAVES Directory created");
                
            }


            if (File.Exists("SAVES/saves.file") != true)
            {
                Console.WriteLine("Directory exists");
                File.Create("SAVES/saves.file").Close();
                Console.WriteLine("file created");
            }

        }

        public static void WriteToFile(Hero hero)
        {
            FileStream file = new FileStream("SAVES/saves.file", FileMode.Open, FileAccess.ReadWrite);

            StreamWriter write = new StreamWriter(file);
            StreamReader reader = new StreamReader(file);

            if (file.Length != 0)
            {
                Console.WriteLine("Battlefield Contains: ");
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] heroArr = line.Split(',');
                    switch (Int32.Parse(heroArr[6]))
                {
                        case 1:
                            Hero oldRogue = new Rogue(Int32.Parse(heroArr[0]), Int32.Parse(heroArr[1]), Int32.Parse(heroArr[2]), Int32.Parse(heroArr[3]), heroArr[4], heroArr[5], Int32.Parse(heroArr[6]));
                            oldRogue.Display();
                            break;
                        case 2:
                            Hero oldTemplar = new Templar(Int32.Parse(heroArr[0]), Int32.Parse(heroArr[1]), Int32.Parse(heroArr[2]), Int32.Parse(heroArr[3]), heroArr[4], heroArr[5], Int32.Parse(heroArr[6])); ;
                            oldTemplar.Display();
                            break;
                        case 3:
                            Hero oldShaman = new Shaman(Int32.Parse(heroArr[0]), Int32.Parse(heroArr[1]), Int32.Parse(heroArr[2]), Int32.Parse(heroArr[3]), heroArr[4], heroArr[5], Int32.Parse(heroArr[6]));
                            oldShaman.Display();
                            break;
                        case 4:
                            Hero oldWizard = new Wizard(Int32.Parse(heroArr[0]), Int32.Parse(heroArr[1]), Int32.Parse(heroArr[2]), Int32.Parse(heroArr[3]), heroArr[4], heroArr[5], Int32.Parse(heroArr[6]));
                            oldWizard.Display();
                            break;
                        case 5:
                            Hero oldBarb= new Barbarian(Int32.Parse(heroArr[0]), Int32.Parse(heroArr[1]), Int32.Parse(heroArr[2]), Int32.Parse(heroArr[3]), heroArr[4], heroArr[5], Int32.Parse(heroArr[6]));
                            oldBarb.Display();
                            break;
                        case 6:
                            Hero oldMonk = new Monk(Int32.Parse(heroArr[0]), Int32.Parse(heroArr[1]), Int32.Parse(heroArr[2]), Int32.Parse(heroArr[3]), heroArr[4], heroArr[5], Int32.Parse(heroArr[6])); ;
                            oldMonk.Display();
                            break;
                    }
                   

                    line = reader.ReadLine();
                }

                write.WriteLine(hero.ToString());
                hero.Display();
                write.Close();
                file.Close();

            }
            else
            {
                write.WriteLine(hero.ToString());
                write.Close();
                file.Close();
            }

            reader.Close();

        }

        public static int HeroStart()
        {
            int classHero = 0;
            bool condition = false;
            while (condition == false)
            {
                Console.WriteLine("What class would you want?");
                string answer = (Console.ReadLine()).ToLower();
                switch (answer)
                {
                    case "rogue":
                        classHero = 1;
                        condition = true;
                        break;
                    case "templar":
                        classHero = 2;
                        condition = true;
                        break;
                    case "shaman":
                        condition = true;
                        classHero = 3;
                        break;
                    case "wizard":
                        condition = true;
                        classHero = 4;
                        break;
                    case "barbarian":
                        classHero = 5;
                        condition = true;
                        break;
                    case "monk":
                        classHero = 6;
                        condition = true;
                        break;
                    default:
                        condition = false;
                        break;

                }
                
            }
            return classHero;
        }
    }
}
