using System;

/*
 * Name of Program
 * Your Name, Date
 * Introduction to Programming
 */

namespace NewsLizards
{
    class Program
    {
        static void Main()
        {
            News.Run();
        }
    }
    class News
    {
        static public string Headlines = "Golden Gate bridge destroyed AGAIN by monster cupcakes!";
        static public string Sports = "Cubs win World Series";
        static public string Weather = "Cupcake rain!";
        static public string Advertisements = "Bob's Cupcakes";
        static public int Temperature = 12;
        static public string Name = "";

        static public void Run()
        {
            Console.Title = "News for you!";
            Inform();
            Broadcast();
            Console.WriteLine("Press enter for weather");
            Console.ReadKey();
            ShowWeather();

            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();

            Console.WriteLine("Hello " + Name);
            Console.ReadKey();
        }
        static public void Inform()
        {
            Console.WriteLine("News is informing you about: " + Headlines);
        }

        static public void Broadcast()
        {
            Console.WriteLine("News is broadcasting: " + Sports);

        }

        static public void Verify()
        {
            Console.WriteLine("News is being verified");

        }

        static public void ShowWeather()
        {
            Console.Title = "The weather is currently: " + Weather;

        }
    }
}
