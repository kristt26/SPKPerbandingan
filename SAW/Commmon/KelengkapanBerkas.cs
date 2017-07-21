using Commmon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class KelengkapanBerkas : Alternative
{
    private Criteria criteria = new Criteria();
    private double _nilai;
    public KelengkapanBerkas(string name) : base(name)
    {
        Ranks = new List<Range>();
        Ranks.Add(new Range("0-50", 0, 50, 0, 0));
        Ranks.Add(new Range("0-100", 51, 10, 1, 0));
    }

    public double Nilai
    {
        set
        {
            _nilai = value;
            this.Bobot = Ranks.Where(O => O.Min >= value && O.Max <= value).FirstOrDefault().Rank;

        }
    }

    public List<Range> Ranks { get; private set; }
}
