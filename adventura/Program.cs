using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventura
{
    interface Helyszin
    {
        void FogadoText();
        void InterakcioText();





    }

    class Metro : Helyszin
    {
        public void FogadoText()
        {
            //ide jön az a szöveg, amikor belép az emberünk a zónába
        }
        public void InterakcioText()
        {
            //ide jön az npc interakcióknak a szövege
        }
    }

    class Aluljaro : Helyszin
    {
        public void FogadoText()
        {
            //ide jön az a szöveg, amikor belép az emberünk a zónába
        }
        public void InterakcioText()
        {
            //ide jön az npc interakcióknak a szövege
        }
    }

    class Arkad : Helyszin
    {
        public void FogadoText()
        {
            //ide jön az a szöveg, amikor belép az emberünk a zónába
        }
        public void InterakcioText()
        {
            //ide jön az npc interakcióknak a szövege
        }
    }

    class Gomba : Helyszin
    {
        public void FogadoText()
        {
            //ide jön az a szöveg, amikor belép az emberünk a zónába
        }
        public void InterakcioText()
        {
            //ide jön az npc interakcióknak a szövege
        }
    }

    class Ikea : Helyszin
    {
        public void FogadoText()
        {
            //ide jön az a szöveg, amikor belép az emberünk a zónába
        }
        public void InterakcioText()
        {
            //ide jön az npc interakcióknak a szövege
        }
    }

    interface npc
    {
        string nev;
        int hp;
        int dmg; //mennyit sebez
        void InterakcioText(); //amikor megszólít mit mond
    }

    class Csoves : npc
    { 
        
    }

    class Valtozok
    {
        int money;
        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        string karakter;
        public string Karakter
        {
            get { return karakter; }
            set { karakter = value; }
        }

        public Valtozok()
        {
            hp = 100;
            money = 1000;
            karakter = "0";
        }
    }

    class Inventory
    {
        string[] taska = new string[8];
        public string[] Taska
        {
            get { return taska; }
            set { taska = value; }
        }

        public bool tele;

        // inventory csere / hozáadás ha van szabad hely bene
        public void Hozadas(string item)
        {
            bool emptySlotFound = false;
            for (int i = 0; i < taska.Length; i++)
            {
                if (taska[i] == null)
                {
                    Taska[i] = item;
                    Console.WriteLine($"elraktad a {item}-t");
                    emptySlotFound = true;
                    break;
                }
            }

            if (!emptySlotFound)
            {
                Console.WriteLine("Kérem adja meg annak a tárgynak a sorszámát, amire cserélni akarja. Ha nem kívánja cserélni, nyomjon 69-et.");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0 && input < Taska.Length)
                {
                    Taska[input - 1] = item;
                }
                else if (input != 69)
                {
                    Console.WriteLine("Érvénytelen sorszám.");
                }
            }
        }
    }

    class Fegyver : Inventory
    {
        string tomo;
        string koran;
        string gitar;
        string ak47;
        string glock;
        string rugosBoko;
        string sparosHell;
    }



    class Program
    {
        static void Main(string[] args)
        {

            Valtozok val = new Valtozok();

            Console.WriteLine("Örsi Adventura");
            Console.WriteLine("Nyomj Entert a kezdéshez!");
            Console.ReadLine();
            Console.WriteLine("Válassz karaktert: 1 - Ádám, 2 - Bobi");

            val.Karakter = Console.ReadLine();
            while (val.Karakter != "1" || val.Karakter != "2")
            {
                Console.WriteLine("Ilyen opció nem volt te paraszt! 1 vagy 2");
                val.Karakter = Console.ReadLine();
            }
        }
    }
}
