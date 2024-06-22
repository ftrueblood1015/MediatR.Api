using MediatR.Domain.Interfaces.Services.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class DeleteRoleByIdHandler : IRequestHandler<DeleteRoleByIdRequest, bool>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleByIdHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<bool> Handle(DeleteRoleByIdRequest request, CancellationToken cancellationToken)
        {
            return _roleService.DeleteById(request.Id);
        }
    }
}
