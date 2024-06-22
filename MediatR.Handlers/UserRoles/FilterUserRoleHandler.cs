using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class FilterUserRoleHandler : IRequestHandler<FilterUserRoleRequest, IEnumerable<UserRoleViewModel>>
    {
        private readonly IUserRoleService _userRoleService;

        public FilterUserRoleHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<IEnumerable<UserRoleViewModel>> Handle(FilterUserRoleRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.Filter(request.Predicate!);
        }
    }
}
