using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Domain.Interfaces.Services.User
{
    public interface IUserRoleService : IServiceBase<UserRole, UserRoleViewModel>
    {
    }
}
