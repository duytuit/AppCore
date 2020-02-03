using AppCore.Data.EF.Configurations;
using AppCore.Data.EF.Extensions;
using AppCore.Data.Entities.System;
using AppCore.Data.Interfaces;
using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.SharesKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AppCore.Data.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //#region Identity Config

            //modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            //modelBuilder.Entity<Sys001>().Property(x => x.Id).ValueGeneratedOnAdd();

            //modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            //modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
            //    .HasKey(x => new { x.RoleId, x.UserId });

            //modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
            //   .HasKey(x => new { x.UserId });

            //#endregion Identity Config
         
            modelBuilder.ApplyConfiguration(new Sys001Configuration());
            modelBuilder.ApplyConfiguration(new Sys002Configuration());
            modelBuilder.ApplyConfiguration(new Sys003Configuration());
            modelBuilder.ApplyConfiguration(new Sys004Configuration());
            modelBuilder.ApplyConfiguration(new Sys005Configuration());
            modelBuilder.ApplyConfiguration(new Sys006Configuration());
            modelBuilder.ApplyConfiguration(new Sys007Configuration());
            modelBuilder.ApplyConfiguration(new Sys008Configuration());
            modelBuilder.ApplyConfiguration(new Sys009Configuration());
            modelBuilder.ApplyConfiguration(new AuditLogConfiguration());

            modelBuilder.Seed();

        }
        public DbSet<AuditLog> AuditLogs { set; get; }
        public DbSet<Sys001> Sys001s { set; get; }
        public DbSet<Sys002> Sys002s { set; get; }
        public DbSet<Sys003> Sys003s { set; get; }
        public DbSet<Sys004> Sys004s { set; get; }
        public DbSet<Sys005> Sys005s { set; get; }
        public DbSet<Sys006> Sys006s { set; get; }
        public DbSet<Sys007> Sys007s { set; get; }
        public DbSet<Sys008> Sys008s { set; get; }
        public DbSet<Sys009> Sys009s { set; get; }
        public DbSet<Timer> Timers { set; get; }

    //    public override int SaveChanges()
    //    {
    //        try
    //        {
    //            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
    //            foreach (EntityEntry item in modified)
    //            {
    //                if (item.Entity is IDateTracking changedOrAddedItem)
    //                {
    //                    if (item.State == EntityState.Added)
    //                    {
    //                        changedOrAddedItem.Ngaytao = DateTime.Now;
    //                    }
    //                    changedOrAddedItem.Ngaycapnhap = DateTime.Now;
    //                }
    //            }
    //            return base.SaveChanges();
    //        }
    //        catch (DbUpdateException entityException)
    //        {
    //            throw new ModelValidationException(entityException.Message);
    //        }
         
    //}
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<AppDbContext>();
                var connectionString = configuration.GetConnectionString("AppDbConnection");
                builder.UseSqlServer(connectionString);
                return new AppDbContext(builder.Options);
            }
        }
    }
}
