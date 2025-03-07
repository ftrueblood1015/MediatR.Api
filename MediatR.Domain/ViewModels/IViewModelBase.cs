﻿using System.ComponentModel.DataAnnotations;

namespace MediatR.Domain.ViewModels
{
    public interface IViewModelBase
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }
    }
}
