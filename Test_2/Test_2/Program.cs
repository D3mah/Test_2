using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            var k = 5.2;
            var l = false;

            Console.WriteLine(i+k+l.ToInt32);
            Console.ReadLine();
        }
    }
}
