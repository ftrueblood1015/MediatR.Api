using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Roles
{
    public class FilterRoleRequest : IRequest<IEnumerable<RoleViewModel>>
    {
        public Func<Role, bool>? Predicate { get; set; }
    }
}
