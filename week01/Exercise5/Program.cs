using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string userName = UserName();
        int userNumber = UserNumber();
        int squaredNumber = SquareNumber(userNumber);

        Result(userName, squaredNumber);
    }
    static void Welcome()
    {
        Console.WriteLine("Welcome to the program, my friend!");
    }
    static string UserName()
    {
        Console.Write("I am really glad you came! What is your name? ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserNumber()
    {
        Console.Write("That is a beautiful name! What is your favorite number? ");
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
        Console.WriteLine($"Dear {name}, the square of your number is {square}");
    }
}