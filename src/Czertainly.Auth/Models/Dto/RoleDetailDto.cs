﻿using Czertainly.Auth.Common.Models.Dto;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Czertainly.Auth.Models.Dto
{
    public record RoleDetailDto : RoleDto
    {
        [Required]
        [JsonPropertyOrder(99)]
        public List<UserDto> Users { get; init; } = new List<UserDto>();

    }
}
