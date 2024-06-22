using System.ComponentModel.DataAnnotations;

namespace MediatR.Domain.Entities
{
    public class EntityBase : IEntityBase
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }
    }
}
