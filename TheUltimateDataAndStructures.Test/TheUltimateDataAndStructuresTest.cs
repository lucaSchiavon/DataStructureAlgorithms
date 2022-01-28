using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheUltimateDataAndStructures.SearchingAlgorithms;
using TheUltimateDataAndStructures.SortingAlgorithms;

namespace TheUltimateDataAndStructures.Test
{
    [TestClass]
    public class TheUltimateDataAndStructuresTest
    {
        
        #region SORTING ALGORITHMS

        [TestMethod]
        public void BubbleSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = {7, 3, 1, 4, 6, 2, 3};
            
            BubbleSort bs = new BubbleSort();

            bs.Sort(numbers);


           Assert.IsTrue(ArrayIsSorted(numbers));

        }

        [TestMethod]
        public void SelectionSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = { 7, 3, 1, 4, 6, 2, 3 };

            SelectionSort ss = new SelectionSort();

            ss.Sort(numbers);
            
            Assert.IsTrue(ArrayIsSorted(numbers));

        }

        [TestMethod]
        public void InsertionSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = { 8, 2, 4, 1, 3 };

            InsertionSort ins = new InsertionSort();

            ins.Sort(numbers);

            Assert.IsTrue(ArrayIsSorted(numbers));

        }

        [TestMethod]
        public void MergeSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = { 7, 3, 5, 2, 3, 1, 5, 8 };

            MergeSort ms = new MergeSort();
            ms.Sort(numbers);
            Assert.IsTrue(ArrayIsSorted(numbers));

        }

        [TestMethod]
        public void QuickSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = { 15, 6, 3, 1, 22, 10, 13 };

            QuickSort qs = new QuickSort();
            //qs.Sort(numbers,0,numbers.Length-1);
            qs.Sort2(numbers, 0, numbers.Length - 1);
            Assert.IsTrue(ArrayIsSorted(numbers));

        }

        [TestMethod]
        public void CountingSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = { 5, 3, 2, 5, 4, 4, 5 };

            CountingSort cs = new CountingSort();
            //qs.Sort(numbers,0,numbers.Length-1);
            cs.Sort(numbers, 5);
            Assert.IsTrue(ArrayIsSorted(numbers));

        }

        [TestMethod]
        public void BucketSort_Sort_WhenLaunch_ExecuteSorting()
        {
            int[] numbers = { 5, 3, 2, 5, 4, 4, 5 };

            BucketSort bs = new BucketSort();
           
            bs.Sort(numbers,3);
            Assert.IsTrue(ArrayIsSorted(numbers));

        }

        #endregion

        #region "SEARCHING ALGORITHMS"

        [TestMethod]
        public void LinearSearch_Search_WhenLaunch_ReturnIndexOfValueFounded()
        {
            int[] numbers = { 8, 2, 3, 1, 7, 8, 4 };

            LinearSearch ls = new LinearSearch();

            var indexFounded= ls.Search(numbers, 7);

            Assert.IsTrue(numbers[indexFounded]==7);

        }

        [TestMethod]
        public void LinearSearch_Search_WhenLaunch_ReturnMinusOneBecouseTheValueIsNotInTheArray()
        {
            int[] numbers = { 8, 2, 3, 1, 7, 8, 4 };

            LinearSearch ls = new LinearSearch();

            var indexFounded = ls.Search(numbers, 13);

            Assert.IsTrue(indexFounded == -1);

        }

        [TestMethod]
        public void BinarySearch_SearchRec_WhenLaunch_ReturnIndexOfvalueFoundedInArray()
        {
            int[] numbers = { 3, 5, 6, 9, 11, 18, 20,21,24,30 };

            BinarySearch bs = new BinarySearch();

            var indexFounded = bs.SearchRec(numbers,6,0,numbers.Length-1);

            Assert.IsTrue(indexFounded == 2);

        }

        [TestMethod]
        public void BinarySearch_SearchRec2_WhenLaunch_ReturnIndexOfvalueFoundedInArray()
        {
            int[] numbers = { 3, 5, 6, 9, 11, 18, 20, 21, 24, 30 };

            BinarySearch bs = new BinarySearch();

            var indexFounded = bs.SearchRec2(numbers, 6);

            Assert.IsTrue(indexFounded == 2);

        }

        [TestMethod]
        public void BinarySearch_SearchRec_WhenLaunch_ReturnMinusOneIfValueIsNotFound()
        {
            
            int[] numbers = { 3, 5, 6, 9, 11, 18, 20, 21, 24, 30 };

            BinarySearch bs = new BinarySearch();

            var indexFounded = bs.SearchRec(numbers, 28, 0, numbers.Length - 1);

            Assert.IsTrue(indexFounded == -1);

        }

        [TestMethod]
        public void BinarySearch_SearchIter_WhenLaunch_ReturnMinusOneIfValueIsNotFound()
        {

            int[] numbers = { 3, 5, 6, 9, 11, 18, 20, 21, 24, 30 };

            BinarySearch bs = new BinarySearch();

            var indexFounded = bs.SearchIter(numbers, 28);

            Assert.IsTrue(indexFounded == -1);

        }

        [TestMethod]
        public void BinarySearch_SearchIter_WhenLaunch_ReturnIndexOfValueInArrayBecouseValueIsFounded()
        {

            int[] numbers = { 3, 5, 6, 9, 11, 18, 20, 21, 24, 30 };

            BinarySearch bs = new BinarySearch();

            var indexFounded = bs.SearchIter(numbers, 9);

            Assert.IsTrue(indexFounded == 3);

        }

        #endregion

        #region "Private routines"
        private bool ArrayIsSorted(int[] array)
            {
                bool IsSorted = false;

                int previous = array[0];
                foreach (int item in array)
                {
                    if (item != previous)
                    {
                        IsSorted = previous <= item;
                        if (!IsSorted)
                            return false;
                    }

                    previous = item;
                }

                return IsSorted;
            }
        #endregion

    }
}
