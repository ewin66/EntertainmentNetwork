using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICinemaService
    {
        void AddCinema(ICinema cinema);

        ICinema FindCinemaById(decimal id);

        List<ICinema> FindCinemaByName(string name);

        List<ICinema> GetCinemas();

        ICinema MergeCinema(ICinema cinema);

        void RemoveCinema(decimal id);
    }
}
