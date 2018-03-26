using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.SchedulerService;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;

namespace EntertainmentNetwork.DAL
{
    public class SchedulerServiceAdapter : IBaseService<IScheduler>
    {
        #region IBaseService<IScheduler>

        public async Task Add(IScheduler model)
        {
            await this.schedulerService.addSchedulerAsync(new addSchedulerRequest
            {
                halId = model.HallId,
                halIdSpecified = true,
                schName = model.SchName,
                schDescr = model.SchDescr,              
                schTimeFrom = model.SchTimeFrom,
                schTimeFromSpecified = true,
                schTimeTo = model.SchTimeTo,             
                schTimeToSpecified = true,
                shwId = Convert.ToDecimal(model.ShowId),
                shwIdSpecified = true
            });
        }

        public async Task Remove(decimal id)
        {
            await this.schedulerService.removeSchedulerAsync(id);
        }

        public async Task<IScheduler> Merge(IScheduler model)
        {
            var result = await this.schedulerService.mergeSchedulerAsync(new mergeSchedulerRequest
            {
                schId = model.SchId,
                schIdSpecified = true,
                halId = model.HallId,
                halIdSpecified = true,
                schName = model.SchName,
                schDescr = model.SchDescr,  
                schTimeFrom = model.SchTimeFrom,
                schTimeFromSpecified = true,
                schTimeTo = model.SchTimeTo,             
                schTimeToSpecified = true,
                shwId = Convert.ToDecimal(model.ShowId),
                shwIdSpecified = true          
            });

            return this.ToScheduler(result.@return);
        }

        public async Task<IScheduler> FindById(decimal id)
        {
            var result = await this.schedulerService.findSchedulerByIdAsync(id);
            return this.ToScheduler(result.@return);
        }

        public async Task<List<IScheduler>> GetAll()
        {
            var result = await this.schedulerService.getSchedulersAsync();
            return result.@return.Select(x => this.ToScheduler(x)).ToList();
        }

        #endregion

        private IScheduler ToScheduler(scheduler scheduler)
        {
            return new Scheduler(scheduler.schId, scheduler.schName, scheduler.schDescr, scheduler.schTimeFrom, scheduler.schTimeTo, scheduler.hallId, scheduler.showId);
        }

        private readonly SchedulerServiceClient schedulerService = new SchedulerServiceClient();
    }
}
