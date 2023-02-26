using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MagarichVideoService.Users.DAL.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string NickName { get; set; } = null!;

        public string? Photo { get; set; }

        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

        public Credentials UserCredentials { get; set; } = null!;
    }
}
