using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms.DS_Arrays.Exercise
{
    public class TwoSum
    {
        // Returns the index of two values that sums up to the target
        public int[] SumIndex(int[] nums, int target)
        {
            var result = new int[2];
            int Len = nums.Length;
            for (int i = 0; i < Len - 1; i++)
                for (int j = i + 1; j < Len; j++)
                    if (nums[i] + nums[j] == target) {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
            return result;
        }
    }
}
