using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ISit : IBaseModel, INotifyPropertyChanged
    {
        decimal CinemaId { get; set; }
        decimal SitFloor { get; set; }
        decimal SitId { get; set; }
        decimal SitNum { get; set; }
        decimal SitRow { get; set; }
        decimal SitType { get; set; }
    }
}
