using System;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL.Models;
using System.Windows.Forms;
using EntertainmentNetwork.DAL.Models.Interfaces;
using DevExpress.XtraBars.Docking2010;

namespace EntertainmentNetwork.BL.ViewModels
{
    public interface IViewsManager
    {
        DocumentManager MainDocumentManager { get; }
        Lazy<IViewModel<ICity>> CitiesView { get; }
        Lazy<IViewModel<ICinema>> CinemasView { get; }
        Lazy<IViewModel<IHall>> HallsView { get; }
        Lazy<IViewModel<IFloor>> FloorsView { get; }
        Lazy<ISeatViewModel> SeatsView { get; }
        Lazy<IViewModel<IShow>> ShowsView { get; }

        BindingSource CitiesBindingSource { get; }
        BindingSource CityViewBindingSource { get; }
        BindingSource CinemasBindingSource{ get; }
        BindingSource CinemaViewBindingSource { get; }
        BindingSource HallsBindingSource { get; }
        BindingSource HallViewBindingSource { get; }
        BindingSource FloorsBindingSource { get; }
        BindingSource FloorViewBindingSource { get; }
        BindingSource SeatsBindingSource { get; }
        BindingSource SeatViewBindingSource { get; }
        BindingSource ShowsBindingSource { get; }
        BindingSource ShowViewBindingSource { get; }
    }
}
