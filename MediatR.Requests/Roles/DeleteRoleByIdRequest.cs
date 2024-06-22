namespace MediatR.Requests.Roles
{
    public class DeleteRoleByIdRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
