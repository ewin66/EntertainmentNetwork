using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.HallService;

namespace EntertainmentNetwork.DAL
{
    public class HallServiceAdapter : Interfaces.IHallService
    {
        private readonly HallServiceClient hallService = new HallServiceClient();

        #region IHallService

        public async Task AddHall(IHall hall)
        {
            await hallService.addHallAsync(new addHallRequest
            {
                halName = hall.HalName,
                halSitscount = hall.HalSitscount,
                halSitscountSpecified = true,
                cinId = hall.CinemaId,
                cinIdSpecified = true,
            });
        }

        public async Task<IHall> FindHallById(decimal id)
        {
            var result = await this.hallService.findHallByIdAsync(id);
            return this.ToHall(result.@return);
        }

        public async Task<List<IHall>> GetHalls()
        {
            var result = await this.hallService.getHallsAsync();
            return result.@return.Select(x => this.ToHall(x)).ToList();
        }

        public async Task<IHall> MergeHall(IHall hall)
        {
            var result = await this.hallService.mergeHallAsync(new mergeHallRequest
            {
                halId = hall.HalId,
                halIdSpecified = true,
                halName = hall.HalName,
                halSitscount = hall.HalSitscount,
                halSitscountSpecified = true,
                cinId = hall.CinemaId,
                cinIdSpecified = true,                
            });

            return this.ToHall(result.@return);
        }

        public async Task RemoveHall(decimal id)
        {
            await this.hallService.removeHallAsync(id);
        }

        #endregion

        private IHall ToHall(hall hall)
        {
            return new Hall(hall.halId, hall.halName, hall.halSitscount, hall.cinemaId);
        }
    }
}
