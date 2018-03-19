using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.CinemaService;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class CinemaServiceAdapter : Interfaces.ICinemaService
    {
        #region ICinemaService

        public async Task AddCinema(ICinema cinema)
        {
            await cinemaService.addCinemaAsync(new addCinemaRequest
            {
                citIdSpecified = true,
                citId = cinema.CityId,
                cinName = cinema.CinName,
                cinAddress = cinema.CinAddress,
                cinIcon = cinema.CinIcon
            });
        }

        public async Task<ICinema> FindCinemaById(decimal id)
        {
            var result = await this.cinemaService.findCinemaByIdAsync(id);
            return this.ToCinema(result.@return);
        }

        public async Task<List<ICinema>> FindCinemaByName(string name)
        {
            var result = await this.cinemaService.findCinemaByNameAsync(name);
            return result.@return.Select(x => this.ToCinema(x)).ToList();
        }

        public async Task<List<ICinema>> GetCinemas()
        {
            var result = await this.cinemaService.getCinemasAsync();
            return result.@return.Select(x => this.ToCinema(x)).ToList();
        }

        public async Task<ICinema> MergeCinema(ICinema cinema)
        {
            var result = await this.cinemaService.mergeCinemaAsync(new mergeCinemaRequest
            {
                citId = cinema.CityId,
                cinId = cinema.CinId,
                cinName = cinema.CinName,
                cinAddress = cinema.CinAddress,
                cinIcon = cinema.CinIcon,
                cinIdSpecified = true,
                citIdSpecified = true
            });

            return this.ToCinema(result.@return);
        }

        public async Task RemoveCinema(decimal id)
        {
            await this.cinemaService.removeCinemaAsync(id);
        }

        #endregion

        private ICinema ToCinema(cinema city)
        {
            return new Cinema(city.cinId, city.cityId, city.cinName, city.cinAddress, city.cinIcon);
        }

        private readonly CinemaServiceClient cinemaService = new CinemaServiceClient();
    }
}
