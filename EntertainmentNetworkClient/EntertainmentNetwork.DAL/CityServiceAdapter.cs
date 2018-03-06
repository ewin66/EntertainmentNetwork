
using System.Collections.Generic;
using System.Linq;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.CityService;

namespace EntertainmentNetwork.DAL
{
    public class CityServiceAdapter : Interfaces.ICityService
    {
        private readonly CityServiceClient cityService = new CityServiceClient();

        #region ICityService

        public void AddCity(Interfaces.ICity city)
        {
            cityService.addCity(new addCityRequest
            {
                citCountry = city.CitCountry,
                citName = city.CitName
            });
        }

        public void RemoveCity(decimal id)
        {
            cityService.removeCity(id);
        }

        public Models.City MergeCity(Interfaces.ICity city)
        {
            return this.ToCity(cityService.mergeCity(new mergeCityRequest 
            {
                citId = city.CitId,
                citCountry = city.CitCountry,
                citName = city.CitName,
                citIdSpecified = true
            }));
        }

        public Models.City FindCityById(decimal id)
        {
            return this.ToCity(cityService.findCityById(id));
        }

        public List<Models.City> FindByName(string name)
        {
            return cityService.findByName(name).Select(x => this.ToCity(x)).ToList();
        }

        public List<Models.City> GetCities()
        {
            return cityService.getCities().Select(x => this.ToCity(x)).ToList();
        }

        #endregion

        private Models.City ToCity(city city)
        {
            return new Models.City(city.citId, city.citName, city.citCountry);
        }
    }
}
