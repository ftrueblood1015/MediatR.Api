using AutoMapper;
using MediatR.Domain.Entities.User;
using MediatR.Domain.Interfaces.Repositories.User;
using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Service.User
{
    public class UserRoleService : ServiceBase<UserRole, UserRoleViewModel, IUserRoleRepository>, IUserRoleService
    {
        public UserRoleService(IUserRoleRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }
    }
}
