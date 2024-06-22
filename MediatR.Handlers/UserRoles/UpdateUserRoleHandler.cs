using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class UpdateUserRoleHandler : IRequestHandler<UpdateUserRoleRequest, UserRoleViewModel>
    {
        private readonly IUserRoleService _userRoleService;

        public UpdateUserRoleHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<UserRoleViewModel> Handle(UpdateUserRoleRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.Update(request.UserRole!);
        }
    }
}
