using System;

class SumNumbers
{
    public static void SumOfFirstNumbers()   
    {
        Console.WriteLine("Enter a positive interger");
        int numberInput = int.Parse(Console.ReadLine());
        int sum;
        if(numberInput<=0)
        {
            Console.WriteLine("Error: Please enter a positive interger");
        }
        else
        {
            sum = (numberInput*(numberInput+1))/2;
            Console.WriteLine($"The sum of the first {numberInput} natural numbers is: {sum}");
        }
        
    }
    static void Main()
    {
        SumOfFirstNumbers();
    }
}