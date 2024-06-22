using AutoMapper;
using MediatR.Domain.Entities.User;

namespace MediatR.Domain.ViewModels.User
{
    [AutoMap(typeof(MediatR.Domain.Entities.User.User), ReverseMap = true)]
    public class UserViewModel : ViewModelBase
    {
        public string? Email { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? JoinDate { get; set; }
    }
}
