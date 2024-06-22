using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.UserRoles
{
    public class AddUserRoleRequest : IRequest<UserRoleViewModel>
    {
        public UserRoleViewModel? UserRole { get; set; }
    }
}
