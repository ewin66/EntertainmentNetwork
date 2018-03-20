using System;

namespace EntertainmentNetwork.DAL
{
    public class ServiceManager
    {
        public static readonly Lazy<CityServiceAdapter> CityService = new Lazy<CityServiceAdapter>();
        public static readonly Lazy<CinemaServiceAdapter> CinemaService = new Lazy<CinemaServiceAdapter>();
        public static readonly Lazy<HallServiceAdapter> HallService = new Lazy<HallServiceAdapter>();
        public static readonly Lazy<FloorServiceAdapter> FloorService = new Lazy<FloorServiceAdapter>();
        public static readonly Lazy<SeatServiceAdapter> SeatService = new Lazy<SeatServiceAdapter>();
        public static readonly Lazy<ShowServiceAdapter> ShowService = new Lazy<ShowServiceAdapter>();
    }
}
