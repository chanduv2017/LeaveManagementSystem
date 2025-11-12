using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                
                Id = "1c151c11-2927-440f-8d5b-669cd4bfe06b",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "76956d77-4da7-408f-b454-3dd096206b85",
                Name = "Supervisor",
                NormalizedName = "SUPERVISOR"
            },
            new IdentityRole
            {
                Id = "47113ab2-b4b2-4394-b38f-65d2ea7b42e7",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
         );
        var hasher = new PasswordHasher<ApplicationUser>();

        builder.Entity<ApplicationUser>()
            .HasData(
                new ApplicationUser
                {
                    Id = "819d90de-0e93-4dec-be3d-b92399659bfe",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash=hasher.HashPassword(null,"P@ssword1"),
                    EmailConfirmed = true,
                    FirstName ="Default",
                    LastName ="Admin",
                    DateOfBirth = new DateOnly(1950,12,01)
                }
            );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "47113ab2-b4b2-4394-b38f-65d2ea7b42e7",
                UserId = "819d90de-0e93-4dec-be3d-b92399659bfe"
            }
        );
    }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocation { get; set; }
    public DbSet<Period>Periods { get; set; }
};

