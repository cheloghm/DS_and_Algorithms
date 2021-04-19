using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms
{
    public class ContainsCommonItem
    {
        //----------- implement in Program.Main()
        //array1 = ['a', 'b', 'c', 'x'];
        //array2 = ['z', 'y', 'x'];
        //should return true.

        #region First Solution
        // 2 parameters - arrays - no size limit
        // return true or false
        public bool ContainsCommonItems<T>(T[] array1, T[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
                for (int j = 0; j < array2.Length; j++)
                    if (array1[i].Equals(array2[j]))
                        return true;
            return false;
        }
        //O(a*b) or O(n^2)
        //O(1) - Space Complexity
        #endregion

        #region Second Solution
        public bool ContainsCommonItems2<T>(T[] array1, T[] array2)
        {
            var HS_tally = new HashSet<T>(); // for holding elements of first array

            // loop through first array and create object where properties === items in the array
            // can we assume always 2 params?
            for (int i = 0; i < array1.Length; i++)
                if (!HS_tally.Contains(array1[i]))
                    HS_tally.Add(array1[i]);

            // loop through second array and check if item in second array exists on HashSet object. 
            for (int j = 0; j < array2.Length; j++)
                if (HS_tally.Contains(array2[j]))
                    return true;
            return false;
        }
        //O(a + b) Time Complexity or O(n)
        //O(a) Space Complexity
        #endregion

        #region Third Solution
        public bool ContainsCommonItems3<T>(T[] array1, T[] array2)
        {
            var HS_tally = new HashSet<T>(array1); // converting first array to a hashset
            
            // loop through array and check if item in second array exists on HashSet object. 
            for (int j = 0; j < array2.Length; j++)
                if (HS_tally.Contains(array2[j]))
                    return true;
            return false;
        }
        #endregion
    }
}
