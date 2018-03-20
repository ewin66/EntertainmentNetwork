using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface ICinemaService : IBaseService<ICinema>
    {
        Task<List<ICinema>> FindCinemaByName(string name);
    }
}
