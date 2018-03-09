using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICinemaService
    {
        Task AddCinema(ICinema cinema);

        Task<ICinema> FindCinemaById(decimal id);

        Task<List<ICinema>> FindCinemaByName(string name);

        Task<List<ICinema>> GetCinemas();

        Task<ICinema> MergeCinema(ICinema cinema);

        Task RemoveCinema(decimal id);
    }
}
