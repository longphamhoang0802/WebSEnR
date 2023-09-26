using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebSEnR.Data;
using WebSEnR.Models;

namespace WebSEnR.Controllers
{
    public class Projects : Controller
    {        
        private readonly SErNDBContext _db;

        public Projects(SErNDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// UniProjects region
        /// </summary>
        /// <returns></returns>
        public IActionResult UniProjects() 
        {
            IEnumerable<uni_project> unips = _db.uniprojects;
            return View("UniProjects",unips);
        }
        [HttpPost]
        public IActionResult AddUniProjects([FromBody] uni_project data)
        {
            _db.uniprojects.Add(data);
            _db.SaveChanges();
            return View("UniProjects");
        }
        [HttpPost]
        public IActionResult DeleteUniProjects(int id)
        {
            var obj = _db.uniprojects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.uniprojects.Remove(obj);
            _db.SaveChanges();
            return View("UniProjects");
        }
        /// <summary>
        /// MiProjects region
        /// </summary>
        /// <returns></returns>
        public IActionResult MiProjects() 
        {
            IEnumerable<ministerial_project> mips = _db.ministerialprojects;
            return View("MiProjects",mips);
        }
        [HttpPost]         
        public IActionResult AddMiProjects([FromBody] ministerial_project data) 
        {
            _db.ministerialprojects.Add(data);
            _db.SaveChanges();
            return View("MiProjects");
        }
        [HttpPost]
        public IActionResult DeleteMiProjects(int id)
        {
            var obj = _db.ministerialprojects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ministerialprojects.Remove(obj);
            _db.SaveChanges();
            return View("MiProjects");
        }
        /// <summary>
        /// Etp Projects Region
        /// </summary>
        /// <returns></returns>
        public IActionResult EtpProjects() 
        {
            
            return View("EtpProjects");
        }
        [HttpPost]
        public IActionResult AddEtpProjects([FromBody] enterprise_project data)
        {
            _db.enterpriseprojects.Add(data);
            _db.SaveChanges();
            return View("EtpProjects");
        }
        [HttpPost]
        public IActionResult DeleteEtpProjects(int id)
        {
            var obj = _db.enterpriseprojects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.enterpriseprojects.Remove(obj);
            _db.SaveChanges();
            return View("EtpProjects");
        }
        public IActionResult SSD()
        {
            IEnumerable<enterprise_project> etps = _db.enterpriseprojects;
            return View("SSD", etps);
        }
        public IActionResult SSE()
        {
            IEnumerable<enterprise_project> etps = _db.enterpriseprojects;
            return View("SSE", etps);
        }
        public IActionResult NV()
        {
            IEnumerable<enterprise_project> etps = _db.enterpriseprojects;
            return View("NV", etps);
        }
        public IActionResult ATM()
        {
            IEnumerable<enterprise_project> etps = _db.enterpriseprojects;
            return View("ATM", etps);
        }
        public IActionResult VDK()
        {
            IEnumerable<enterprise_project> etps = _db.enterpriseprojects;
            return View("VDK", etps);
        }
    }
}
