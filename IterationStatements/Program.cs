namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i); 
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Print999()
        {

            for (int i = 3; i <= 999; i +=3)
            {
                Console.WriteLine(i);
            }


        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        public static void EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("This is equal.");
            }
            else
            {
                Console.WriteLine("This is not equal.");
            }


        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0 )
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }

        }


        //Write a method to check whether a given number is positive or negative if else statement

        public static void PositiveOrNegative(int num1)
        {

            if (num1 > 0 )
            {
                Console.WriteLine("Your number is positive");
            }
            else
            {
                Console.WriteLine("Your number is negative");
            }



        }


        //Write a method to read the age of a candidate and determine whether they can vote. works as if else statement
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanYouVote()
        {
            Console.WriteLine("What is your age?");

            var answer = int.Parse(Console.ReadLine());

            if (answer >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("Sorry, but you are not old enough to vote.");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 

       public static void UserRangePrint10()
        {
            Console.WriteLine("Enter a number.");
            var answer2 = int.Parse(Console.ReadLine());

            if (answer2 >= -10 && answer2 <= 10)
            {
                Console.WriteLine("Your number is in the range of 10 and -10.");

            }

            else
            {
                Console.WriteLine("Your number is not in the range of 10 and -10.");
            }

        }



        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void DisplayMultiplicationTable(int num3)

        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($" {i} x {num3} = {num3 * i }");
            }



        }



        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //();
        }
    }
}
