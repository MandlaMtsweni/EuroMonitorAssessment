using System;

namespace EuromonitorAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine("Welcome to Prolem solving app!\n"); 
            Console.WriteLine("This app gives you the difference of what");
            Console.WriteLine("is required to make the number 5.\n");
            Console.WriteLine("Lets have fun!!\n");

            Console.WriteLine("Please enter number less than Five");
            input = Console.ReadLine();            

            Logic logic = new Logic();

            int ans = logic.CalcuteDifference(Convert.ToInt32(input));

            if(ans < 5)
            {
                Console.WriteLine("The number required to get to 5 is " + ans);
            }
            else
            {
                Console.WriteLine("number is not less than five");
            }

            Console.ReadLine();           


        }
    }
}
