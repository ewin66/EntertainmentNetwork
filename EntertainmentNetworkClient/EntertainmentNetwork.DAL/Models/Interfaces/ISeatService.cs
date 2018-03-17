using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ISeatService
    {
        Task AddSeat(ISeat seat);

        Task<ISeat> FindSeatById(decimal id);

        Task GenerateSeats(decimal flrId, int seatRows, int seatColumns);

        Task<List<ISeat>> GetSeats();

        Task<ISeat> MergeSeat(ISeat seat);

        Task RemoveSeat(decimal id);
    }
}
