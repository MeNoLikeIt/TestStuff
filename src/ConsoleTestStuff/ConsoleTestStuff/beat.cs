using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestStuff
{
    class beat
    {
        public int Time { get; set; }
        public int Speed { get; set; }
        public string Base { get; set; }
        public override string ToString ()
        {
            return string.Format("Time {0} Speed {1} Style {2} Base {3}", Time, Speed, Style, Base);
        }
    }
}
