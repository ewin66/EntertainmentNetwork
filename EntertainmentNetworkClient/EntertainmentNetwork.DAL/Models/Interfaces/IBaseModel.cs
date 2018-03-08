using System;
namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IBaseModel
    {
        bool IsChanged { get; set; }
        bool IsNew { get; }
    }
}
