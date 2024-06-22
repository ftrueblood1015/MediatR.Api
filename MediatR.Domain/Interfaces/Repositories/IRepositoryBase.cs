using MediatR.Domain.Entities;

namespace MediatR.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T: IEntityBase
    {
        T Add(T entity);

        bool Delete(T entity);

        bool DeleteById(int entityId);

        IEnumerable<T> Filter(Func<T, bool> predicate);

        IEnumerable<T> GetAll();

        T? GetById(int id);

        T Update(T entity);
    }
}
