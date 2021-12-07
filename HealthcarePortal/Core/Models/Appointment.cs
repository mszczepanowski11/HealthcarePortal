using System;
using System.Collections.ObjectModel;

namespace HealthcarePortal.Core.Models
{
    public class Appointment
    {
        public int Id { get; set;}
        public DateTime StartingDate { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
        public Patient Patient { get; set;}

        public ICollection<Patient> Patients { get; set; }

        public Appointment()
        {
            Patients = new Collection<Patient>();
        }
    }
}

