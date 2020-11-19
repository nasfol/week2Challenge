using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterApp
{
     public class Greeter
    {
        
        public void HelloExample(string name)
        {
         
            Console.WriteLine($"Hello {name}.");
            

        }


        
        public string Farewell(string name)
        {
            
            Console.WriteLine($"Goodbye {name}.");
            return name;
        }
        //Build a method that says Good Morning/Afternoon/Evening/Night depending on the time of day.
        public void TimeofDay(string name)

        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine($"Good Morning {name} ");

            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 16)
            {
                Console.WriteLine($"Good Afternoon {name}");

            }
            else if (DateTime.Now.Hour > 16 && DateTime.Now.Hour <= 20)
            {
                Console.WriteLine($"Good evening {name}");
            }
            else
            {
                Console.WriteLine($"GoodNight {name}");
            }

            
        }


    }
}
