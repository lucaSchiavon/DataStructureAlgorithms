using System;
using System.Collections.Generic;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class QuickSort
    {
        public void Sort(int[] array, int FromIndex, int ToIndex)
        {
            if (FromIndex >= ToIndex)
                return;

            int b = FromIndex - 1;
            int pivot = array[ToIndex];

            for (var i = FromIndex; i <= ToIndex; i++)
            {
                if (array[i] <= pivot)
                    Utilities.Swap(array,++b,i);
            }

            Sort(array,0,b-1);
            Sort(array, b+1, ToIndex);
        }

        public void Sort2(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            int boundary = Partition(array, start, end);

            Sort2(array,0, boundary - 1);
            Sort2(array, boundary+1, end);

        }

        private int Partition(int[] array, int start, int end)
        {
  
            int b = start - 1;
            int pivot = array[end];

            for (var i = start; i <= end; i++)
            {
                if (array[i] <= pivot)
                    Utilities.Swap(array, ++b, i);
            }

            return b;
        }


    }
}
