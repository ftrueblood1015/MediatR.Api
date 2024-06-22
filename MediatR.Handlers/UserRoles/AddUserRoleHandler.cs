using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class AddUserRoleHandler : IRequestHandler<AddUserRoleRequest, UserRoleViewModel>
    {
        private readonly IUserRoleService _userRoleService;

        public AddUserRoleHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<UserRoleViewModel> Handle(AddUserRoleRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.Add(request.UserRole!);
        }
    }
}
