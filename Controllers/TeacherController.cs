using Studentt_Teacer_Crud;
using Studentt_Teacer_Crud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Studentt_Teacer_Crud.data;

namespace SampleMvc.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ApplicationDBContext _db;

        public SubjectController(ApplicationDBContext db)
        {
            _db = db;
        }
        // public IActionResult Index()
        // {
        //     IEnumerable<Subject> listofsubjects = _db.Subject;
        //     return View(listofsubjects);
        // }
  
   public IActionResult Index(string searchString)
        {

            IEnumerable<Subject> objList = _db.Subject;

            if(!String.IsNullOrEmpty(searchString))
            {
                objList = objList.Where(s => s.Subject_Name.Contains(searchString));
            }
            return View(objList);
        }

         public IActionResult Create()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind(" Subject_Name,credits,SubjectID,syllabus,StudentId")] Subject subobj)
        {
            if (ModelState.IsValid)
            {
                _db.Subject.Add(subobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subobj);
        }



        [HttpGet]
        public IActionResult Edit(int subjectid)
        {
            var subobj = _db.Subject.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Subject updatedvaluesobj)
        {
            _db.Subject.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        
[HttpGet]
        public IActionResult Delete(int subjectid)
        {
            var subobj = _db.Subject.Find(subjectid);
             if (ModelState.IsValid)
            {
                _db.Subject.Remove(subobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subobj);
        }




    }
}