using System;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL.Models;
using System.Windows.Forms;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.BL.ViewModels
{
    public interface IViewsManager
    {
        Lazy<IViewModel<ICity>> CitiesView { get; }
        Lazy<IViewModel<ICinema>> CinemasView { get; }
        BindingSource CitiesBindingSource { get; }
        BindingSource CityViewBindingSource { get; }
        BindingSource CinemasBindingSource{ get; }
        BindingSource CinemaViewBindingSource { get; }
    }
}
