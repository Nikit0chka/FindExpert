﻿using System.ComponentModel.DataAnnotations;

namespace Authorization.API.RequestModels.Authorization;

public class RefreshRequest
{
    [Required(ErrorMessage = "Refresh token is required.")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Refresh token must be at least 1 character long.")]
    public required string RefreshToken { get; set; }
}