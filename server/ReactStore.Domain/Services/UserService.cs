using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ReactStore.Domain.Repositories;
using ReactStore.Domain.Requests.User;
using ReactStore.Domain.Responses;
using ReactStore.Domain.Settings;

namespace ReactStore.Domain.Services
{
    public interface IUserService
    {
        Task<UserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default);
        Task<UserResponse> SignUpAsync(SignUpRequest request, CancellationToken cancellationToken = default);
        Task<TokenResponse> SignInAsync(SignInRequest request, CancellationToken cancellationToken = default);
    }
    
    public class UserService : IUserService
    {
        private readonly AuthenticationSettings _authenticationSettings;
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, IOptions<AuthenticationSettings> authenticationSettings)
        {
            _userRepository = userRepository;
            _authenticationSettings = authenticationSettings.Value;
        }

        public async Task<UserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken)
        {
            var response = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);
            return response == null ? null : new UserResponse {Name = response.FullName, Email = response.Email}; 
        }

        public async Task<UserResponse> SignUpAsync(SignUpRequest request, CancellationToken cancellationToken)
        {
            var user = new Entities.AppUser {Email = request.Email, UserName = request.Email, FirstName = request.FirstName, LastName = request.LastName};
            bool isCreated = await _userRepository.SignUpAsync(user, request.Password, cancellationToken);
            
            return !isCreated ? null : new UserResponse { Name = user.FullName, Email = request.Email};
        }

        public async Task<TokenResponse> SignInAsync(SignInRequest request, CancellationToken cancellationToken)
        {
            bool isAuthenticated =
                await _userRepository.AuthenticateAsync(request.Email, request.Password, cancellationToken);

            if (!isAuthenticated)
                return null;

            var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);
            var roles = await _userRepository.GetUserRoles(request.Email, cancellationToken);

            var token = new TokenResponse
            {
                FullName = user.FullName,
                Roles = roles,
                Token = GenerateSecurityToken(request, roles)
            };
            
            return  token;
        }

        private string GenerateSecurityToken(SignInRequest request, IEnumerable<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_authenticationSettings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new []
                {
                    new Claim(ClaimTypes.Email, request.Email),
                }),
                Expires = DateTime.UtcNow.AddDays(_authenticationSettings.ExpirationDays),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            foreach (var role in roles)
            {
                tokenDescriptor.Subject.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        
    }
}