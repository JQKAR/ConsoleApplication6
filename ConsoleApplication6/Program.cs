using ConsoleApplication6.Model;
using System;
using System.Collections.Generic;


namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            var produce = new List<object>(); // explicitly create the object 
            var f1 = new Fruit("Apple ", 8.5, 3); // instant of a class and i'm instantiating it with Fruit
            //f1.Serialnumber = 0001;
            produce.Add(f1);

            var f2 = new Fruit("Banana ", 4.5, 7);
            //f2.Serialnumber = 0002;
            produce.Add(f2);



            produce.Add(new Vegetable("Carrot ", 4.1, 16)); // one statement
            Console.WriteLine("There are: " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}
