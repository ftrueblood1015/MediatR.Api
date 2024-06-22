using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Users;

namespace MediatR.Handlers.Users
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UserViewModel>
    {
        private readonly IUserService _userService;

        public UpdateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserViewModel> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            return _userService.Update(request.User!);
        }
    }
}
