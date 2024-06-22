namespace MediatR.Domain.Entities.User
{
    public class UserRole : EntityBase
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public User? User { get; set; }

        public Role? Role { get; set; }
    }
}
