using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Roles
{
    public class AddRoleRequest : IRequest<RoleViewModel>
    {
        public RoleViewModel? Role { get; set; }
    }
}
