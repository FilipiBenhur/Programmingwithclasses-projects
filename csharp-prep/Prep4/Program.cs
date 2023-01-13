using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        while ( number != 0 )
        {
            Console.Write("Choose number (press 0 to terminate): ");
            string choose = Console.ReadLine();
            number = int.Parse(choose);

            if ( number != 0 )
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach ( int number in numbers )
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];
        foreach ( int number in numbers)
        {
            if ( number > maximum )
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The maximum is: {maximum}");


    }
}