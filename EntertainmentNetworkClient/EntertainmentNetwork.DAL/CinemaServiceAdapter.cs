using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.CinemaService;
using EntertainmentNetwork.DAL.Models.Interfaces;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;
using System.Security;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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
                cinIcon = cinema.CinIcon == null ? null : GetBytesToString(cinema.CinIcon)
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
                cinIcon = cinema.CinIcon == null ? null : GetBytesToString(cinema.CinIcon),
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
            return new Cinema(city.cinId, city.cityId, city.cinName, city.cinAddress,
                    city.cinIcon == null ? null : GetStringToBytes(city.cinIcon));
        }

        public static string GetBytesToString(byte[] value)
        {
            SoapHexBinary shb = new SoapHexBinary(value);
            return shb.ToString();
        }

        public static byte[] GetStringToBytes(string value)
        {
            SoapHexBinary shb = SoapHexBinary.Parse(value);
            return shb.Value;
        }
    }
}
