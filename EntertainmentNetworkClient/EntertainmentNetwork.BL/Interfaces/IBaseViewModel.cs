using EntertainmentNetwork.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntertainmentNetwork.BL.Interfaces
{
    public interface IViewModel<T> : INotifyPropertyChanged where T : IBaseModel
    {
        bool IsDataLoaded { get; }
        BindingList<T> Models { get; }
        T Selected { get; set; }      
        ICommand AddUpdateCommand { get; }
        ICommand RemoveCommand { get; }

        void AddUpdate();
        void LoadData(Func<T, bool> filter);
        void Remove();
    }
}
