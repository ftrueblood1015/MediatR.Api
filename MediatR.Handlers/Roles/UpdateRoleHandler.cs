using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, RoleViewModel>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<RoleViewModel> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
        {
            return _roleService.Update(request.Role!);
        }
    }
}
