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
    public class PatientsController : Controller
    {
        private IPatientRepository repository;

        public PatientsController(IPatientRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {  
            return View(repository.Patients);
        }

        //GET - Create
        public IActionResult Add()
        {
            return View("PatientForm");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            { 
                repository.Add(patient);
                return RedirectToAction("Index");

            }

            return View("PatientForm");
        }


        public IActionResult Edit(int? id)
        {
            var editForm = repository.Patients.Where(p => p.Id == id).FirstOrDefault();

            return View("EditForm",editForm);
        }


        [HttpPost]
        public IActionResult Update(Patient patient)
        {
            repository.Update(patient);
            return RedirectToAction("Index");
        }
       
        public IActionResult DeletePost(int? id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
} 