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




            //Who is the better captain?

            //int selection;
            //do
            //{
            //    Console.WriteLine("Who is the better captain?");
            //    Console.WriteLine("$1 - Captain Kirk");
            //    Console.WriteLine("$2 - Captain Picard");
            //    selection = Convert.ToInt32(Console.ReadLine());
            //} while (!(selection == 1 || selection == 2));
            //Console.WriteLine("You are correct!");




            //Prompter
            //int num1;
            //int num2;

            //Console.WriteLine("Please enter two numbers of your choice...");

            //Console.WriteLine("Enter your first number. (Min. value)");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Now, enter your second number. (Max. value)");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //int num3;
            //Console.WriteLine("Finally, enter a number between " + num1 + " and " + num2 + ".");
            //while (!Int32.TryParse(Console.ReadLine(), out num3))
            //  Console.WriteLine("That is an invalid integer, please try again.");
            //Console.WriteLine($"Thanks for {num3}!");




            //PERCENTPASSING

            //double score1;
            //double score2;
            //double score3;
            //double score4;
            //double score5;
            //double total = 0;
            //double pass_grade = 0;
            //double grade_perc = 0;


            //Console.WriteLine("First, please enter your first score. (1/100)");
            //Console.WriteLine("Please round all values to the nearest whole number.");
            //score1 = Convert.ToInt32(Console.ReadLine());
            //if (score1 > 70) {
            //    total = total + 1;
            //}
            //if (score1 > 50)
            //{
            //    pass_grade = pass_grade + 1;
            //}



            //Console.WriteLine("Secondly, enter your second score. (1/100)");
            //score2 = Convert.ToInt32(Console.ReadLine());
            //if (score2 > 70)
            //{
            //    total = total + 1;
            //}
            //if (score2 > 50)
            //{
            //    pass_grade = pass_grade + 1;
            //}


            //Console.WriteLine("Then, enter your third score. (1/100)");
            //score3 = Convert.ToInt32(Console.ReadLine());
            //if (score3 > 70)
            //{
            //    total = total + 1;
            //}
            //if (score3 > 50)
            //{
            //    pass_grade = pass_grade + 1;
            //}


            //Console.WriteLine("Now, please enter your fourth score. (1/100)");
            //score4 = Convert.ToInt32(Console.ReadLine());
            //if (score4 > 70)
            //{
            //    total = total + 1;
            //}
            //if (score4 > 50)
            //{
            //    pass_grade = pass_grade + 1;
            //}


            //Console.WriteLine("Finally, please enter your fifth score. (1/100)");
            //score5 = Convert.ToInt32(Console.ReadLine());
            //if (score5 > 70)
            //{
            //    total = total + 1;
            //}
            //if (score5 > 50)
            //{
            //    pass_grade = pass_grade + 1;
            //}

            //grade_perc = total / 5;
            //grade_perc = grade_perc * 100;

            //Console.WriteLine($"The total of your scores above 70% is {total}.");
            //Console.WriteLine($"The average percentage of your scores is {grade_perc}%.");
            //Console.WriteLine($"You are passing {pass_grade} out of 5 courses.");
            //Console.ReadLine();


            //ODD SUM

            int i;
            int n;
            int sum;

            Console.WriteLine("Please enter a whole number...");
            i = Convert.ToInt32(Console.ReadLine());
            for (i=1; i<=n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }

            Console.Write($"The sum of your odd number to {0} is {1}");




        }
    }
}
