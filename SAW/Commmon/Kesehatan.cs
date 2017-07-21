using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class Kesehatan: Alternative
    {
        private Criteria criteria = new Criteria();
        private StatusKesehatan _nilai;
        public Kesehatan()
        {
            Ranks = new List<Range>
            {
                new Range("0-50", 0, 50, 0, 0),
                new Range("51-60", 51, 60, 1, 0),
                new Range("61-70", 61, 70, 2, 0)
            };
        }

        public StatusKesehatan Nilai
        {
            set
            {
                _nilai = value;
                if (_nilai == StatusKesehatan.Tidak)
                    this.Rank = 0;
                else if (_nilai == StatusKesehatan.Sehat)
                    this.Rank = 1;
                else
                    this.Rank = 2;
                    

            }
        }

        public List<Range> Ranks { get; private set; }
    }
}
