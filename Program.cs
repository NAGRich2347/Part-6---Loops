using System;

namespace Part_6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //for (int i = 21; i <= 39; i+= 2){
            //    sum += i;
            //}
            //Console.WriteLine(sum + "");


            //int i = 10;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i = i - 2;
            //}


            //int number;
            //Console.WriteLine("Please enter an integer...");
            //while (!Int32.TryParse(Console.ReadLine(), out number))
            //    Console.WriteLine("That is an invalid integer, please try again.");
            //Console.WriteLine($"Thanks for {number}!");

            int selection;
            
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("$1 - Captain Kirk");
                Console.WriteLine("$2 - Captain Picard");
                selection = Convert.ToInt32(Console.ReadLine());
            } while (selection != 1);
            Console.WriteLine("You chose Captain Picard!");
            Console.WriteLine("You are not correct!");

            while (selection != 2);
            Console.WriteLine("You chose Captain Kirk!");
            Console.WriteLine("You are correct!");




        }
    }
}
