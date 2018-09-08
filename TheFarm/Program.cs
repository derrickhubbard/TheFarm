using System;

namespace TheFarm
{
    class Program

    {
        static void Main(string[] args)
        {

            Pig Mike = new Pig();
            Sheep James = new Sheep();
            Chicken Bud = new Chicken();
            Goat Tom = new Goat();

            Console.WriteLine("Welcom to Derrick's Farm!");
            Console.WriteLine("I would like to show you my aminals.");

            Mike.Talk();
            James.Talk();
            Bud.Talk();
            Tom.Talk();

            NewAnimal();
        }

        static void NewAnimal()
        {
            Aniaml type = new Aniaml();
            type.Name("Amy");
            type.MakeSound("Hi");
            type.Kind("Duck");

            type.Talk();
            
        }
    }
}
