using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICityService
    {
        Task AddCity(ICity transientInstance);

        Task RemoveCity(decimal id);

        Task<ICity> MergeCity(ICity detachedInstance);

        Task<ICity> FindCityById(decimal id);

        Task<List<ICity>> FindByName(string name);

        Task<List<ICity>> GetCities();      
    }
}
