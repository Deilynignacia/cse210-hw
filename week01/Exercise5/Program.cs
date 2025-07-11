using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string userName = UserName();
        bool continueProgram = true;
        while (continueProgram)
        {
            int userNumber = UserNumber();
            int squaredNumber = SquareNumber(userNumber);

            Result(userName, squaredNumber);

            Console.Write("Would you like to try a different number? (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                continueProgram = false;
                Console.WriteLine("See you!");
            }
            Console.WriteLine();
        }
    }
    static void Welcome()
    {
        Console.WriteLine("Welcome to the program, my friend!");
    }
    static string UserName()
    {
        Console.Write("I am really glad you came by! What is your name? ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserNumber()
    {
        Console.Write("Now, choose a number. ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void Result(string name, int square)
    {
        Console.WriteLine($"Dear {name}, the square of your number is {square}.");
    }
}