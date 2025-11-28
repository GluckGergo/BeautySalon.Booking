using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Entities.Dto.Auth
{
    public class LoginResultDto
    {
        public string AccessToken { get; set; } = "";

        public DateTime AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; } = "";

        public DateTime RefreshTokenExpiration { get; set; }
    }
}
