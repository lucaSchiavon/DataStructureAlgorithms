using System;
using System.Collections.Generic;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public static class ExtMethods
    {
        public static string ToStringArr(this int[] arr)
        {
            string arrstr = "[";
            for (var i = 1; i < arr.Length; i++)
            {
                arrstr += $"{arr[i]},";
            }

            arrstr = arrstr.Remove(arrstr.Length - 1);
            arrstr += "]";
            return arrstr;
        }
    }
}
