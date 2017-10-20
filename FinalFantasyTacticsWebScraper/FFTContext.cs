namespace FinalFantasyTacticsWebScraper
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using FinalFantasyTacticsPartyBuilder.Models;

    public partial class FFTContext : DbContext
    {
        public FFTContext()
            : base("name=FFTContext")
        {
        }

        public virtual DbSet<WeaponCategory> WeaponCategories { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
