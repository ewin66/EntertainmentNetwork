using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.BL.ViewModels;

namespace EntertainmentNetwork.BL.Commands
{
    internal class AddUpdateCommand : ICommand
    {
        public AddUpdateCommand(ICitiesViewModel viewModel)
        {
            this.vm = viewModel;
            this.vm.PropertyChanged += vm_PropertyChanged;
        }

        private void vm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Compare(e.PropertyName, CitiesViewModel.SELECTED_CITY_PROPERRTY_NAME) == ARE_EQUAL)
            {
                this.CanExecuteChanged(this, new EventArgs());
            }
        }

        public bool CanExecute(object parameter)
        {
            return vm.SelectedCity != null;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public void Execute(object parameter)
        {
            vm.AddUpdateCity();
        }

        private const int ARE_EQUAL = 0;
        private const int NONE_SELECTED = -1;
        private ICitiesViewModel vm;
    }
}
