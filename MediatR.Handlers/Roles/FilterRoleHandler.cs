using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;

namespace MediatR.Handlers.Roles
{
    public class FilterRoleHandler : IRequestHandler<FilterRoleRequest, IEnumerable<RoleViewModel>>
    {
        private readonly IRoleService _roleService;

        public FilterRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<IEnumerable<RoleViewModel>> Handle(FilterRoleRequest request, CancellationToken cancellationToken)
        {
            return _roleService.Filter(request.Predicate!);
        }
    }
}
