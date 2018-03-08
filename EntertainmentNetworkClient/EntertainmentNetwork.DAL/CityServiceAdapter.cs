
using System.Collections.Generic;
using System.Linq;
using EntertainmentNetwork.DAL.CityService;
using EntertainmentNetwork.DAL.Models.Interfaces;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class CityServiceAdapter : Interfaces.ICityService
    {
        private readonly CityServiceClient cityService = new CityServiceClient();

        #region ICityService

        public void AddCity(Interfaces.ICity city)
        {
            this.cityService.addCity(new addCityRequest
            {
                citCountry = city.CitCountry,
                citName = city.CitName
            });
        }

        public void RemoveCity(decimal id)
        {
            this.cityService.removeCity(id);
        }

        public ICity MergeCity(Interfaces.ICity city)
        {
            return this.ToCity(this.cityService.mergeCity(new mergeCityRequest 
            {
                citId = city.CitId,
                citCountry = city.CitCountry,
                citName = city.CitName,
                citIdSpecified = true
            }));
        }

        public ICity FindCityById(decimal id)
        {
            return this.ToCity(this.cityService.findCityById(id));
        }

        public List<ICity> FindByName(string name)
        {
            return this.cityService.findByName(name).Select(x => this.ToCity(x)).ToList();
        }

        public List<ICity> GetCities()
        {
            return this.cityService.getCities().Select(x => this.ToCity(x)).ToList();
        }

        #endregion

        private ICity ToCity(city city)
        {
            return new Models.City(city.citId, city.citName, city.citCountry);
        }
    }
}
