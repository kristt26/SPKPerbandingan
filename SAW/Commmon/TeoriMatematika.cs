using Commmon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class TeoriMatematika : Alternative
{
    private Criteria criteria = new Criteria();
    private double _nilai;

    public TeoriMatematika(string name) : base(name)
    {
        Ranks = new List<Range>();
        Ranks.Add(new Range("0-50",0, 50,1,0));
    }

    public double Nilai
    {
        set
        {
            _nilai = value;
            this.Rank = Ranks.Where(O => O.Min >= value && O.Max <= value).FirstOrDefault().Rank;

        }
    }
    //test
    public List<Range> Ranks { get; private set; }

   
}