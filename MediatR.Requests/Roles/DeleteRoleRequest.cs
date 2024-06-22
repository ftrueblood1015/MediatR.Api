using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Roles
{
    public class DeleteRoleRequest : IRequest<bool>
    {
        public RoleViewModel? Role { get; set; }
    }
}
