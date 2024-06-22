using MediatR.Domain.Entities.User;
using MediatR.Domain.Interfaces.Repositories.User;

namespace MediatR.Infrastrucutre.Repositories.User
{
    public class UserRoleRepository : RepositoryBase<UserRole, MediatRDbContext>, IUserRoleRepository
    {
        public UserRoleRepository(MediatRDbContext context) : base(context)
        {
        }
    }
}
