using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class SelectionSort
    {
        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
       
                int indexMin= FindMinIndex(array, i);

                Utilities.Swap(array, i, indexMin);
                
            }

        }

        private int FindMinIndex(int[] array, int i)
        {
           var indexMin = i;
            for (var j = i; j < array.Length; j++)
            {
                if (array[j] < array[indexMin])
                {
                    indexMin = j;
                }
            }

            return indexMin;
        }
    }
}
