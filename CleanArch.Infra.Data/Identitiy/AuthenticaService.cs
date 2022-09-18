using CleanArch.Domain.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Identitiy
{
    public class AuthenticaService : IAutenthicate
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public AuthenticaService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: false);

            return result.Succeeded;
        }

        
        public Task<bool> RegisterUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

    }
}
