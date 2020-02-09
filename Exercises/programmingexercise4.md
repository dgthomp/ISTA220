# **Class: ISTA220**
## **Name:**   Daniel Thompson
## **Assignment:** Programming Exercise4
## **Date:** February 10, 2020

~~~

using System.Media;
using System;

namespace FarmAnimal
{
    class FarmAnimal
    {
        public FarmAnimal()
        {
        //
        }

        string name;
        string species;
        string nationality;
        string diet;
        string food;


        public FarmAnimal(string x, string y, string z)
        {
            name = x;
            species = y;
            nationality = z;

        }
        public void Speak()
        {
            Console.WriteLine($"Hello Human, my name is {name}, and I am a {species}. I am {nationality}");
        }

        public void Eat()
        {
            Console.WriteLine($"I am a {diet}, I eat {food}");
        }


        class Program
        {
            static void Main(string[] args)
            {


                Console.WriteLine("Hello World!");
                FarmAnimal Horse1 = new FarmAnimal("Boxer", "horse", " a Horselander. ");
                Horse1.Speak();
                FarmAnimal Horse2 = new FarmAnimal("Mollie", "horse", " a Squanderhorse. Do you like my Gucci purse?");
                Horse2.Speak();
                FarmAnimal Horse3 = new FarmAnimal("Secretariat", "horse", " a Thoroughbred American.");
                Horse3.Speak();
                FarmAnimal Horse4 = new FarmAnimal("Man O'War", "horse", " a Thoroughbred American.");
                Horse4.Speak();

                FarmAnimal Goat1 = new FarmAnimal("Billy Jean", "goat", "West Caucasian Tur.");
                Goat1.Speak();
                FarmAnimal Goat2 = new FarmAnimal("Nanny Jean", "goat", "Siberian Ibex.");
                Goat2.Speak();
                FarmAnimal Goat3 = new FarmAnimal("Gruff Jean", "goat", "Iberian Ibex.");
                Goat3.Speak();
                FarmAnimal Goat4 = new FarmAnimal("Rammy Jean", "goat", "Himalayan tahr.");
                Goat4.Speak();

                FarmAnimal Duck1 = new FarmAnimal("Alanzo", "duck", "Duckinese. ");
                Duck1.Speak();
                FarmAnimal Duck2 = new FarmAnimal("Bill", "duck", "Duckinese. ");
                Duck2.Speak();
                FarmAnimal Duck3 = new FarmAnimal("Claffy", "duck", "Duckinese. ");
                Duck3.Speak();
                FarmAnimal Duck4 = new FarmAnimal("Duffy", "duck", "Duckinese. ");
                Duck4.Speak();

                FarmAnimal Dog1 = new FarmAnimal("Snoop", "dog", "American");
                Dog1.Speak();
                FarmAnimal Dog2 = new FarmAnimal("Nate", "dog", "American");
                Dog2.Speak();
                FarmAnimal Dog3 = new FarmAnimal("Big", "dog", "American");
                Dog3.Speak();
                FarmAnimal Dog4 = new FarmAnimal("Bad", "dog", "American");
                Dog4.Speak();






            }
        }
    }
}
~~~~
