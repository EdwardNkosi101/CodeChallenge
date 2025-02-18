using System;

class Calculator
{
    public static void Calc()
    {
        Console.WriteLine("Enter the first number: ");
        double number1= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter operator ( +, -, x, /)");
        string? signOperator = Console.ReadLine();
        Console.WriteLine("Enter the second number: ");
        double number2= Convert.ToDouble(Console.ReadLine());

        if(signOperator == "+")
        {
                Console.WriteLine($"Results:{number1 + number2} ");
        }
        else if(signOperator == "x")
        {
            Console.WriteLine($"Results: {number1 * number2}");
        }
        else if (signOperator == "-")
        {
            Console.WriteLine($"Results:{number1 - number2}");
        }
        else if (signOperator == "/")
        {
            if(number1 !=0)
            Console.WriteLine($"Results:{number1 / number2}");
            else
            Console.WriteLine("Division by 0 is invalid");
        }
        else
        {
            Console.WriteLine("User input error, Learn to follow instructions!");
        }




    }
    static void Main()
    {
        Calc();
    }
}