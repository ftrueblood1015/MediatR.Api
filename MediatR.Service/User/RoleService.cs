using AutoMapper;
using MediatR.Domain.Entities.User;
using MediatR.Domain.Interfaces.Repositories.User;
using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Service.User
{
    public class RoleService : ServiceBase<Role, RoleViewModel, IRoleRepository>, IRoleService
    {
        public RoleService(IRoleRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }
    }
}
