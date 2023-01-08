using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        string letter = "";
        if ( grade >= 90 )
        {
            letter = "A";
        }
        else if ( grade >= 80 )
        {
            letter = "B";
        }
        else if ( grade >= 70 )
        {
            letter = "C";
        }
        else if ( grade >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");


        if ( grade >= 70 )
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }

        else
        {
            Console.WriteLine("Try harder next time!");
        }

    }
}