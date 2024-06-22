using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.UserRoles
{
    public class GetUserRoleByIdRequest : IRequest<UserRoleViewModel>
    {
        public int Id { get; set; }
    }
}
