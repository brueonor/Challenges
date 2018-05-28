using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AVeryBigSum();

            Console.ReadKey();
        }

        private static void AVeryBigSum()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long sum = ar.Sum();

            Console.WriteLine(sum);
        }

        private static void CompareTheTriplets()
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));

            int scoreA = 0;
            int scoreB = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                    scoreA++;
                else if (b[i] > a[i])
                    scoreB++;
            }

            Console.WriteLine($"{scoreA} {scoreB}");
        }

        private static void SimpleArraySum()
        {
            int nbItems = Convert.ToInt32(Console.ReadLine());
            string itemList = Console.ReadLine();
            var items = itemList.Split(' ').Select(x => Convert.ToInt32(x));

            if (items.Count() != nbItems)
                throw new InvalidOperationException($"Il devrait y avoir {nbItems}, mais on a trouvé {items.Count()} : {itemList}");

            Console.WriteLine(items.Sum());
        }

        private static void solveMeFirst()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = val1 + val2;
            
            Console.WriteLine(sum);
        }

      
    }
}
