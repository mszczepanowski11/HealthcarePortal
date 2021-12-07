using System;
using System.Linq;
using HealthcarePortal.Core.Models;
namespace HealthcarePortal.Core.Repositories
{
    public interface IPatientRepository
    {
        IQueryable<Patient> Patients { get; }

        Patient Find(int? id); 
        Patient Delete(int? id);
        Patient Add(Patient patient);
        Patient Update(Patient patient);
    }
}

   