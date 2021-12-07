using System;
using System.Data.Entity;
using System.Collections.Generic;
using HealthcarePortal.Core.Repositories;
using HealthcarePortal.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthcarePortal.Data.EFRepositories
{
    public class PatientRepository:IPatientRepository
    {
    
        private ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
         
        }

        public Patient Find(int? id)
        {
            return _context.Patients.Find(id);
        }

        public Patient Delete(int? id)
        {
            var entity = _context.Patients.Remove(Find(id)).Entity;
            _context.SaveChanges();

            return entity; 
        }

        public Patient Add(Patient patient)
        {
            var entity = _context.Patients.Add(patient).Entity;
            _context.SaveChanges();

            return entity;
        }


        public Patient Update(Patient patient)
        {
            var entity = _context.Patients.Where(p => p.Id == patient.Id).FirstOrDefault();

            _context.Patients.Remove(entity);
            _context.Patients.Add(patient);
            _context.SaveChanges();

            return entity;
        }


        public IQueryable<Patient> Patients => _context.Patients;
    }
}