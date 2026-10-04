using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsfunda
{
    internal class ex_multi_lvl
    {

        public void display()
        {
            Console.WriteLine("This is a multi-level inheritance example.");
        }
    }

    internal class animal : ex_multi_lvl
    {
       
        public string color="purple";

        public animal()
        {
            Console.WriteLine("animal constructor");
        }
        public virtual void eat()
        {
            Console.WriteLine("herbivore/carnivore/omnivore");
        }

        
    }

    internal class dog : animal
    {
        public string color = "blue";
        public void display()
        {

            Console.WriteLine("dog's color:"+ color);

            Console.WriteLine("dog's color:" + base.color);
        }
        public override void eat()
        {
            base.eat(); 
            Console.WriteLine("omnivore");
        }
        public void bark()
        {
            Console.WriteLine("barking");
        }
    }

    internal class babyDog : dog
    {
        public void weep()
        {
            Console.WriteLine("weeping");
        }
    }
}
