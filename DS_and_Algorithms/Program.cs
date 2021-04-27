using DS_and_Algorithms.DS_Arrays.Exercise;
using System;

namespace DS_and_Algorithms
{
    class Program
    {
        #region Find_nemo
        const string Nemo = "nemo";
        public static string[] everyone = new string[] { "dory", "bruce", "marlin", "gill", "bloat", "nigel", "squirt", "darla", "hank" };
        #endregion

        #region ContainsCommonItem
        public static char[] charArray1 = new char[] { 'a', 'b', 'c', 'x' };
        public static char[] charArray2 = new char[] { 'z', 'y', 'l' };

        public static string[] stringArray1 = new string[] { "car", "bus"};
        public static string[] stringArray2 = new string[] { "plane", "train" };

        public static int[] intArray1 = new int[] { 1, 2, 3, 4, 5 };
        public static int[] intArray2 = new int[] { 2, 7, 8, 6, 9 };
        #endregion

        #region Google interview question
        public static int[] GQarray = new int[] { 6, 3, 6, 4, 1, 2, 1, 7, 3 };
        #endregion
        static void Main(string[] args)
        {
            #region Uncomment for Find_nemo
            //Find_nemo nemo = new Find_nemo();

            //nemo.findNemo(Nemo);
            //nemo.findNemo2(everyone);
            #endregion

            #region Uncomment for ContainsCommonItem
            //ContainsCommonItem CommonItems = new ContainsCommonItem();
            //Console.WriteLine(CommonItems.ContainsCommonItems2<char>(charArray1, charArray2));
            //Console.WriteLine(CommonItems.ContainsCommonItems2<int>(intArray1, intArray1));
            //Console.WriteLine(CommonItems.ContainsCommonItems2<string>(stringArray1, stringArray2));
            //Console.WriteLine(CommonItems.ContainsCommonItems3<string>(stringArray1, stringArray2));
            //Console.WriteLine(CommonItems.ContainsCommonItems3<int>(intArray1, intArray2));
            #endregion

            #region Google interview question
            //GoogleQuestion question = new GoogleQuestion();
            //Console.WriteLine(question.HasPairWithSum2(GQarray, 9));
            #endregion

            #region String Reverse
            //StringReverse reverse = new StringReverse();
            //reverse.Reverse4("Graham is happy");
            #endregion

            #region Recurring Element
            //FirstRecurringElement FE = new FirstRecurringElement();
            //FE.RecurringElement(GQarray);
            #endregion

            #region Recurring Element
            MergeSortedArrays MS = new MergeSortedArrays();            
            MS.Sort(intArray1, intArray2);
            #endregion

        }
    }
}
