using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Okaz.Core.Entities;
using Okaz.Core.Entities.ApplicationSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Infrastructure.Contexts
{
   public class OkazContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>
    {
        public OkazContext(DbContextOptions<OkazContext> options) : base(options)
        {

        }

        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>(entity =>
        {
            entity.ToTable(name: "ApplicationUsers");         
        });

        builder.Entity<ApplicationRole>(entity =>
        {
            entity.ToTable(name: "ApplicationRoles");
        });
        builder.Entity<ApplicationUserRole>(entity =>
        {
            entity.ToTable("ApplicationUserRoles");
          //in case you chagned the TKey type
          //  entity.HasKey(key => new { key.UserId, key.RoleId });
        });

        builder.Entity<ApplicationUserClaim>(entity =>
        {
            entity.ToTable("ApplicationUserClaims");
        });

        builder.Entity<ApplicationUserLogin>(entity =>
        {
            entity.ToTable("ApplicationUserLogins");
             //in case you chagned the TKey type
          //  entity.HasKey(key => new { key.ProviderKey, key.LoginProvider });       
 });

        builder.Entity<ApplicationRoleClaim>(entity =>
        {
            entity.ToTable("ApplicationRoleClaims");

        });

        builder.Entity<ApplicationUserToken>(entity =>
        {
            entity.ToTable("ApplicationUserTokens");
            //in case you chagned the TKey type
           // entity.HasKey(key => new { key.UserId, key.LoginProvider, key.Name });

        });
    }
    }


}
