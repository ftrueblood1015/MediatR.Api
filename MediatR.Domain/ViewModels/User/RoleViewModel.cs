using AutoMapper;
using MediatR.Domain.Entities.User;

namespace MediatR.Domain.ViewModels.User
{
    [AutoMap(typeof(Role), ReverseMap = true)]
    public class RoleViewModel : ViewModelBase
    {
    }
}
