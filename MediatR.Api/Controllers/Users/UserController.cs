using MediatR.Domain.Entities.User;
using MediatR.Domain.ViewModels.User;
using MediatR.Requests.Users;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Api.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<UserViewModel> CreateUser([FromBody] UserViewModel user)
        {
            return await _mediator.Send(new AddUserRequest() { User = user });
        }

        [HttpDelete("{id}")]
        public virtual async Task<bool> Delete(int id)
        {
            return await _mediator.Send(new DeleteUserByIdRequest() { UserId = id });
        }

        [HttpGet]
        public virtual Task<IEnumerable<UserViewModel>> GetAll()
        {
            return _mediator.Send(new GetAllUsersRequest());
        }

        [HttpGet("filter")]
        public virtual Task<IEnumerable<UserViewModel>> Filter(Func<User, bool> predicate)
        {
            return _mediator.Send(new FilterUserRequest() { Predicate = predicate});
        }

        [HttpGet("{id}")]
        public async Task<UserViewModel?> GetUser(int id)
        {
            return await _mediator.Send(new GetUserByIdRequest() { Id = id });
        }

        [HttpPut]
        public virtual Task<UserViewModel> Update([FromBody] UserViewModel user)
        {
            return _mediator.Send(new UpdateUserRequest() { User = user });
        }
    }
}
