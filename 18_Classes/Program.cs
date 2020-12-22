using System;

namespace _18_Classes
{
    class Program
    {
        class Wizard
        {
            public string name; // `public` members are accessible outside the class as well as inside the class
            public string favoriteSpell;
            private int spellSlots; // `private` members are only accessible within class
            float experience; // by default it has a `private` access modifier

            public static int Count; // `Count` is going to be the same for all class objects because `static` is mentioned

            // let's make a constructor
            public Wizard(string _name, string _favoriteSpell)
            {
                name = _name;
                favoriteSpell = _favoriteSpell;
                spellSlots = 2;
                experience = 0F;

                Count++;
            }

            public void CastSpell()
            {
                if(spellSlots > 0)
                {
                    Console.WriteLine(name +" casts "+ favoriteSpell);
                    spellSlots--;
                    experience += 0.3F;
                } else {
                    Console.WriteLine(name +" is out of spell slots.");
                }

                Console.WriteLine("Current Experience level of "+name+" is: "+experience);
            }

            public void Medidate()
            {
                Console.WriteLine(name +" meditates to regain spell slots.");
                spellSlots = 2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CLASSES\n");

            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            wizard01.CastSpell();
            Console.WriteLine("\n--------\n");
            wizard01.CastSpell();
            Console.WriteLine("\n--------\n");
            wizard01.CastSpell();
            Console.WriteLine("\n--------\n");

            wizard01.Medidate();
            Console.WriteLine("\n--------\n");
            wizard01.CastSpell();
            Console.WriteLine("\n--------\n");
            wizard01.CastSpell();
            Console.WriteLine("\n--------\n");

            Wizard wizard02 = new Wizard("Kumar Anurag", "Abracadabra");
            wizard02.CastSpell();
            Console.WriteLine("\n--------\n");

            int count = Wizard.Count;

            Console.WriteLine("\nTotal no of wizards are: "+count);

            /*
            OUTPUT:

            CLASSES

            Parry Hopper casts Unexpecto Patronum
            Current Experience level of Parry Hopper is: 0.3

            --------

            Parry Hopper casts Unexpecto Patronum
            Current Experience level of Parry Hopper is: 0.6

            --------

            Parry Hopper is out of spell slots.
            Current Experience level of Parry Hopper is: 0.6

            --------

            Parry Hopper meditates to regain spell slots.

            --------

            Parry Hopper casts Unexpecto Patronum
            Current Experience level of Parry Hopper is: 0.90000004

            --------

            Parry Hopper casts Unexpecto Patronum
            Current Experience level of Parry Hopper is: 1.2

            --------

            Kumar Anurag casts Abracadabra
            Current Experience level of Kumar Anurag is: 0.3

            --------


            Total no of wizards are: 2
            */
        }
    }
}
