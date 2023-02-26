using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagarichVideoService.Users.DAL.Models
{
    public class Credentials
    {
        public Guid UserId { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
