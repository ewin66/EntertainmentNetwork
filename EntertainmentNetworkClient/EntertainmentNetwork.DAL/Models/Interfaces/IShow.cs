using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IShow : IBaseModel, INotifyPropertyChanged
    {
        [ReadOnly(true)]
        decimal ShwId { get; set; }
        [StringLength(100, ErrorMessage = "The value cannot exceed 100 characters.")]
        [Required(AllowEmptyStrings = false)]
        string ShwName { get; set; }
        [StringLength(255, ErrorMessage = "The value cannot exceed 255 characters.")]
        string ShwDesc { get; set; }
        [StringLength(100, ErrorMessage = "The value cannot exceed 100 characters.")]
        string ShwPerformer { get; set; }    
        byte[] ShwIcon { get; set; }      
    }
}
