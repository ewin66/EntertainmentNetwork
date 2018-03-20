using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICity : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal CitId { get; set; }
        [Required(AllowEmptyStrings = false)]
        string CitName { get; set; }
        [Required(AllowEmptyStrings = false)]
        string CitCountry { get; set; }
    }
}
