using AutoMapper;
using MediatR.Domain.Interfaces.Repositories.User;
using MediatR.Domain.Interfaces.Services.User;
using MediatR.Domain.ViewModels.User;

namespace MediatR.Service.User
{
    public class UserService : ServiceBase<MediatR.Domain.Entities.User.User, UserViewModel, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }
    }
}
