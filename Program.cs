using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Greeter greeter = new Greeter();


            greeter.HelloExample(name);
            greeter.Farewell(name);
            greeter.TimeofDay(name);
            Console.ReadLine();



            Greeter love = new Greeter();

            love.Farewell(name);
            love.TimeofDay(name);
            love.HelloExample(name);
            Console.ReadLine();

        }


    }
}
