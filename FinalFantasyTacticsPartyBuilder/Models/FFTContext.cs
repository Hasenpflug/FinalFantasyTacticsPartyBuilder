using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class FFTContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobItem> JobItems { get; set; }
        public DbSet<JobPrerequisites> JobPrerequisites { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<UnitName> UnitNames { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        public FFTContext() : base("DefaultConnection")
        {

        }

        public static FFTContext Create()
        {
            return new FFTContext();
        }
    }
}