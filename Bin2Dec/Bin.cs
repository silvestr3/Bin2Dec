using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    class Bin
    {
        public string Binary { get; set; }

        public Bin(string bin)
        {
            this.Binary = bin;
        }

        public static bool ValidBin(string bin)
        {
            foreach(char c in bin)
            {
                if(c != '1' && c != '0')
                {
                    return false;
                }
            }
            if(bin.Length != 8)
            {
                return false;
            }

            return true;
        }
    }
}
