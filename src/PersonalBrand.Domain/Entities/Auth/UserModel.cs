using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Domain.Entities.Auth
{
    public class UserModel : IdentityUser<long>
    {
        public string FirstName { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTimeOffset ModifiedAt { get; set; }
        public DateTimeOffset DeletedAt { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
