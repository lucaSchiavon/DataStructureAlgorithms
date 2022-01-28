using System;
using System.Collections.Generic;
using System.Text;

namespace TheUltimateDataAndStructures
{
    public static class Utilities
    {
        public static void Swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
