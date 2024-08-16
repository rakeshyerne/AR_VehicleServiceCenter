using Microsoft.EntityFrameworkCore;
using AR_VehicleServiceCenter.Models;

namespace AR_VehicleServiceCenter.Data
{
    public class VehicleServiceContext : DbContext
    {
        public VehicleServiceContext(DbContextOptions<VehicleServiceContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<RegisterModel> RegisterModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(c => c.Appointments)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Vehicle)
                .WithOne(v => v.Appointment)
                .HasForeignKey<Vehicle>(v => v.AppointmentId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Mechanic)
                .WithMany(m => m.Appointments)
                .HasForeignKey(a => a.MechanicId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Service);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Payment)
                .WithOne(p => p.Invoice)
                .HasForeignKey<Payment>(p => p.InvoiceId);

            modelBuilder.Entity<User>()
                .Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
