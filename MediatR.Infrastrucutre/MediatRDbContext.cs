using MediatR.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Infrastrucutre
{
    public class MediatRDbContext : DbContext
    {
        public MediatRDbContext(DbContextOptions<MediatRDbContext> options) : base(options) { }

        DbSet<User> Users => Set<User>();
        DbSet<Role> Roles => Set<Role>();
        DbSet<UserRole> UserRole => Set<UserRole>();
    }
}
