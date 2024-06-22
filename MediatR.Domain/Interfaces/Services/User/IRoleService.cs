using MediatR.Domain.Entities.User;
using MediatR.Domain.Interfaces.Services;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Domain.Interfaces.Services.User
{
    public interface IRoleService : IServiceBase<Role, RoleViewModel>
    {
    }
}
