using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Users;

namespace MediatR.Handlers.Users
{
    public class FilterUserHandler : IRequestHandler<FilterUserRequest, IEnumerable<UserViewModel>>
    {
        private readonly IUserService _userService;

        public FilterUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IEnumerable<UserViewModel>> Handle(FilterUserRequest request, CancellationToken cancellationToken)
        {
            return _userService.Filter(request.Predicate!);
        }
    }
}
