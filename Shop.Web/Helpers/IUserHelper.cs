namespace Shop.Web.Helpers
{
    using Data.Entities;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
