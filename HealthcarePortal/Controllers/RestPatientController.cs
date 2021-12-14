using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthcarePortal.Core.Repositories;
using HealthcarePortal.Data;
using HealthcarePortal.Core.Models;

namespace HealthcarePortal.Controllers
{
    [Route(template:"/api/[controller]")]
    public class RestPatientController : Controller
    {
        private IPatientRepository _repository;

        public RestPatientController(IPatientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatient() { }
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id) { }
        public IActionResult Index()
        {
            return View();
        }
    }
}