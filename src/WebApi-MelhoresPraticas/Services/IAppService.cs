using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi_MelhoresPraticas.Services
{
    public interface IAppService<T, Tid> where T : class
    {
        Task<T> Add(T itemDTO);
        Task<T> Update(T itemDTO);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Tid Tid);
        Task<bool> Remove(Tid Tid);
    }
}
