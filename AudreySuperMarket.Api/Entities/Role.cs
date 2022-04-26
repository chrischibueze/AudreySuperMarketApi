using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Entities
{
    public class Role : IdentityRole<int>
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public int UserType { get; set; }
        public bool IsActive { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }



    }



}
