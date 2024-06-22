namespace MediatR.Requests.Users
{
    public class DeleteUserByIdRequest : IRequest<bool>
    {
        public int UserId { get; set; }
    }
}
