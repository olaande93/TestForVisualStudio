using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        private static Program fake;
        public Program() {
            System.Diagnostics.Process.Start("firefox.exe");

        }
        static void Main(string[] args)
        {
            fake = new Program();
        }
    }
}
