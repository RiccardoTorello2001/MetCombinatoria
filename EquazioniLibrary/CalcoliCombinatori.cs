using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        
        public static long Fattoriale(int num)
        {
            long fattoriale = 1;
            if (num != 0)
            {
                for (int i = 1; i < num; i++)
                {
                    fattoriale = fattoriale * i;
                }
            }
            else
            {
                fattoriale = 1;
            }
            return fattoriale;
        }
    }
}
