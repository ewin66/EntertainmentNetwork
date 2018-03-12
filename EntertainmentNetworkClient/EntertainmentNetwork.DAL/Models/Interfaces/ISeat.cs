using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ISeat : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal SeatId { get; set; }
        [Range(0, 9999)]
        int SeatNum { get; set; }
        [Range(0, 999)]
        int SeatRow { get; set; }
        [Range(0, 999)]
        int SeatFloor { get; set; }
        [Range(0, 10)]
        int SeatType { get; set; }
        decimal HallId { get; set; }
    }
}
