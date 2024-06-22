using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class GetAllRolesHandler : IRequestHandler<GetAllRolesRequest, IEnumerable<RoleViewModel>>
    {
        private readonly IRoleService _roleService;

        public GetAllRolesHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<IEnumerable<RoleViewModel>> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
        {
            return _roleService.GetAll();
        }
    }
}
