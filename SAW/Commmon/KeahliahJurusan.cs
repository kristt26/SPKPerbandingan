using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class KeahliahJurusan : Alternative
    {
        private Criteria criteria = new Criteria();
        private double _nilai;
        public KeahliahJurusan()
        {
            Ranks = new List<Range>
            {
                new Range("<70", 0, 70, 1, 0),
                new Range("71-80", 71, 80, 2, 0),
                new Range("81-90", 81, 90, 3, 0),
                new Range("91-100", 91, 100, 4, 0)
            };
        }

        public double Nilai
        {
            set
            {
                _nilai = value;
                this.Rank= Ranks.Where(O => O.Min <= value && O.Max >= value).FirstOrDefault().Rank;

            }
        }

        public List<Range> Ranks { get; private set; }
    }
}
