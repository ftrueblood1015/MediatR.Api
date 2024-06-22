using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class GetRoleByIdHandler : IRequestHandler<GetRoleByIdRequest, RoleViewModel>
    {
        private readonly IRoleService _roleService;

        public GetRoleByIdHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<RoleViewModel> Handle(GetRoleByIdRequest request, CancellationToken cancellationToken)
        {
            return _roleService.GetById(request.Id)!;
        }
    }
}
