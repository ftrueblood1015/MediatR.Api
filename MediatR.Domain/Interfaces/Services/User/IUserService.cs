using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Domain.Interfaces.Services.User
{
    public interface IUserService : IServiceBase<MediatR.Domain.Entities.User.User, UserViewModel>
    {
    }
}
