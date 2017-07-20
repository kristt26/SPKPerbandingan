using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
   public static class CriteriasCollection
    {
		public static ObservableCollection<Criteria> Get()
        {
            var Cristerias = new ObservableCollection<Criteria>();
            
            //instance Criteria 
            var c1 = new Criteria { Id = 1, Code = "C1", Bobot = 0.25 };

            //instance  Alterntive and inisialisasi to criteria 
            c1.Alternatives = new ObservableCollection<Alternative>();
           

            //Inisialisasi Criteria To  Criterias
            Cristerias.Add(c1);
           


            return Cristerias;
        }

        public static Criteria GetById(int id)
        {
          return  CriteriasCollection.Get().Where(O => O.Id == id).FirstOrDefault();
        }
    }
}
