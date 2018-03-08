using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IHall : IBaseModel, INotifyPropertyChanged
    {
        decimal CinemaId { get; set; }
        decimal HalId { get; set; }
        string HalName { get; set; }
        decimal HalSitscount { get; set; }
        ISit[] Sits { get; set; }
    }
}
