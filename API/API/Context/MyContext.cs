using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<Room> Rooms { get; set; }
        //public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            builder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(b => b.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            builder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(c => c.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            builder.Entity<Employee>()
                .HasOne<User>(e => e.User)
                        .WithOne(u => u.Employee)
                        .HasForeignKey<Employee>(u => u.Id);

            //builder.Entity<Room>()
            //   .HasOne<Booking>(e => e.Booking)
            //           .WithOne(u => u.Room)
            //           .HasForeignKey<Room>(u => u.Id);


            base.OnModelCreating(builder);
        }
    }
}
