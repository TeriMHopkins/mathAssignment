using System;


namespace mathAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string UserInput = Console.ReadLine();
            Console.WriteLine(" times 50 equals ");
            Console.WriteLine(Convert.ToInt64(UserInput) * 50);
            Console.ReadLine();
            Console.WriteLine(" plus 25 equals ");
            Console.WriteLine(Convert.ToInt64(UserInput) + 25);
            Console.ReadLine();
            Console.WriteLine(" divided by 12.5 equals ");
            Console.WriteLine(Convert.ToDouble(UserInput) / 12.5);
            Console.ReadLine();
            Console.WriteLine(" is greater than 25? ");
            Console.WriteLine(Convert.ToInt64(UserInput) > 25);
            Console.ReadLine();
            Console.WriteLine(" divided by 7 has a remainder of ");
            Console.WriteLine(Convert.ToInt64(UserInput) %7);
            Console.ReadLine();


        }
    }
}
