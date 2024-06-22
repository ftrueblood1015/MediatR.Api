using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Roles
{
    public class GetAllRolesRequest : IRequest<IEnumerable<RoleViewModel>>
    {
    }
}
