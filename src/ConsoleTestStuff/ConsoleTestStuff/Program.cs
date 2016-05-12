using System;

namespace ConsoleTestStuff
{
    class Program
    {
        static void Main (string[] args)
        {
            var sarasa = new beat {Base = "Folk", Speed = 120, Time = 120};

            Console.WriteLine(sarasa.ToString());
            Console.ReadKey();
        }
    }
}
