using AutoMapper;
using MediatR.Domain.Entities;
using MediatR.Domain.Interfaces.Repositories;
using MediatR.Domain.Interfaces.Services;
using MediatR.Domain.ViewModels;

namespace MediatR.Service
{
    public class ServiceBase<TEntity, TViewModel, TRepo> : IServiceBase<TEntity, TViewModel>
        where TEntity : IEntityBase
        where TViewModel : IViewModelBase
        where TRepo : IRepositoryBase<TEntity>
    {
        protected IRepositoryBase<TEntity> _repo { get; }
        private readonly IMapper _mapper;

        public ServiceBase(IRepositoryBase<TEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public virtual TViewModel Add(TViewModel viewModel)
        {
            try
            {
                var entity = CreateEntity(viewModel);

                var result = _repo.Add(entity);

                return CreateViewModel(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual TEntity CreateEntity(TViewModel viewModel)
        {
            try
            {
                return _mapper.Map<TEntity>(viewModel);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public virtual TViewModel CreateViewModel(TEntity entity)
        {
            try
            {
                return _mapper.Map<TViewModel>(entity);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public virtual bool Delete(TViewModel viewModel)
        {
            try
            {
                var entity = CreateEntity(viewModel);

                return _repo.Delete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual bool DeleteById(int viewModelId)
        {
            try
            {
                return _repo.DeleteById(viewModelId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual IEnumerable<TViewModel> Filter(Func<TEntity, bool> predicate)
        {
            try
            {
                return _repo.Filter(predicate).Select(x => CreateViewModel(x));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual IEnumerable<TViewModel> GetAll()
        {
            try
            {
                return _repo.GetAll().Select(x => CreateViewModel(x));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual TViewModel? GetById(int id)
        {
            try
            {
                var result = _repo.GetById(id);

                return CreateViewModel(result!);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual TViewModel Update(TViewModel viewModel)
        {
            try
            {
                var entity = CreateEntity(viewModel);

                var result = _repo.Update(entity);

                return CreateViewModel(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
