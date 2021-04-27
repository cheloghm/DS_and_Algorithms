using System;
using System.Collections.Generic;
using System.Text;

namespace DS_and_Algorithms.DS_Arrays.Exercise
{
    public class StringReverse
    {
        #region First solution
        public string Reverse(string data)
        {
            var newString = "";
            for (int i = data.Length - 1; i >= 0; i--)
                newString += data[i];
            return newString;
        }
        #endregion

        #region Second Solution
        public string Reverse2(string data)
        {
            var newString = new StringBuilder();
            for (int i = data.Length - 1; i >= 0; i--)
                newString.Append(data[i]);
            return newString.ToString();
        }
        #endregion

        #region Third Solution
        public string Reverse3(string data)
        {
            var newString = "";
            if (data.Length < 2 || data.GetType() != typeof(string))
                return "Invalid input!";
            else
            {
                for (int i = data.Length - 1; i >= 0; i--)
                    newString += data[i];
                return newString;
            }
        }
        #endregion

        #region Fourth solution
        public void Reverse4(string data)
        {
            var newArray = data.ToCharArray();
            Array.Reverse(newArray);
            Console.WriteLine(newArray);
        }
        #endregion
    }
}
