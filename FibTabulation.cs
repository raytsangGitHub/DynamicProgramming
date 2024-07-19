using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class FibTabulation : FibBase
    {
        public override uint FibTabu(uint n)
        {
            if (n == 0) { return 0; }
            
            //idea: always add 1 to make the initial array length n+1.
            uint[] tab = new uint[n + 1] ;
            Array.Fill<uint>(tab, 0);  //fill array with 0
            tab[1] = 1;  //base case 

            //tabulation uses iterative, starting at array index 2.
            for (int i = 2; i < tab.Length; i++)
            {
                tab[i] = tab[i - 1] + tab[i - 2]; //i
            }
            return tab[n];

        }

        /// <summary>
        /// Try tenary operator, it can't be done, because it only allow expression, no statement
        /// </summary>
        public int FibTabTenaryOp(uint n) => n == 0 ? 0 : 5+4;
        
    }
}
