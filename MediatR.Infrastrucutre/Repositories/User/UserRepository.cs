using MediatR.Domain.Interfaces.Repositories.User;

namespace MediatR.Infrastrucutre.Repositories.User
{
    public class UserRepository : RepositoryBase<MediatR.Domain.Entities.User.User, MediatRDbContext>, IUserRepository
    {
        public UserRepository(MediatRDbContext context) : base(context)
        { 
        }
    }
}
