using MediatR.Domain.Interfaces.Services.User;
using MediatR.Requests.Users;

namespace MediatR.Handlers.Users
{
    public class DeleteUserByIdHandler : IRequestHandler<DeleteUserByIdRequest, bool>
    {
        private readonly IUserService _userService;

        public DeleteUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Handle(DeleteUserByIdRequest request, CancellationToken cancellationToken)
        {
            return _userService.DeleteById(request.UserId);
        }
    }
}
