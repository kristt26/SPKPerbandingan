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
            var c2 = new Criteria { Id = 2, Code = "C2", Bobot = 0.25 };
            var c3 = new Criteria { Id = 3, Code = "C3", Bobot = 0.1 };
            var c4 = new Criteria { Id = 4, Code = "C4", Bobot = 0.1 };
            var c5 = new Criteria { Id = 5, Code = "C5", Bobot = 0.1 };
            var c6 = new Criteria { Id = 6, Code = "C6", Bobot = 0.1 };
            var c7 = new Criteria { Id = 7, Code = "C7", Bobot = 0.1 };

            //instance  Alterntive and inisialisasi to criteria 
            c1.Alternatives = new ObservableCollection<Alternative>();
            c2.Alternatives = new ObservableCollection<Alternative>();
            c3.Alternatives = new ObservableCollection<Alternative>();
            c4.Alternatives = new ObservableCollection<Alternative>();
            c5.Alternatives = new ObservableCollection<Alternative>();
            c6.Alternatives = new ObservableCollection<Alternative>();
            c7.Alternatives = new ObservableCollection<Alternative>();


            //Inisialisasi Criteria To  Criterias
            Cristerias.Add(c1);
            Cristerias.Add(c2);
            Cristerias.Add(c3);
            Cristerias.Add(c4);
            Cristerias.Add(c5);
            Cristerias.Add(c6);
            Cristerias.Add(c7);



            return Cristerias;
        }

        public static Criteria GetById(int id)
        {
          return  CriteriasCollection.Get().Where(O => O.Id == id).FirstOrDefault();
        }
    }
}
