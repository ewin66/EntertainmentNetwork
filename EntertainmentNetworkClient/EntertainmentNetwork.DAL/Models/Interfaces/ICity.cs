using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICity : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal CitId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "The value cannot exceed 100 characters.")]
        string CitName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "The value cannot exceed 100 characters.")]
        string CitCountry { get; set; }
    }
}
