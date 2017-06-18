using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var gosho = new Gosho("Gosho");

            Console.WriteLine(gosho.ToString());
            Console.WriteLine();

            Console.WriteLine("Pesho e velik");
            Console.WriteLine();

            Console.WriteLine(IvanchoTestedClass.GetName());
        }
    }
}
