using System;
using System.Linq;
using System.Data.Entity;
using HealthcarePortal.Core.Models;
using HealthcarePortal.Core.Repositories;

namespace HealthcarePortal.Data.EFRepositories
{
    public class AppointmentRepository:IAppointmentRepository
    {
        private ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public IQueryable<Appointment> GetAppointments()
        {
            var entity = _context.Appointments.Include(p => p.Patient);
            _context.SaveChanges();

            return entity;
                
        }

        public Appointment GetAppointment(int id)
        {
            var entity = _context.Appointments.Find(id);
            _context.SaveChanges();

            return entity;
        }

        public void Add(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }


        public IQueryable<Appointment> Appointments => _context.Appointments;
    }
}

