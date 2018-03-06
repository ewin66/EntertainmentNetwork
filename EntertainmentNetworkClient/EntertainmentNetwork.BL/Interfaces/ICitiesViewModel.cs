using EntertainmentNetwork.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.BL.Interfaces
{
    interface ICitiesViewModel : INotifyPropertyChanged
    {
        ICity SelectedCity { get; set; }
        void AddUpdateCity();
        void LoadData();
        void RemoveCity();
    }
}
