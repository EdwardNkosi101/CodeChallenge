using System;
using System.Security.Cryptography.X509Certificates;

class ClassAverage
{
    public static void AvgCalc()
    {
        //int count = 0;
        Console.WriteLine("Enter the number of subjects");
        int numSubjects = int.Parse(Console.ReadLine());
        int totalMarks =0;
        string grade = "";


        for (int i =0; i < numSubjects; i++ )
        {
           
            Console.WriteLine($"Enter score for subject: {i+1}");
            int marks = int.Parse(Console.ReadLine());
            totalMarks += marks;

        }
        double avgMarks = (double)totalMarks/numSubjects;
        //return avgMarks;
        if(avgMarks>=90 && avgMarks <=100)
        {
            grade = "A";
        }
        else if(avgMarks>=80 && avgMarks <= 89)
        {
            grade = "B";

        }
        else if(avgMarks>=70 && avgMarks <=79)
        {
            grade = "C";
        }
        else if (avgMarks>=60 && avgMarks <=69)
        {
            grade = "D";
        }
        else if(avgMarks>=0 && avgMarks<=59)
        {
            grade = "F";
        }
        else
        {
            Console.WriteLine("Invalid score:" + avgMarks);
        }
        Console.WriteLine("Average Score: "+ avgMarks);
        Console.WriteLine("Grade: " + grade);
    }
    static void Main()
    {
        AvgCalc();
    }
}