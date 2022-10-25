﻿using Czertainly.Auth.Common.Models.Dto;
using System.ComponentModel.DataAnnotations;

namespace Czertainly.Auth.Models.Dto
{
    public record AuthenticationResponseDto
    {
        [Required]
        public bool Authenticated { get; init; }

        public UserProfileDto? Data { get; init; }
    }
}
