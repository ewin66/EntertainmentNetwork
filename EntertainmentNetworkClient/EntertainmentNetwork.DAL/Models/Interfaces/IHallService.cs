using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IHallService
    {
        Task AddHall(IHall hall);

        Task<IHall> FindHallById(decimal id);

        Task<List<IHall>> GetHalls();

        Task<IHall> MergeHall(IHall hall);

        Task RemoveHall(decimal id);
    }
}
