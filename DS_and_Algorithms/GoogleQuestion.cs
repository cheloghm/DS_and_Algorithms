using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms
{
    public class GoogleQuestion
    {
        #region Their Solution
        public bool HasPairWithSum(int[] array, int sum)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] + array[j] == sum)
                        return true;
            return false;
        }
        #endregion

        #region My Solution
        public bool HasPairWithSum2(int[] array, int sum)
        {
            var mySet = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (mySet.Contains(array[i]))
                    return true;
                mySet.Add(sum - array[i]);
            }
            return false;
        }
        #endregion
    }
}
