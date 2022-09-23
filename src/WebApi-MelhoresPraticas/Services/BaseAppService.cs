using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_MelhoresPraticas.Services;

namespace Aplicacao.Application.Services
{
    public abstract class BaseAppService<T, D, Tid> : IAppService<D, Tid>
        where T : class
        where D : class
    {
        protected readonly IMapper _mapper;
        protected readonly IAppService<T, Tid> _baseService;

        protected BaseAppService(IAppService<T, Tid> baseService, IMapper mapper)
        {
            _mapper = mapper;
            _baseService = baseService;
        }

        public async Task<D> Add(D itemDTO)
        {
            var itemMap = _mapper.Map<D, T>(itemDTO);
            var item = await _baseService.Add(itemMap);
            itemDTO = _mapper.Map<T, D>(item);

            return itemDTO;
        }

        public async Task<D> Get(Tid tid)
        {
            var retorno = await _baseService.Get(tid);
            var res = retorno;

            return _mapper.Map<T, D>(res);
        }

        public async Task<IEnumerable<D>> GetAll()
        {
            var retorno = await _baseService.GetAll();
            var res = retorno;

            return _mapper.Map<IEnumerable<T>, IEnumerable<D>>(res);
        }

        public async Task<bool> Remove(Tid tid)
        {
            return await _baseService.Remove(tid);
        }

        public async Task<D> Update(D itemDTO)
        {
            var itemMap = _mapper.Map<D, T>(itemDTO);
            var item = await _baseService.Update(itemMap);
            itemDTO = _mapper.Map<T, D>(item);

            return itemDTO;
        }
    }
}