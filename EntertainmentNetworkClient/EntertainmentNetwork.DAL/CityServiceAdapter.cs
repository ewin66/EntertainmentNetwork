
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.CityService;
using EntertainmentNetwork.DAL.Models.Interfaces;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class CityServiceAdapter : Interfaces.ICityService
    {
        private readonly CityServiceClient cityService = new CityServiceClient();

        #region ICityService

        public async Task AddCity(Interfaces.ICity city)
        {
            await this.cityService.addCityAsync(new addCityRequest
            {
                citCountry = city.CitCountry,
                citName = city.CitName
            });
        }

        public async Task RemoveCity(decimal id)
        {
            await this.cityService.removeCityAsync(id);
        }

        public async Task<ICity> MergeCity(Interfaces.ICity city)
        {
            var result = await this.cityService.mergeCityAsync(new mergeCityRequest 
            {
                citId = city.CitId,
                citCountry = city.CitCountry,
                citName = city.CitName,
                citIdSpecified = true
            });

            return this.ToCity(result.@return);
        }

        public async Task<ICity> FindCityById(decimal id)
        {
            var result = await this.cityService.findCityByIdAsync(id);
            return this.ToCity(result.@return);
        }

        public async Task<List<ICity>> FindByName(string name)
        {
            var result = await this.cityService.findByNameAsync(name);
            return result.@return.Select(x => this.ToCity(x)).ToList();
        }

        public async Task<List<ICity>> GetCities()
        {
            var result = await this.cityService.getCitiesAsync();
            return result.@return.Select(x => this.ToCity(x)).ToList();
        }

        #endregion

        private ICity ToCity(city city)
        {
            return new Models.City(city.citId, city.citName, city.citCountry);
        }
    }
}
