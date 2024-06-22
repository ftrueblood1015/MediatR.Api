namespace MediatR.Domain.Entities.User
{
    public class User : EntityBase
    {
        public string? Email { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? JoinDate { get; set; }
    }
}
