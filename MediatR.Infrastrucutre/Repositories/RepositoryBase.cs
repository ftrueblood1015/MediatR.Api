using MediatR.Domain.Entities;
using MediatR.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Infrastrucutre.Repositories
{
    public class RepositoryBase<T, TContext> : IRepositoryBase<T>
        where T : EntityBase
        where TContext : DbContext
    {
        protected DbContext Context { get; }

        public RepositoryBase(DbContext context)
        {
            Context = context;
        }

        public virtual T Add(T entity)
        {
            try
            {
                Context.Add(entity);
                Context.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding {entity.Name}: {ex.Message}");
            }
        }

        public virtual bool Delete(T entity)
        {
            try
            {
                Context.Set<T>().Remove(entity);
                var results = Context.SaveChanges();

                return results > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Deleting {entity.Name}: {ex.Message}");
            }
        }

        public virtual bool DeleteById(int entityId)
        {
            try
            {
                var entity = GetById(entityId);

                Context.Set<T>().Remove(entity!);
                var results = Context.SaveChanges();

                return results > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Deleting {entityId}: {ex.Message}");
            }
        }

        public virtual IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            try
            {
                return Context.Set<T>().AsNoTracking().Where(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error filtering {predicate}: {ex.Message}");
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return Context.Set<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all entities: {ex.Message}");
            }
        }

        public virtual T? GetById(int id)
        {
            try
            {
                return Context.Set<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting Id {id}: {ex.Message}");
            }
        }

        public virtual T Update(T entity)
        {
            try
            {
                Context.Set<T>().Update(entity);
                Context.SaveChanges();

                return GetById(entity.Id)!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating Id {entity.Id}: {ex.Message}");
            }
        }
    }
}
