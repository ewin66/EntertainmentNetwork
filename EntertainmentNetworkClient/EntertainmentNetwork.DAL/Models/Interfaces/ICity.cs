using System;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICity : INotifyPropertyChanged
    {
        string CitCountry { get; set; }
        decimal CitId { get; set; }
        string CitName { get; set; }

        void Update(ICity city);
    }
}
