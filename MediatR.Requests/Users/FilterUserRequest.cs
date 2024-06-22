using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Requests.Users
{
    public class FilterUserRequest : IRequest<IEnumerable<UserViewModel>>
    {
        public Func<User, bool>? Predicate { get; set; }
    }
}
