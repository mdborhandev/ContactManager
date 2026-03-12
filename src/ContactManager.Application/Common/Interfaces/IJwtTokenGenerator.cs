using ContactManager.Domain.Users;

namespace ContactManager.Application.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
