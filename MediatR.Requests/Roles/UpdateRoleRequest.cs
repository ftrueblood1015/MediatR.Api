using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Roles
{
    public class UpdateRoleRequest : IRequest<RoleViewModel>
    {
        public RoleViewModel? Role { get; set; }
    }
}
