using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Data
{
    public class AppUser : IdentityUser
    {
        [StringLength(200)]
        public required string FamilyName { get; set; } = "";

        [StringLength(200)]
        public required string GivenName { get; set; } = "";

        [StringLength(200)]
        public required string RefreshToken { get; set; } = "";
    }
}
