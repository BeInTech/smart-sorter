using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSorter
{
    public class NumberDTO
    {
        public int Num { get; set; }
        public int Count { get; set; }

        public NumberDTO(int num)
        {
            Num = num;
            Count = 1;
        }
    }
}
