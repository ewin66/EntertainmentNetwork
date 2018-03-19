using EntertainmentNetwork.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntertainmentNetwork.BL.Interfaces
{
    public interface ISeatViewModel : IViewModel<ISeat>
    {
        event EventHandler SeatsMapGenerated;

        DataTable SeatsMap { get; }
        ICommand GenerateCommand { get; }

        Task Generate(object paramter);
    }
}
