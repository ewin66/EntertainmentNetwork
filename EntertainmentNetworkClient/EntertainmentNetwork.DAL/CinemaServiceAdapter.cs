using System.Collections.Generic;
using System.Linq;
using EntertainmentNetwork.DAL.CinemaService;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class CinemaServiceAdapter : Interfaces.ICinemaService
    {
        private readonly CinemaServiceClient cinemaService = new CinemaServiceClient();

        #region ICinemaService

        public void AddCinema(ICinema cinema)
        {
            cinemaService.addCinema(new addCinemaRequest
            {
                citIdSpecified = true,
                citId = cinema.CityId,
                cinName = cinema.CinName,
                cinAddress = cinema.CinAddress,
                cinIcon = cinema.CinIcon
            });
        }

        public ICinema FindCinemaById(decimal id)
        {
            return this.ToCinema(this.cinemaService.findCinemaById(id));
        }

        public List<ICinema> FindCinemaByName(string name)
        {
            return this.cinemaService.findCinemaByName(name).Select(x => this.ToCinema(x)).ToList();
        }

        public List<ICinema> GetCinemas()
        {
            return this.cinemaService.getCinemas().Select(x => this.ToCinema(x)).ToList();
        }

        public ICinema MergeCinema(ICinema cinema)
        {
            return this.ToCinema(this.cinemaService.mergeCinema(new mergeCinemaRequest
            {
                citId = cinema.CityId,
                cinId = cinema.CinId,
                cinName = cinema.CinName,
                cinAddress = cinema.CinAddress,
                cinIcon = cinema.CinIcon,
                cinIdSpecified = true,
                citIdSpecified = true
            }));
        }

        public void RemoveCinema(decimal id)
        {
            this.cinemaService.removeCinema(id);
        }

        #endregion

        private ICinema ToCinema(cinema city)
        {
            return new Cinema(city.cinId, city.cityId, city.cinName, city.cinAddress, city.cinIcon);
        }
    }
}
