using System;
using HealthcarePortal.Core.Models;
namespace HealthcarePortal.Core.Repositories
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }
        Appointment GetAppointment(int id);
        void Add(Appointment appointment);
    }
}

