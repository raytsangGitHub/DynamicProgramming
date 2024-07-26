using System.Diagnostics;

namespace DynamicProgramming
{
    public class AccessDynamicProblem
    {
        private IEnumerable<FibBase> _accessFib;

        public AccessDynamicProblem(IEnumerable<FibBase> accessFib)
        {
            this._accessFib = accessFib;
        }

        //test data:
        private Dictionary<int, long> memo = new();

        private Stopwatch stopwatch = new Stopwatch();

        public void accessDP()
        {
            foreach (var servic in _accessFib)
            {
                int n = 7;
                //stopwatch.Start();
                Console.WriteLine($"\"the time Fibonacci sequence test No memo is : {servic.Fib(n)}");  //fib no memo
                //stopwatch.Stop();
                //TimeSpan elapsed = stopwatch.Elapsed;
                //Console.WriteLine($"the time Fibonacci sequence test no memo is : {elapsed}");

                //Console.WriteLine($"\"the time Fibonacci sequence test with memo is : {servic.Fib(n,memo)}");
                //uint m = 4;
                //Console.WriteLine($"\"the time Fibonacci sequence test with tabu is : {servic.FibTabu(m)}");
            }
        }
    }
}