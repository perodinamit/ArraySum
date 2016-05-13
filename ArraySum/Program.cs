using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Veličina polja: ");
            i = int.Parse(Console.ReadLine());

            int[] arr = new int[i];

            for (int b = 0; b < i; b++)
            {
                arr[b] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n");

            for (int b = 0; b < i; b++)
            {
                Console.WriteLine("you entered {0}", arr[b]);
            }
            Console.WriteLine("");
            int sum;
            sum = arr.Sum();
            Console.WriteLine("Suma unešenih brojeva je: {0}", sum);

            Console.WriteLine("Najveći broj je: {0}", arr.Max());

            Console.WriteLine("Suma ispod 10 je:");
            int less;
            less = arr.Where(a => a > 0 && a < 10).Sum();
            Console.WriteLine(less);
        }
    }
}
