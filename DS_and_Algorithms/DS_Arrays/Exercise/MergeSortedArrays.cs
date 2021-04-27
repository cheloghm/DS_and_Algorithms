using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms.DS_Arrays.Exercise
{
    public class MergeSortedArrays
    {
        #region First Solution
        #region Sorting the Array
        public void Sort(int[] firstArray, int[] secondArray)
        {
            int k = 0, i = 0, j = 0;
            int firstLen = firstArray.Length;
            int secondLen = secondArray.Length;
            int[] thirdArray = new int[firstLen + secondLen];

            while (i < firstLen && j < secondLen)
            {
                if (firstArray[i] < secondArray[j])
                    thirdArray[k++] = firstArray[i++];
                else
                    thirdArray[k++] = secondArray[j++];
            }

            while (i < firstLen)
            {
                thirdArray[k++] = firstArray[i++];
            }

            while (j < secondLen)
            {
                thirdArray[k++] = secondArray[j++];
            }

            DisplayNewArray(thirdArray);
        }
        #endregion

        #region Displaying the Sorted Array
        public void DisplayNewArray(int[] newArray)
        {
            Console.WriteLine("Merged array:\n");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + "\n");
            }
        }
        #endregion

        #endregion
    }
}
