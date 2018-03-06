using System.Collections.Generic;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICityService
    {
        void AddCity(ICity transientInstance);

        void RemoveCity(decimal id);

        City MergeCity(ICity detachedInstance);

        City FindCityById(decimal id);

        List<City> FindByName(string name);

        List<City> GetCities();      
    }
}
