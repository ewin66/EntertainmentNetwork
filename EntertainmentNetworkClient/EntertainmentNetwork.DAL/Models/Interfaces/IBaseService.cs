using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL.Models.Interfaces
{
    public interface IBaseService<T> where T : IBaseModel
    {
        Task Add(T model);

        Task Remove(decimal id);

        Task<T> Merge(T model);

        Task<T> FindById(decimal id);

        Task<List<T>> GetAll();      
    }
}
