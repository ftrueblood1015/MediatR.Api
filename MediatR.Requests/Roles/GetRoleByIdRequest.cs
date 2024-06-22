using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Roles
{
    public class GetRoleByIdRequest : IRequest<RoleViewModel>
    {
        public int Id { get; set; }
    }
}
