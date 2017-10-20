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
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponCategory> WeaponCategories { get; set; }

        public FFTContext() : base("DefaultConnection")
        {

        }

        public static FFTContext Create()
        {
            return new FFTContext();
        }
    }
}