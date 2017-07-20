using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{

    public class Range
    {
        public Range(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }

        public double Min { get; set; }
        public double Max { get; set; }
    }
}
