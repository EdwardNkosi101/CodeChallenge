using System;

class MultiplicationTable
{
    public static int Multiple(int number, int range)
    {
        int result = 0;
        for(int i =1; i<= range; i++)
        {
            result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter the base number: ");
        string? input = Console.ReadLine();
        Console.WriteLine("Enter the range: ");
        string? Nrange = Console.ReadLine();

        if(int.TryParse(input, out int number) && int.TryParse(Nrange, out int range))
        {
            Multiple(number,range);
        }
        else
        {
            Console.WriteLine("Invalid intergers");
        }
    }
}