using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms.DS_Arrays.Exercise
{
    class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = nums[0];
            var newArray = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                if (sum < 0 && nums[1] < 0)
                {
                    sum = Math.Abs(sum) - Math.Abs(nums[1]);
                    if (sum > 0)
                        newArray[0] = sum * -1;
                    else
                        newArray[0] = sum;
                }
                else if (sum < 0 && nums[1] > 0)
                    newArray[0] = Math.Abs(sum += nums[1]);
                else if (sum < 0 && nums[1] == 0)
                    newArray[0] = 0;
                else
                    newArray[0] = sum += nums[1];
            }
            else
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    sum += nums[i];
                    newArray[i - 1] = sum;
                    if (sum == 0)
                        if ((nums.Length - 1) - i == 1)
                            sum = 0;
                    else
                        sum += nums[i];
                }
            }

            return newArray.Max();
                        
        }
    }
}
