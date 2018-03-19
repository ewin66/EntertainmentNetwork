using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICinema : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal CinId { get; set; }
        [Required(AllowEmptyStrings = false)]
        string CinName { get; set; }
        [Required(AllowEmptyStrings = false)]
        string CinAddress { get; set; }
        byte[] CinIcon { get; set; }
        decimal CityId { get; set; }

        void Update(ICinema city);
    }
}
