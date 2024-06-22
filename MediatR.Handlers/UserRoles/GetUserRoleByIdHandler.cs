using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class GetUserRoleByIdHandler : IRequestHandler<GetUserRoleByIdRequest, UserRoleViewModel>
    {
        private readonly IUserRoleService _userRoleService;

        public GetUserRoleByIdHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<UserRoleViewModel> Handle(GetUserRoleByIdRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.GetById(request.Id)!;
        }
    }
}
