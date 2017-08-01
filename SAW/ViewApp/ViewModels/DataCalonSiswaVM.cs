using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewApp.ViewModels
{
    public class DataCalonSiswaVM
    {
        public DataCalonSiswaVM()
        {
            TambahCommand = new CommandHandler();
            TambahCommand.CanExecuteAction = TambahCommandValidate;
            TambahCommand.ExecuteAction = x => TambahCommandAction();
        }

        private void TambahCommandAction()
        {
            var form = new Pages.TambahDataSiswa();
            var vm = new ViewModels.TambahDataSiswaVM() { WindowClose=form.Close};
            form.DataContext = vm;
            form.ShowDialog();
        }

        private bool TambahCommandValidate(object obj)
        {
            return true;
        }

        public CommandHandler TambahCommand { get; private set; }
        
    }
}
