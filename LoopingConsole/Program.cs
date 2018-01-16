using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A lot of repetitive code here
            var suzie = new Child { Name = "Suzie", Sick = false};
            //child.Name = "Suzie"; both of these are used without object initialization as illustrated above
            //child.Sick = true;

            Console.WriteLine($"{suzie.Name} is {(suzie.Sick ? "sick" : "healthy")}");
            Console.WriteLine(suzie.ForgeASickNote());

            var ralph = new Child { Name = "Ralph", Sick = true };
            //child.Name = "Suzie"; both of these are used without object initialization as illustrated above
            //child.Sick = true;

            Console.WriteLine($"{ralph.Name} is {(ralph.Sick ? "sick" : "healthy")}");
            Console.WriteLine(ralph.ForgeASickNote());

            Console.WriteLine("This is our second time talking about the same thing. #No judgement.");

            Console.ReadLine();
            */

            //This is a better way to do it

            var children = new List<Child>
            {
                new Child { Name = "Suzie", Sick = false },
                new Child { Name = "Ralph", Sick = true }
            };

            foreach (var child in children)
            {
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }
            
   

            Console.WriteLine("This is our second time talking about the same thing. #No judgement.");

            Console.ReadLine();
        }
    }
}
