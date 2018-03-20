using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ISeatService : IBaseService<ISeat>
    {
        Task GenerateSeats(decimal flrId, int seatRows, int seatColumns);
    }
}
