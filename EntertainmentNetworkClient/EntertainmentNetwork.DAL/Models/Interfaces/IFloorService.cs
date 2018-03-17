using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IFloorService
    {
        Task AddFloor(IFloor seat);

        Task<IFloor> FindFloorById(decimal id);

        Task<List<IFloor>> GetFloors();

        Task<IFloor> MergeFloor(IFloor floor);

        Task RemoveFloor(decimal id);
    }
}
