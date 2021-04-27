using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms.DS_Arrays.Exercise
{
    public class FirstRecurringElement
    {
        public void RecurringElement<T>(T[] arr)
        {
            //HashSet<T> HS = new HashSet<T>(arr);
            var HS = new HashSet<T>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (HS.Contains(arr[i]))
                {
                    Console.WriteLine("{0} is the first recurring element", arr[i]);
                    break;
                }
                else
                {
                    HS.Add(arr[i]);
                }
            }

        }
    }
}
