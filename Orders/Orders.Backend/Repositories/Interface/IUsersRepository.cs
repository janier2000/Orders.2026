using Microsoft.AspNetCore.Identity;
using Orders.Shared.DTOs;
using Orders.Shared.Entities;
using Orders.Shared.Entities.Responses;

namespace Orders.Backend.Repositories.Interface
{
    public interface IUsersRepository
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<SignInResult> LoginAsync(LoginDTO model);
        Task LogoutAsync();


        //Task<ActionResponse<IEnumerable<User>>> GetAsync(PaginationDTO pagination);
        //Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
        //Task<string> GeneratePasswordResetTokenAsync(User user);
        //Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);
        //Task<string> GenerateEmailConfirmationTokenAsync(User user);
        //Task<IdentityResult> ConfirmEmailAsync(User user, string token);
        //Task<User> GetUserAsync(Guid userId);
        //Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);
        //Task<IdentityResult> UpdateUserAsync(User user);
    }
}