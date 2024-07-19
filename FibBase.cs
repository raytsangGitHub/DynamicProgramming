﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public abstract class FibBase
    {
        public virtual int Fib(int n) { return 0; }
        public virtual long Fib(int n, Dictionary<int, long> memo) {  return 0; }
        public virtual uint FibTabu(uint n) { return 0; }

       // public virtual long GridTravelerMemo(int n, int m, Dictionary<string, long> memo) { return 0; }

    }
}