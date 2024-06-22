using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Users;

namespace MediatR.Handlers.Users
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdRequest, UserViewModel>
    {
        private readonly IUserService _userService;

        public GetUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserViewModel> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            return _userService.GetById(request.Id)!;
        }
    }
}
