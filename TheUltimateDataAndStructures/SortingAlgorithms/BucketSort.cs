using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TheUltimateDataAndStructures.SortingAlgorithms
{
    public class BucketSort
    {
        public void Sort(int[] array,int numOfbuckets)
        {

            //rimette i valori ordinati nell'array di partenza
            var i = 0;
            foreach (var bucket in CreateBuckets(array, numOfbuckets))
            {
                if (bucket != null)
                {
                    bucket.Sort();
                    foreach (var val in bucket)
                    {
                        array[i++] = val;
                    }
                }
            }
        }

        private List<int>[] CreateBuckets(int[] array,int numOfBuckets)
        {
            List<Int32>[] buckets = new List<Int32>[numOfBuckets];

            //mette nei bucket i valori dell'array
            foreach (var item in array)
            {
                var bucketNumber = item / numOfBuckets;

                if (buckets[bucketNumber] == null)
                    buckets[bucketNumber] = new List<int>();

                buckets[bucketNumber].Add(item);
            }

            return buckets;
        }

    }
}
