using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class Wawancara : Alternative
    {
        private Criteria criteria = new Criteria();
        private StatusWawancara _nilai;

        public Wawancara()
        {
           
        }

        public StatusWawancara Nilai
        {
            set
            {
                _nilai = value;
                if (_nilai == StatusWawancara.Tidak)
                    this.Rank = 1;
                else if (_nilai == StatusWawancara.Kurang)
                    this.Rank = 2;
                else if (_nilai == StatusWawancara.Cukup)
                    this.Rank = 3;
                else
                    this.Rank = 4;

            }
        }

        public List<Range> Ranks { get; private set; }
    }
}
