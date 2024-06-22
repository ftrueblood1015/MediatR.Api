using MediatR.Domain.Interfaces.Services.User;
using MediatR.Requests.Users;

namespace MediatR.Handlers.Users
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, bool>
    {
        private readonly IUserService _userService;

        public DeleteUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            return _userService.Delete(request.User!);
        }
    }
}
