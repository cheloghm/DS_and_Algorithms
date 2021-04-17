using System;

namespace DS_and_Algorithms
{
    class Program
    {
        const string Nemo = "nemo";
        public static string[] everyone = new string[] { "dory", "bruce", "marlin", "gill", "bloat", "nigel", "squirt", "darla", "hank" };
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Find_nemo nemo = new Find_nemo();

            var watch = new System.Diagnostics.Stopwatch();
            //nemo.findNemo(Nemo);
            nemo.findNemo2(everyone);
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
