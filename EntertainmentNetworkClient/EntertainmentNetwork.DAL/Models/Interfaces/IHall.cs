using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IHall : IBaseModel, INotifyPropertyChanged
    {       
        decimal CinemaId { get; set; }
        [ReadOnly(true)]
        decimal HalId { get; set; }
        [Required(AllowEmptyStrings = false)]
        string HalName { get; set; }
        decimal HalSitscount { get; set; }

        void Update(IHall hall);
    }
}
