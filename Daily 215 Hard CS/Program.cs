using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_215_Hard_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var pgm = new Program();
            Console.WriteLine("null " + pgm.PrintTruthiness<object>(null));
            Console.WriteLine("Hello World " + pgm.PrintTruthiness<string>("Hello World"));
            Console.WriteLine("\"\" " + pgm.PrintTruthiness<string>(""));
            Console.WriteLine("\'0\' " + pgm.PrintTruthiness<char>('0'));
            Console.WriteLine("1 " + pgm.PrintTruthiness<int>(1));
            Console.WriteLine("0 " + pgm.PrintTruthiness<int>(0));
            Console.WriteLine("1b " + pgm.PrintTruthiness<byte>(1));
            Console.WriteLine("0.0m " + pgm.PrintTruthiness<Decimal>(0.0m));
            Console.WriteLine("0.0f " + pgm.PrintTruthiness<float>(0.0f));
            Console.WriteLine("0.0d " + pgm.PrintTruthiness<double>(0.0d));
            int[] arr = new int[3];
            Console.WriteLine("[] " + pgm.PrintTruthiness<int[]>(arr));
            int[] arr2 = new int[3] { 1, 2, 3 };
            Console.WriteLine("[1,2,3] " + pgm.PrintTruthiness<int[]>(arr2));
            Console.WriteLine("true " + pgm.PrintTruthiness<bool>(true));
            Console.WriteLine("false " + pgm.PrintTruthiness<bool>(false));

            //Suspend the console.
            Console.ReadKey();
        }

        public string PrintTruthiness<T>(T input) {
            try
            {
                return Convert.ToString(Truthiness<T>(input));
            }
            catch (System.InvalidCastException ex) {
                return "Cannot convert to a Boolean value.";
            }
        }

        public bool Truthiness<T>(T input) {
            try
            {
                return Convert.ToBoolean(input);
            }
            catch (System.FormatException ex) {
                throw new InvalidCastException();
            }
        }
    }
}
