using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.BL.Commands
{
    internal class GenerateCommand : ICommand
    {
        public GenerateCommand(ISeatViewModel viewModel)
        {
            this.vm = viewModel;
            this.vm.PropertyChanged += vm_PropertyChanged;
        }

        private void vm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Compare(e.PropertyName, selectedPropertyName) == ARE_EQUAL)
            {
                this.CanExecuteChanged(this, new EventArgs());
            }
        }

        public bool CanExecute(object parameter)
        {
            return vm.Selected != null;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public async void Execute(object parameter)
        {
            await vm.Generate(parameter);
        }

        private const int ARE_EQUAL = 0;
        private const int NONE_SELECTED = -1;
        private ISeatViewModel vm;
        public const string selectedPropertyName = "Selected";
    }
}
