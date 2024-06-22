using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class AddRoleHandler : IRequestHandler<AddRoleRequest, RoleViewModel>
    {
        private readonly IRoleService _roleService;

        public AddRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<RoleViewModel> Handle(AddRoleRequest request, CancellationToken cancellationToken)
        {
            return _roleService.Add(request.Role!);
        }
    }
}
