using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class ServiceManager
    {
        public static readonly Lazy<CityServiceAdapter> CityService = new Lazy<CityServiceAdapter>();
        public static readonly Lazy<CinemaServiceAdapter> CinemaService = new Lazy<CinemaServiceAdapter>();
        public static readonly Lazy<HallServiceAdapter> HallService = new Lazy<HallServiceAdapter>();

    }
}
