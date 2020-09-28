using System;

namespace Lucktext_igen_igen
{
    class Program
    {
        static void Main(string[] args)
        {
            string benamning2;
            string benamning1;
            string gender;
            string name;
            string color;
            string car;
            string resturant;

            benamning2 = "he";
            benamning1 = "his";

            Console.WriteLine("Hello What is your name?");


            name = Console.ReadLine();




            Console.WriteLine("Hi " + name + " lets make a short story. Are you a boy of a girl?");


            gender = Console.ReadLine();

            if (gender == "boy")
            {

                Console.WriteLine("Supp dude what is your favorite color?");

            }
            else if (gender == "girl")
            {

                Console.WriteLine("Supp guuuuurl what is your favorite color?");

            }
            else { Console.WriteLine("That is not a gender"); }



            if (gender == "boy")
            {
                benamning1 = "his";
                benamning2 = "he";

            }
            else if (gender == "girl")
            {
                benamning1 = "her";
                benamning2 = "she";

            }



            color = Console.ReadLine();

            Console.WriteLine("Ok dope " + color + " is a good choise! Next is your favorite car.");

            car = Console.ReadLine();

            Console.WriteLine("Really? " + car + " that car is trash but aight next thing i need to know is your favorite resturant.");





            resturant = Console.ReadLine();




            Console.WriteLine("Ok time for the story");
            Console.WriteLine("One day " + name + " was driving " + benamning1 + " " + color + " " + car + " When " + benamning2 + " noticed that " + benamning2 + " was hungry so " + benamning2 + " stoped at " + resturant);
            Console.ReadLine();
        }
    }
}
