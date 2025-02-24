﻿namespace Authorization.API.Middlewares;

public sealed class RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        logger.LogInformation("Request Method: {Method}, Path: {Path}", context.Request.Method, context.Request.Path);

        await next(context);

        logger.LogInformation("Response StatusCode: {StatusCode}", context.Response.StatusCode);
    }
}