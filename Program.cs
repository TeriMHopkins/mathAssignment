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

            Console.WriteLine("Enter a number: ");
            string UserInput2 = Console.ReadLine();
            Console.WriteLine(" plus 25 equals ");
            Console.WriteLine(Convert.ToInt64(UserInput2) + 25);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            string UserInput3 = Console.ReadLine();
            Console.WriteLine(" divided by 12.5 equals ");
            Console.WriteLine(Convert.ToDouble(UserInput3) / 12.5);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            string UserInput4 = Console.ReadLine();
            Console.WriteLine(" is greater than 50? ");
            Console.WriteLine(Convert.ToInt64(UserInput4) > 50);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            string UserInput5 = Console.ReadLine();
            Console.WriteLine(" divided by 7 has a remainder of ");
            Console.WriteLine(Convert.ToInt64(UserInput5) %7);
            Console.ReadLine();


        }
    }
}
