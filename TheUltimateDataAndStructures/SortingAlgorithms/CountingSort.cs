using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class CountingSort
    {
        public void Sort(int[] array,int max)
        {
            int[] counts = new int[max+1];

            for (var i = 0; i <= array.Length-1; i++)
            {
                counts[array[i]] = counts[array[i]]+1;
            }

            var x = 0;

            for (var j = 0; j <= counts.Length-1; j++)
            {
                
                for (var y=0;y< counts[j];y++)
                {
                    array[x] = j;
                    x++;
                }
            }
        }

        public void Sort2(int[] array, int max)
        {
            int[] counts = new int[max + 1];

            foreach (int item in array)
            {
                counts[item]++;

                var k = 0;

                for (var i = 0; i < counts.Length; i++)
                {
                    for (var j = 0; j < counts[i]; j++)
                    {
                        array[k] = i;
                    }
                }
            }
        }

    }
}
