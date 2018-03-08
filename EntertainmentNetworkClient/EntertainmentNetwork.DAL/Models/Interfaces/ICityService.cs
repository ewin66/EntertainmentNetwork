using System.Collections.Generic;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICityService
    {
        void AddCity(ICity transientInstance);

        void RemoveCity(decimal id);

        ICity MergeCity(ICity detachedInstance);

        ICity FindCityById(decimal id);

        List<ICity> FindByName(string name);

        List<ICity> GetCities();      
    }
}
