using System;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IBaseModel
    {
        bool IsChanged { get; set; }
        bool IsNew { get; }

        [ReadOnly(true)]
        decimal Id { get; set; }

        void Update(IBaseModel model);
    }
}
