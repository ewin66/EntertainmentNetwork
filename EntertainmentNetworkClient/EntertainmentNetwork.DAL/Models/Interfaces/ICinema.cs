using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICinema : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal CinId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "The value cannot exceed 100 characters.")]
        string CinName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(255, ErrorMessage = "The value cannot exceed 255 characters.")]
        string CinAddress { get; set; }
        byte[] CinIcon { get; set; }
        decimal CityId { get; set; }
    }
}
