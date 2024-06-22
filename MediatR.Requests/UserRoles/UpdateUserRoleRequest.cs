using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.UserRoles
{
    public class UpdateUserRoleRequest : IRequest<UserRoleViewModel>
    {
        public UserRoleViewModel? UserRole { get; set; }
    }
}
