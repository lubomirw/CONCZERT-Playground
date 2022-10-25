﻿using Czertainly.Auth.Common.Models.Dto;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Czertainly.Auth.Models.Dto
{
    public record ResourceDetailDto : ResourceDto
    {

        [Required]
        [JsonPropertyOrder(99)]
        public List<ActionDto> Actions { get; init; } = new List<ActionDto>();

    }
}
