using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CVPerson.Models;

namespace CVPerson.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>()
                .HasMany<Education>(c => c.Education)
                .WithOne(e => e.Person)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
               .HasMany<Experience>(c => c.Experience)
               .WithOne(e => e.Person)
               .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<CVPerson.Models.Person> Person { get; set; }
        public DbSet<CVPerson.Models.Education> Education { get; set; }
        public DbSet<CVPerson.Models.Experience> Experience { get; set; }
    }
}
