using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Users
{
    public class UpdateUserRequest : IRequest<UserViewModel>
    {
        public UserViewModel? User { get; set;}
    }
}
