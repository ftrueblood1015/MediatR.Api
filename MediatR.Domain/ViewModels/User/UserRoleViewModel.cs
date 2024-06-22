using MediatR.Domain.Entities.User;
using AutoMapper;

namespace MediatR.Domain.ViewModels.User
{
    [AutoMap(typeof(UserRole), ReverseMap = true)]
    public class UserRoleViewModel : ViewModelBase
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public MediatR.Domain.Entities.User.User? User { get; set; }

        public Role? Role { get; set; }
    }
}
