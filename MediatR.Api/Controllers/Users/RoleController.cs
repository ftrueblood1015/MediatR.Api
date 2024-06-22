using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Roles;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Api.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<RoleViewModel> CreateRole([FromBody] RoleViewModel role)
        {
            return await _mediator.Send(new AddRoleRequest() { Role = role });
        }

        [HttpDelete("{id}")]
        public virtual async Task<bool> Delete(int id)
        {
            return await _mediator.Send(new DeleteRoleByIdRequest() { Id = id });
        }

        [HttpGet]
        public virtual Task<IEnumerable<RoleViewModel>> GetAll()
        {
            return _mediator.Send(new GetAllRolesRequest());
        }

        [HttpGet("filter")]
        public virtual Task<IEnumerable<RoleViewModel>> Filter(Func<Role, bool> predicate)
        {
            return _mediator.Send(new FilterRoleRequest() { Predicate = predicate });
        }

        [HttpGet("{id}")]
        public async Task<RoleViewModel?> GetRole(int id)
        {
            return await _mediator.Send(new GetRoleByIdRequest() { Id = id });
        }

        [HttpPut]
        public virtual Task<RoleViewModel> Update([FromBody] RoleViewModel role)
        {
            return _mediator.Send(new UpdateRoleRequest() { Role = role });
        }
    }
}
