using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestSinifi ts = new TestSinifi();
            ts.MetotA();
            ts.MetotB();
            ts.MetotC();
            Console.ReadLine();
        }
    }

    public class TestSinifi
    {
        public void MetotA()
        {
            Console.WriteLine("Merhaba Ben Metot A");
        }

        [Conditional("DEBUG")]
        public void MetotB()
        {
            Console.WriteLine("Merhaba Ben Metot B");
        }

        public void MetotC()
        {
            Console.WriteLine("Merhaba Ben Metot C");
        }
    }
}
