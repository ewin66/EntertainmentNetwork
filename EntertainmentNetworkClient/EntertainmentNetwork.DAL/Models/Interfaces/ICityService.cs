using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICityService : IBaseService<ICity>
    {
        Task<List<ICity>> FindByName(string name);
    }
}
