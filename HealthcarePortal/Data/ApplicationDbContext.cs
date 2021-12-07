using System;
using HealthcarePortal.Core.Models;
using Microsoft.EntityFrameworkCore;


namespace HealthcarePortal.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}

