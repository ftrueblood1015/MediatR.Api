using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.UserRoles
{
    public class FilterUserRoleRequest : IRequest<IEnumerable<UserRoleViewModel>>
    {
        public Func<UserRole, bool>? Predicate { get; set; }
    }
}
