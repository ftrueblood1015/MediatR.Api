using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Users;

namespace MediatR.Handlers.Users
{
    public class AddUserHandler : IRequestHandler<AddUserRequest, UserViewModel>
    {
        private readonly IUserService _userService;

        public AddUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserViewModel> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            return _userService.Add(request.User!);
        }
    }
}
