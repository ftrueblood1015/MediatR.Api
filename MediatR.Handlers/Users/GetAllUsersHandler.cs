using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR.Handlers.Users
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, IEnumerable<UserViewModel>>
    {
        private readonly IUserService _userService;

        public GetAllUsersHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IEnumerable<UserViewModel>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            return _userService.GetAll();
        }
    }
}
