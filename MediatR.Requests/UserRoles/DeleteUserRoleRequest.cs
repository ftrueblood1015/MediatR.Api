using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.UserRoles
{
    public class DeleteUserRoleRequest : IRequest<bool>
    {
        public UserRoleViewModel? UserRole { get; set; }
    }
}
