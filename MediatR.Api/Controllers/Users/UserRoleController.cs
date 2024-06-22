using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;
using MediatR.Requests.UserRoles;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Api.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserRoleController
    {
        private readonly IMediator _mediator;

        public UserRoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<UserRoleViewModel> CreateUserRole([FromBody] UserRoleViewModel userRole)
        {
            return await _mediator.Send(new AddUserRoleRequest() { UserRole = userRole });
        }

        [HttpDelete("{id}")]
        public virtual async Task<bool> Delete(int id)
        {
            return await _mediator.Send(new DeleteUserRolebyIdRequest() { Id = id });
        }

        [HttpGet]
        public virtual Task<IEnumerable<UserRoleViewModel>> GetAll()
        {
            return _mediator.Send(new GetAllUserRolesRequest());
        }

        [HttpGet("filter")]
        public virtual Task<IEnumerable<UserRoleViewModel>> Filter(Func<UserRole, bool> predicate)
        {
            return _mediator.Send(new FilterUserRoleRequest() { Predicate = predicate });
        }

        [HttpGet("{id}")]
        public async Task<UserRoleViewModel?> GetUserRole(int id)
        {
            return await _mediator.Send(new GetUserRoleByIdRequest() { Id = id });
        }

        [HttpPut]
        public virtual Task<UserRoleViewModel> Update([FromBody] UserRoleViewModel userRole)
        {
            return _mediator.Send(new UpdateUserRoleRequest() { UserRole = userRole });
        }
    }
}
