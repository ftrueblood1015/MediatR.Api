using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Users
{
    public class AddUserRequest : IRequest<UserViewModel>
    {
        public UserViewModel? User { get; set; }
    }
}
