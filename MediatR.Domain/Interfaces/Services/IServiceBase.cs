using MediatR.Domain.Entities;
using MediatR.Domain.ViewModels;

namespace MediatR.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity, TViewModel>
        where TEntity : IEntityBase
        where TViewModel : IViewModelBase
    {
        TViewModel Add(TViewModel viewModel);

        bool Delete(TViewModel viewModel);

        bool DeleteById(int viewModelId);

        IEnumerable<TViewModel> Filter(Func<TEntity, bool> predicate);

        IEnumerable<TViewModel> GetAll();

        TViewModel? GetById(int id);

        TViewModel Update(TViewModel viewModel);

        TEntity CreateEntity(TViewModel viewModel);

        TViewModel CreateViewModel(TEntity entity);
    }
}
