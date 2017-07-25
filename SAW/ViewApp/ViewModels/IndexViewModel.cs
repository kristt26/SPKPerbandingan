using Commmon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ViewApp.ViewModels
{
  public  class IndexViewModel
    {
        public ObservableCollection<SiswaMatriks> Siswas { get; set; }
        public CollectionView SourceView { get; set; }
        public SiswaMatriks Selected { get; set; }
        public CommandHandler RefreshCommand { get; private set; }

        public IndexViewModel()
        {
            RefreshCommand = new CommandHandler { CanExecuteAction = RefreshValidation, ExecuteAction = RefreshAction };
            var data =  new TOPSIS.TopsisLib().Matriks_Y();
            Siswas = new ObservableCollection<SiswaMatriks>();

            foreach(var item in data)
            {
                Siswas.Add(item);
            }



            SourceView = (CollectionView)CollectionViewSource.GetDefaultView(Siswas);
            SourceView.Refresh();
        }

        private void RefreshAction(object obj)
        {
            Siswas.Clear();
            var newdatas = new SAW.SimpleAdditiveWeighting().MatriksNormal();
            foreach (var item in newdatas)
            {
                Siswas.Add(item);
            }

            SourceView.Refresh();
        }

        private bool RefreshValidation(object obj)
        {
            if (Siswas.Count > 0)
                return true;

            return false;
        }

        public void Save()
        {
           
        }
    }
}
