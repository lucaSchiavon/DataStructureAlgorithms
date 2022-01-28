using System;
using System.Collections.Generic;
using System.Text;

namespace TheUltimateDataAndStructures.SearchingAlgorithms
{
    public class LinearSearch
    {
        public int Search(int[] Array,int ValToFound)
        {
            for (var i = 0; i < Array.Length; i++)
            {
                if (Array[i] == ValToFound)
                    return i;
            }
            return -1;
        }
    }
}
