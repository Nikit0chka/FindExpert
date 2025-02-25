using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Application.CQRS.Authorization.Commands;

public sealed record LoginCommand(string Login, string Password):ICommand<Result<(string AccessToken, string RefreshToken)>>;