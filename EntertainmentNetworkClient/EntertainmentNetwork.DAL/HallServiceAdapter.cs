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
        #region IHallService

        public async Task Add(IHall hall)
        {
            await this.hallService.addHallAsync(new addHallRequest
            {
                halName = hall.HalName,
                halSitscount = hall.HalSitscount,
                halSitscountSpecified = true,
                cinId = hall.CinemaId,
                cinIdSpecified = true,
            });
        }

        public async Task<IHall> FindById(decimal id)
        {
            var result = await this.hallService.findHallByIdAsync(id);
            return this.ToHall(result.@return);
        }

        public async Task<List<IHall>> GetAll()
        {
            var result = await this.hallService.getHallsAsync();
            return result.@return.Select(x => this.ToHall(x)).ToList();
        }

        public async Task<IHall> Merge(IHall hall)
        {
            var result = await this.hallService.mergeHallAsync(new mergeHallRequest
            {
                halId = hall.Id,
                halIdSpecified = true,
                halName = hall.HalName,
                halSitscount = hall.HalSitscount,
                halSitscountSpecified = true,
                cinId = hall.CinemaId,
                cinIdSpecified = true,                
            });

            return this.ToHall(result.@return);
        }

        public async Task Remove(decimal id)
        {
            await this.hallService.removeHallAsync(id);
        }

        #endregion

        private IHall ToHall(hall hall)
        {
            return new Hall(hall.halId, hall.halName, hall.halSitscount, hall.cinemaId);
        }

        private readonly HallServiceClient hallService = new HallServiceClient();
    }
}
