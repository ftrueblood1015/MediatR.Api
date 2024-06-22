using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Users
{
    public class DeleteUserRequest : IRequest<bool>
    {
        public UserViewModel? User { get; set; }
    }
}
