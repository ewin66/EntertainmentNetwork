
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
        #region ICityService

        public async Task Add(Interfaces.ICity city)
        {
            await this.cityService.addCityAsync(new addCityRequest
            {
                citCountry = city.CitCountry,
                citName = city.CitName
            });
        }

        public async Task Remove(decimal id)
        {
            await this.cityService.removeCityAsync(id);
        }

        public async Task<ICity> Merge(Interfaces.ICity city)
        {
            var result = await this.cityService.mergeCityAsync(new mergeCityRequest 
            {
                citId = city.Id,
                citCountry = city.CitCountry,
                citName = city.CitName,
                citIdSpecified = true
            });

            return this.ToCity(result.@return);
        }

        public async Task<ICity> FindById(decimal id)
        {
            var result = await this.cityService.findCityByIdAsync(id);
            return this.ToCity(result.@return);
        }

        public async Task<List<ICity>> FindByName(string name)
        {
            var result = await this.cityService.findByNameAsync(name);
            return result.@return.Select(x => this.ToCity(x)).ToList();
        }

        public async Task<List<ICity>> GetAll()
        {
            var result = await this.cityService.getCitiesAsync();
            return result.@return.Select(x => this.ToCity(x)).ToList();
        }

        #endregion

        private ICity ToCity(city city)
        {
            return new Models.City(city.citId, city.citName, city.citCountry);
        }

        private readonly CityServiceClient cityService = new CityServiceClient();
    }
}
