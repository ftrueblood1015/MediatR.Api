using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class GetAllUserRolesHandler : IRequestHandler<GetAllUserRolesRequest, IEnumerable<UserRoleViewModel>>
    {
        private readonly IUserRoleService _userRoleService;

        public GetAllUserRolesHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<IEnumerable<UserRoleViewModel>> Handle(GetAllUserRolesRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.GetAll();
        }
    }
}
