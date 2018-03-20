using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class CinemasViewModel : BaseViewModel<ICinemaService, ICinema>
    {
        public CinemasViewModel(ICinemaService dataService) : base(dataService)
        {
        }
    }
}
