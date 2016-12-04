using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many books do you want to read this year:");
        var wantToRead = int.Parse(Console.ReadLine());
        Console.WriteLine("How many books have you readed this year:");
        var readed = int.Parse(Console.ReadLine());

        var daysPerBook = 365 / wantToRead;
        var expectedDaysUsed = readed * daysPerBook;
        var dayOfTheYear = DateTime.Now.DayOfYear;
        var gap = (dayOfTheYear - expectedDaysUsed) / daysPerBook;

        if (gap > 0)
            Console.WriteLine($"You are behind your goal by {Math.Abs(gap)} books.");
        else if (gap == 0)
            Console.WriteLine("You are a great reader.");
        else
            Console.WriteLine($"You are a great reader, and have readed {Math.Abs(gap)} books more.");

    }
}