using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyUniversity.Models;

namespace MyUniversityContext
{
    public class db : IdentityDbContext
    {
        public class IdentityDbContextEntityConfiguration : IEntityTypeConfiguration<IdentityDbContext>
        {
         

            public void Configure(EntityTypeBuilder<IdentityDbContext> builder)
            {

                builder.Property(User => FirstName).HasMaxLength(225);
                builder.Property(User => LastName).HasMaxLength(225);
            }
        }

        public db (DbContextOptions<db> options)
            : base(options)
        {
        }

        public DbSet<MyUniversity.Models.Student> Student { get; set; } = default!;

        public DbSet<MyUniversity.Models.Enrollment> Enrollment { get; set; } = default!;

        public DbSet<MyUniversity.Models.Course> Course { get; set; } = default!;

        public DbSet<MyUniversity.Models.User> User { get; set; } = default!;
    }
}
