using System;

class FizzBuzz
{
    public static void FizzBuzzChallenge()
    {
        Console.WriteLine("Enter an interger: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        List<string> sequence = new List<string>();
        //string[] sequence;
        for(int i=1; i<=num; i++)
        {
            
            if (i%3==0 && i%5==0)
            {
               sequence.Add("FizzBuzz");
            }
            else if(i%3==0)
            {
                sequence.Add("Fizz");
            }
            else if(i%5==0)
            {
                sequence.Add("Buzz");
            }
            else
            {
                sequence.Add(i.ToString());
            }

        }
        Console.WriteLine(string.Join("\n", sequence));
     
    }
    static void Main()
    {
        FizzBuzzChallenge();
    }
}