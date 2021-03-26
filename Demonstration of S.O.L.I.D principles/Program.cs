using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstration_of_S.O.L.I.D_principles
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Developers e = new DotNetDeveloper();
            e.Technology = "DotNet";
            e.GetTableNumber();
            // Go to http://aka.ms/dotnet-get-started-console to continue how to build a console app!  learning
        }
 }

    public  class Developer
    {
        public string Name { get; set; }

        public string Technology { get; set; }
        public int WorkingHours()
        {
            return 8;
        }
        //public abstract int GetTableNumber();

    }
    class NetDeveloper
    {
        private Developer _Developer = new Developer();
        public NetDeveloper()
        {

        }
    }
}
