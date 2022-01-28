using System;
using System.Collections.Generic;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class MergeSort
    {
        public void Sort(int[] array)
        {
            if (array.Length<2)
                return;
            //dividi a metà l'array
            var middle = array.Length / 2;

            int[] left = new int[middle];
            for (var i = 0; i < middle; i++)
                left[i] = array[i];
           
            int[] right = new int[array.Length-middle];
            for (var i = middle; i < array.Length; i++)
                right[i-middle] = array[i];
            
            //richiama ricorsivamente ciascuna parte
            Sort(left);
            Sort(right);

            //mergia il risultato
            Merge(left,right,array);
            
        }

        public void Merge2(int[] left,int[] right, int[] result)
        {

            int leftCounter = 0;
            int rightCounter = 0;
            for (var i = 0; i < result.Length-1; i++)
            {


                if (right[rightCounter] <= left[leftCounter])
                {
                    result[i] = right[rightCounter++];
                    //rightCounter++;
                }
                else
                {
                    result[i] = left[leftCounter++];
                    //leftCounter++;
                }

               
            }


        }

        public void Merge(int[] left, int[] right, int[] result)
        {
            int i=0,j=0,k=0;
            while (i<left.Length && j<right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];

            }
            while (j < right.Length)
            {
                result[k++] = right[j++];

            }
        }



    }
}
