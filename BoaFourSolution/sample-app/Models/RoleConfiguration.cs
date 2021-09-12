﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        // Create the default roles
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Name = "User",
                NormalizedName = "User"
            }, new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "Administrator"
            });
        }
    }
}
