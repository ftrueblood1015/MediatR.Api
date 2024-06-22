using MediatR.Domain.Interfaces.Services.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, bool>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<bool> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
        {
            return _roleService.Delete(request.Role!);
        }
    }
}
