using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyUniversity.Models;

namespace MyUniversityContext
{
    public class db : IdentityDbContext
    {
        public db (DbContextOptions<db> options)
            : base(options)
        {
        }

        public DbSet<MyUniversity.Models.Student> Student { get; set; } = default!;

        public DbSet<MyUniversity.Models.Enrollment> Enrollment { get; set; } = default!;

        public DbSet<MyUniversity.Models.Course> Course { get; set; } = default!;
    }
}
