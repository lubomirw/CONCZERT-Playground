﻿using System.ComponentModel.DataAnnotations;

namespace Czertainly.Auth.Models.Dto
{
    public record SubjectPermissionsDto
    {
        [Required]
        public bool AllowAllResources { get; set; }

        [Required]
        public List<ResourcePermissionsDto> Resources { get; init; } = new List<ResourcePermissionsDto>();
    }
}