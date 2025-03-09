using System;
using System.Runtime.Serialization;

class ReverseLogic
{
    public static int ReverseNumber(int number)
    {
        int sign = number< 0? -1 : 1;
        number = Math.Abs(number);

        int result = 0;
        while(number !=0)
        {
            result = result * 10 + number% 10;
            number/=10;
        }
        return sign * result;
       // char[] cArray = number.ToString().ToCharArray();
      //  Array.Reverse(cArray);
       //string revNumber = new string(number.ToString().Reverse().ToArray());
        
    
    }
    static void Main()
    {
        Console.WriteLine("Enter interger");
        string input = Console.ReadLine();

        if(int.TryParse(input, out int number))
        {
        int result = ReverseNumber(number);
        Console.WriteLine("Reversed interger: " + result);
        }
        else
        {
            Console.WriteLine("Invalid ineterger:" +input);
        }
    }
}