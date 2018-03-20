using EntertainmentNetwork.DAL.Models;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.SeatService;
using EntertainmentNetwork.DAL.ShowService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class ShowServiceAdapter : Interfaces.IBaseService<IShow>
    {
        #region IBaseService<IShow>

        public async Task Add(Interfaces.IShow show)
        {
            await this.showService.addShowAsync(new addShowRequest
            {
               shwName = show.ShwName,
               shwDescr = show.ShwDesc,
               shwPerformer = show.ShwPerformer,
               shwIcon = show.ShwIcon
            });
        }

        public async Task<Interfaces.IShow> FindById(decimal id)
        {
            var result = await this.showService.findShowByIdAsync(id);
            return this.ToShow(result.@return);
        }

        public async Task<List<Interfaces.IShow>> GetAll()
        {
            var result = await this.showService.getShowsAsync();
            var show = result.@return;
            return show == null ? new List<Interfaces.IShow>() : show.Select(x => this.ToShow(x)).ToList();
        }

        public async Task<Interfaces.IShow> Merge(Interfaces.IShow show)
        {
            var result = await this.showService.mergeShowAsync(new mergeShowRequest
            {
                shwId = show.ShwId,
                shwIdSpecified = true,
                shwName = show.ShwName,
                shwDescr = show.ShwDesc,
                shwPerformer = show.ShwPerformer,
                shwIcon = show.ShwIcon
            });

            return this.ToShow(result.@return);        
        }

        public async Task Remove(decimal id)
        {
            await this.showService.removeShowAsync(id);
        }

        #endregion

        private Interfaces.IShow ToShow(show show)
        {
            return new Show(show.shwId, show.shwName, show.shwDescr, show.shwPerformer, show.shwIcon);
        }

        private readonly ShowServiceClient showService = new ShowServiceClient();
    }
}
