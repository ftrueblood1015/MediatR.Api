using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Users
{
    public class GetAllUsersRequest : IRequest<IEnumerable<UserViewModel>>
    {
    }
}
