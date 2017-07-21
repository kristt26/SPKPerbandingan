using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{

    public class TeoriMatematika:Alternative
    {
        private Criteria criteria = new Criteria();
       
       
        public TeoriMatematika(string name):base(name)
        {
            
        }

        public double Nilai { get; set; }

       
    }
}
