using DynamicProgramming.Word;
using Microsoft.Extensions.DependencyInjection;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DI container
            var serviceDP = new ServiceCollection()
                .AddScoped<FibBase>(x => new FibNonMemo())
                .AddScoped<FibBase>(x => new FibWithMemo())
                .AddScoped<FibBase>(x => new FibTabulation())
                //.AddScoped<FibBase>(x => new Travel2DGrid())
                .AddScoped<AccessDynamicProblem>()
                .BuildServiceProvider();

            var serviceRef = serviceDP.GetService<AccessDynamicProblem>();
            serviceRef.accessDP();

            #endregion DI container

            #region Word dp problems
            var serviceWordBreak = new ServiceCollection()
               .AddScoped<IWordBreak>(x => new WordBreak_139())
               //.AddScoped<FibBase>(x => new FibWithMemo())
               //.AddScoped<FibBase>(x => new FibTabulation())
               //.AddScoped<FibBase>(x => new Travel2DGrid())
               .AddScoped<AccessWordProblem>()
               .BuildServiceProvider();

            var serviceWord = serviceWordBreak.GetService<AccessWordProblem>();

            serviceWord.accessWordBreak();
            #endregion Word dp problems

            //the first two fibonacci serier is 1. f(0)=1, f(1)=1.
            //    #region Fibonacci sequence test no memo
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();
            //    Console.WriteLine(Fib(7));
            //    stopwatch.Stop();
            //    TimeSpan elapsed = stopwatch.Elapsed;
            //    Console.WriteLine($"the time Fibonacci sequence test no memo is : {elapsed}");
            //    #endregion

            //    #region Fibonacci sequence test with memo
            //    var memo  = new Dictionary<int, long>();  //note: to calculate large number, a long type is needed
            //   //Console.WriteLine(FibMemo(4, memo));  //expected 3
            //   // Console.WriteLine(Fib(7));//13
            //   // Console.WriteLine(FibMemo(0, memo)); //0
            //   // Console.WriteLine(FibMemo(9, memo)); //34
            //   stopwatch.Restart();

            //    long result = FibMemo(7, memo);
            //    stopwatch.Stop();
            //    TimeSpan elapsedMemo = stopwatch.Elapsed;
            //    Console.WriteLine(result);
            //    Console.WriteLine($"the time Fibonacci sequence test with memo is : {elapsedMemo}");
            //    #endregion

            #region Fib sequence Tabulation
            FibTabulation tabulation = new FibTabulation();

            //expected: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
            /// n =     0, 1, 2, 3, 4, 5, 6, 7,  8,  9, 10, 11,  12
            uint[] input = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine($"Tabulation fib result of:");
            foreach (var x in input)
            {
                Console.Write($"{x},");
            }
            Console.WriteLine();
            foreach (var t in input)
            {
                //Console.Write($"{t}");
                uint resultTab = tabulation.FibTabu(t);
                Console.Write($"{resultTab},");
            }
            //uint t = 9;

            Console.WriteLine();
            #endregion Fib sequence Tabulation

            //    #region travel a 2D grid
            //    //var memo = new Dictionary<string, long>();
            //    //Console.WriteLine(Travel2DGrid.GridTravelerMemo(9, 8, memo));
            //    // Console.WriteLine(Travel2DGrid.GridTravelerMemo(18, 18, memo));
            //    //long result = Travel2DGrid.GridTravelerMemo(18, 18, memo);
            //    //Console.WriteLine(result);
            //    #endregion

            //    #region canSum
            //    // var numb = new int[] { };
            //    var memo1 = new Dictionary<int, bool>();
            //    // bool result = CanSumFromArray.canSum(7, new int[] { 2, 3 });
            //    // Console.WriteLine(CanSumFromArray.canSum(7, new int[] { 2, 3 })); //true
            //    Console.WriteLine(CanSumFromArray.canSum(7, new int[] { 5, 3, 4, 7 }, memo1)); //true
            //    memo1.Clear();
            //    Console.WriteLine(CanSumFromArray.canSum(7, new int[] { 2, 4 }, memo1)); // false
            //    //Console.WriteLine(CanSumFromArray.canSum(8, new int[] { 2, 3, 5 },memo1)); //true
            //    memo1.Clear();
            //    Console.WriteLine(CanSumFromArray.canSum(300, new int[] { 7, 14 }, memo1)); //false

            //    #endregion

            //}
            //#region Fibonacci sequence
            ///// <summary>
            ///// Fibonacci sequence 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
            ///// n=                 0, 1, 2, 3, 4, 5, 6, 7,   8,  9, 10, 11,  12
            ///// </summary>
            ///// <param name="n"></param>
            ///// <returns></returns>
            //public static int Fib(int n)
            //{
            //    if (n <= 2) return 1;

            //    return Fib(n - 1) + Fib(n - 2);
            //}
            ///// <summary>
            ///// The above fib(n) take too long to caculate, to improve performance, using memoization by adding extra paramenter, using Dictionary as look up table to reduce redundance steps.
            ///// </summary>
            ///// <param name="n"></param>
            ///// <param name="memo"></param>
            ///// <returns></returns>
            //public static long FibMemo(int n, Dictionary<int, long>  memo)
            //{
            //    //return to the recursive call if exist. but not to the caller.
            //    if (memo.ContainsKey(n))
            //        return memo[n];
            //    //base case
            //    if (n == 0) return 0;
            //    if (n == 1) return 1;
            //    //store memo
            //    memo[n] = FibMemo(n - 1, memo) + FibMemo(n - 2,  memo);
            //    return memo[n];
            //}
            //#endregion Fibonacci sequence
        }
    }
}