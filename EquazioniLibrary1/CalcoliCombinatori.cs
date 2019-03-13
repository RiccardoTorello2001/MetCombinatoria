using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary1
{
    public class CalcoliCombinatori
    {

        public static long Fatt(long num)
        {
            long fact = num;

            if (num != 0)
            {
                for (long i = 1; i < num; i++)
                {
                    fact = fact * i;
                }
            }
            else
                fact = 1;

            return fact;
        }
    }
}
