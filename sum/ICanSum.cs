﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Sum
{
    public interface ICanSum
    {
        public int Sum(int[] num, int target);
    }
}