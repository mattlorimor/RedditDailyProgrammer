using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Challenge122Easy
    {
        static void Main(string[] args)
        {
            var inputNumber = 1073741824;
            var moduloResult = CalculateDigitalRootModulo(inputNumber);
            var customResult = CalculateDigitalRoot(inputNumber);
            Console.WriteLine(string.Format("Modulo-style returned {0} in {1} milliseconds.", moduloResult.Output, moduloResult.ElapsedMilliseconds));
            Console.WriteLine(string.Format("Custom-style returned {0} in {1} milliseconds.", customResult.Output, customResult.ElapsedMilliseconds));
        }

        //Uses the formula from Wikipeda for finding digital roots: http://en.wikipedia.org/wiki/Digital_root
        public static DigitalRootCalculation CalculateDigitalRootModulo(int num)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            DigitalRootCalculation droot = new DigitalRootCalculation(num);
            droot.Output = droot.Input % 9;
            stopWatch.Stop();
            droot.ElapsedMilliseconds = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
            return droot;
        }

        //Strips the input number down until it's less than two digits
        public static DigitalRootCalculation CalculateDigitalRoot(int num)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            DigitalRootCalculation droot = new DigitalRootCalculation(num);
            droot.Output = droot.Input;
            while (droot.Output >= 10)
            {
                droot.Output -= 9;
            }
            stopWatch.Stop();
            droot.ElapsedMilliseconds = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
            return droot;
        }

        public class DigitalRootCalculation
        {
            public int Input;
            public int Output;
            public int ElapsedMilliseconds;

            public DigitalRootCalculation(int num)
            {
                Input = num;
            }
        }
    }
}
