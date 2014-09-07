using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 5, 2, 6, 0, 2, 9, 8, 3};
            
            sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }

        private static void sort(int[] arr)
        {
            double reductionFactor = 1.247330950103979;
            int step = arr.Length;
            bool swapped = true;

            while (step > 1 || swapped)
            {
                if (step > 1)
                {
                    step = (int)(step / reductionFactor);
                }
                swapped = false;
                for (int i = 0; i + step < arr.Length; i++)
                {
                    if (arr[i] > arr[i + step])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + step];
                        arr[i + step] = t;
                        swapped = true;
                    }
                }
            }
        }
    }
}
