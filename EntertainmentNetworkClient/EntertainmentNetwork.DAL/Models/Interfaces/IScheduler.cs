using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IScheduler : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal SchId { get; set; }
        [StringLength(100, ErrorMessage = "The value cannot exceed 100 characters.")]
        [Required(AllowEmptyStrings = false)]
        string SchName { get; set; }
        [StringLength(255, ErrorMessage = "The value cannot exceed 255 characters.")]
        string SchDescr { get; set; }
        DateTime SchTimeFrom { get; set; }
        DateTime SchTimeTo { get; set; }
        decimal HallId { get; set; }
        decimal ShowId { get; set; }      
    }
}
