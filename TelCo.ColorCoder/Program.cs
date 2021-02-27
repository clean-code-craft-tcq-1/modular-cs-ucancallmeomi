using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class Program
    {
        private static void Main(string[] args)
        {

            ColorCodeTests.PerformColorFromPairNumberTests();
            ColorCodeTests.PerformPairNumberFromColorTests();
            Console.WriteLine("25-pair Color Code Reference Manual ");

            for (int i = 1; i <= 25; i++)
            {
                ColorPairExecutionLogic colors = ColorPairExecutionLogic.GetColorFromPairNumber(i);
                Console.WriteLine("Pair: {0}, Colors: {1}", i, colors);
            }

        }
    }
}
