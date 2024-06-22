using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.UserRoles
{
    public class GetAllUserRolesRequest : IRequest<IEnumerable<UserRoleViewModel>>
    {
    }
}
