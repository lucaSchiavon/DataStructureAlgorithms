﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;

                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }
        }


    }

       
}

