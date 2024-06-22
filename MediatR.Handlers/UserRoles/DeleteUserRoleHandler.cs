using MediatR.Domain.Interfaces.Services.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class DeleteUserRoleHandler : IRequestHandler<DeleteUserRoleRequest, bool>
    {
        private readonly IUserRoleService _userRoleService;

        public DeleteUserRoleHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<bool> Handle(DeleteUserRoleRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.Delete(request.UserRole!);
        }
    }
}
