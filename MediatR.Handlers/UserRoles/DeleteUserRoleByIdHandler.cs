using MediatR.Domain.Interfaces.Services.User;
using MediatR.Requests.UserRoles;

namespace MediatR.Handlers.UserRoles
{
    public class DeleteUserRoleByIdHandler : IRequestHandler<DeleteUserRolebyIdRequest, bool>
    {
        private readonly IUserRoleService _userRoleService;

        public DeleteUserRoleByIdHandler(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        public async Task<bool> Handle(DeleteUserRolebyIdRequest request, CancellationToken cancellationToken)
        {
            return _userRoleService.DeleteById(request.Id);
        }
    }
}
