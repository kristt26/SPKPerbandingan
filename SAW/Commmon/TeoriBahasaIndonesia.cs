using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class TeoriBahasaIndonesia : Alternative
    {
        private Criteria criteria = new Criteria();
        private double _nilai;

        public TeoriBahasaIndonesia()
        {
            Ranks = new List<Range>
            {
                new Range("0-50", 0, 50, 0, 0),
                new Range("51-60", 51, 60, 0, 1),
                new Range("61-70", 61, 70, 0, 2),
                new Range("71-80", 71, 80, 0, 3),
                new Range("81-90", 81, 90, 0, 4),
                new Range("91-100", 91, 100, 0, 5)
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

        public static implicit operator TeoriBahasaIndonesia(double v)
        {
            throw new NotImplementedException();
        }
    }
}
