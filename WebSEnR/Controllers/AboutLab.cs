using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebSEnR.Data;
using WebSEnR.Models;
using static WebSEnR.Controllers.HomeController;

namespace WebSEnR.Controllers
{
    public class AboutLab : Controller
    {
        private readonly SErNDBContext _db;

        public AboutLab(SErNDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Equipment()
        {
            return View("Equipment");
        }
        public IActionResult Research()
        {
            return View("Research");
        } 
        /// <summary>
        /// Member region
        /// </summary>
        /// <returns></returns>
        public IActionResult Member()
        {
            IEnumerable<lab_member> lab_members = _db.lab_members;
            return View("Member",lab_members);
        }
        [HttpPost]
        public IActionResult DeleteMember(int id)
        {
            var obj = _db.lab_members.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.lab_members.Remove(obj);
            _db.SaveChanges();
            return View("Index");
        }
        [HttpPost]
        public IActionResult AddMemberFrQueueToMember(int id)
        {
            var obj = _db.registerqueue.Find(id);
            if (obj != null)
            {
                lab_member data = new lab_member()
                {
                    name = obj.fname,
                    school = obj.school,
                    facul = obj.faculty,
                    grade = obj.grade,
                    role = "Member",
                    desc = obj.desc_abtme,
                    joined_prjs = "",
                };

                _db.lab_members.Add(data);
                _db.registerqueue.Remove(obj);
                _db.SaveChanges();
            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult DeleteMemberatQueue(int id)
        {
            var obj = _db.registerqueue.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.registerqueue.Remove(obj);
            _db.SaveChanges();
            return View("Product");
        }
        /// <summary>
        /// Document region
        /// </summary>
        /// <returns></returns>
        public IActionResult Document()
        {
            return View("Document");
        }
        /// <summary>
        /// Product region
        /// </summary>
        /// <returns></returns>
        public IActionResult Product()
        {
            IEnumerable<labproduct> labproducts = _db.labproducts;
            return View("Product", labproducts);
        }

        [HttpPost]
        public IActionResult UpdateNewPost([FromBody] labproduct data)
        {
            _db.labproducts.Add(data);
            _db.SaveChanges();
            return View("Product");
        }

        [HttpPost]
        public IActionResult DeletePOST(int id)
        {
            var obj = _db.labproducts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.labproducts.Remove(obj);
            _db.SaveChanges();
            return View("Product");
        }
    }
}
