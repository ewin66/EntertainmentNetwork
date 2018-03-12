using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ISitService
    {
        Task AddSit(ISeat seat);

        Task<ISeat> FindSitById(decimal id);

        Task<List<ISeat>> GetSits();

        Task<ISeat> MergeSit(ISeat seat);

        Task RemoveSit(decimal id);
    }
}
