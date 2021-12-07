using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HealthcarePortal.Core.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Token { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public byte CityId { get; set; }
        public DateTime DateTime { get; set; }
        [Required]
        public string Height { get; set; }
        [Required]
        public string Weight { get; set; }


        public ICollection<Appointment> Appointments { get; set; }

        public Patient()
        {
            Appointments = new Collection<Appointment>();
        }
    }
}

