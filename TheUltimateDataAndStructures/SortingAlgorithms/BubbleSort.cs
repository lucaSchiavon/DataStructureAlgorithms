using System;
using System.Globalization;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class BubbleSort
    {
        
        public void Sort(int[] array)
        {
            bool isSorted=false;

            for (var i = 0; i < array.Length; i++)
            {
                isSorted = true;

                for (var j = 1; j < array.Length-i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        Utilities.Swap(array, j, j - 1);
                        isSorted = false;
                    }
  
                }

                if (isSorted)
                    return;

            }

           

        }

       
    }
}
