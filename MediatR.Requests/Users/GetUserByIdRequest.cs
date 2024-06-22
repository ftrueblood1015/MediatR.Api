using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Users
{
    public class GetUserByIdRequest : IRequest<UserViewModel>
    {
        public int Id { get; set; }
    }
}
