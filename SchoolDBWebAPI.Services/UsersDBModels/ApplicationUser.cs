using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolDBWebAPI.Services.UsersDBModels
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}