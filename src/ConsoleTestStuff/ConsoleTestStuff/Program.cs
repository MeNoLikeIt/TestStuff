using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestStuff
{
    class Program
    {
        static void Main (string[] args)
        {
            var sarasa = new beat();
            sarasa.Base = "Folk";
            sarasa.Speed = 120;
            sarasa.Style = "Rock";
            sarasa.Time = 120;

            Console.WriteLine(sarasa.ToString());
            Console.ReadKey();
        }
    }
}
