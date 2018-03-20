using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IFloor : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal FloorId { get; set; }
        decimal HallId { get; set; }
        string FloorName { get; set; }
    }
}
