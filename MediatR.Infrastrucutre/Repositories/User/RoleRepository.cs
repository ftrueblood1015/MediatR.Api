using MediatR.Domain.Entities.User;
using MediatR.Domain.Interfaces.Repositories.User;

namespace MediatR.Infrastrucutre.Repositories.User
{
    public class RoleRepository : RepositoryBase<Role, MediatRDbContext>, IRoleRepository
    {
        public RoleRepository(MediatRDbContext context) : base(context)
        {
        }
    }
}
