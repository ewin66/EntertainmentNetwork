using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.FloorService;

namespace EntertainmentNetwork.DAL
{
    public class FloorServiceAdapter : Interfaces.IFloorService
    {
        #region IFloorService

        public async Task Add(IFloor floor)
        {
            await this.floorService.addFloorAsync(new addFloorRequest
            {
                flrName = floor.FloorName,
                halId = floor.HallId,
                halIdSpecified = true,  
            });
        }

        public async Task<IFloor> FindById(decimal id)
        {
            var result = await this.floorService.findFloorByIdAsync(id);
            return this.ToFloor(result.@return);
        }

        public async Task<List<IFloor>> GetAll()
        {
            var result = await this.floorService.getFloorsAsync();
            return result.@return.Select(x => this.ToFloor(x)).ToList();
        }

        public async Task<IFloor> Merge(IFloor floor)
        {
            var result = await this.floorService.mergeFloorAsync(new mergeFloorRequest
            {
                flrId = floor.Id,
                flrIdSpecified = true,
                flrName = floor.FloorName,
                halId = floor.HallId,
                halIdSpecified = true,                
            });

            return this.ToFloor(result.@return);
        }

        public async Task Remove(decimal id)
        {
            await this.floorService.removeFloorAsync(id);
        }

        #endregion

        private IFloor ToFloor(floor floor)
        {
            return new Floor(floor.flrId, floor.flrName, floor.hallId);
        }

        private readonly FloorServiceClient floorService = new FloorServiceClient();
    }
}
