using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            //Done Create a class Animal
            // Done give this class 4 members that all Animals have in common


            // Done Create a class Bird
            // Done give this class 4 members that are specific to Bird
            // Done Set this class to inherit from your Animal Class

            // Done Create a class Reptile
            // Done  give this class 4 members that are specific to Reptile
            // Done Set this class to inherit from your Animal Class

            /* DoneCreate an object of your Bird class
             *
             *
             * Done give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird();
            bird1.CanFly = true;
            bird1.WebbedFeet = false;
            bird1.WingColor = "red";
            bird1.BeakLength = 2.5;

            ////Done *Create an object of your Reptile class
            // //*  give values to your members using the object of your Reptile class
            // *  
            // * Creatively display the class member values 
            // */
            var reptile1 = new Reptile();
            reptile1.CanGrowTail = true;
            reptile1.Habitat = "desert";
            reptile1.HasScales = true;
            reptile1.IsColdBlooded = true;

            var myAnimals = new Animal[] { bird1, reptile1 };

            foreach (var Animal in myAnimals)
            {
                Console.WriteLine($"Alive:{Animal.IsAlive}.");
                Console.WriteLine($"Species:{Animal.Species}.");
                Console.WriteLine($"Legs:{Animal.LegCount} legs.");
                Console.WriteLine($"Age:{Animal.Age} years old.");
            }
        }
    }
}
