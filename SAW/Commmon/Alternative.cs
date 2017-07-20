using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
   public  class Alternative
    {
        public Alternative(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public  double Bobot { get; set; }
        public int Rank { get; set; }
    }
}



