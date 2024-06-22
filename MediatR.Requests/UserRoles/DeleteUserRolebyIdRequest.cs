namespace MediatR.Requests.UserRoles
{
    public class DeleteUserRolebyIdRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
