using System;

class Program
{
    static void Monday()
    {
        Console.WriteLine("Your bag for Monday :\n\n");
        Console.WriteLine("Remove : Technology, History/Geography\n");
        Console.WriteLine("Add : Biology, Art, Math, Chemistery, Spanish, English");
    }

    static void Tuesday()
    {
        Console.WriteLine("Your bag for Tuesday :\n\n");
        Console.WriteLine("Remove : Chemistery, Art, Biology\n");
        Console.WriteLine("Add : History/Geography");
    }

    static void Wednesday()
    {
        Console.WriteLine("Your bag for Wednesday :\n\n");
        Console.WriteLine("Remove : Math, French, Latin, Spanish\n");
        Console.WriteLine("Add : History/Geography (week A), Technology, P.E");
    }

    static void Thursday()
    {
        Console.WriteLine("Your bag for Thursday :\n\n");
        Console.WriteLine("Remove : Technology, P.E, English\n");
        Console.WriteLine("Add : Math, Music, Spanish, History/Geography, Chemistery");
    }

    static void Friday()
    {
        Console.WriteLine("Your bag for Friday :\n\n");
        Console.WriteLine("Remove : Spanish, Music, Math, Chemistery\n");
        Console.WriteLine("Add : Biology (week B), P.E (week B), Latin, French, Technology");
    }

    static void Main()
    {
        if (DateTime.Now.Hour <= 13)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Monday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Tuesday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Wednesday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                Thursday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                Friday();
            }
        }

        else if (DateTime.Now.Hour >= 13)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Tuesday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Wednesday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Thursday();
            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                Friday();
            }
            
            else
                Monday();
        }

        else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
        {
            Monday();
        }

        Console.WriteLine("\n\npress enter to quit");
        Console.ReadLine();
        //First release : 01 December 2011.
    }
}
