﻿namespace API.ResponseModels.Authorization;

public sealed record LoginResponse(string AccessToken, string RefreshToken);