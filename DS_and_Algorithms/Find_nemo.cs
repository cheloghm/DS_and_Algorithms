using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms
{
    public class Find_nemo
    {
        StringBuilder sb = new StringBuilder();
        public void findNemo(string sb1)
        {
            for (int i = 0; i < sb1.Length; i++)
            {
                sb.Insert(i, sb1[i]);                
            }

            if (sb.ToString() == "nemo")
            {
                Console.WriteLine("Found NEMO");
            }
            else
            {
                Console.WriteLine("NEMO Not Found");
            }

        }

        public void findNemo2(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sb.Insert(j, arr[i][j]);
                }
                if (sb.ToString() != "nemo")
                {
                    sb.Clear();
                }
                else if (sb.ToString() == "nemo")
                {
                    Console.WriteLine("Found NEMO");
                    break;
                }
                else
                {
                    Console.WriteLine("NEMO Not Found");
                }
            }
        }
    }
}
