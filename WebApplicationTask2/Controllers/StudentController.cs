using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTask2.Models;

namespace WebApplicationTask2.Controllers
{
    public class StudentController : Controller
    {
        public List<student> add()
        {
            contextdb contextdb = new contextdb();
            var t = contextdb.students.ToList();
            contextdb.SaveChanges();
            return t;
        }
        public IActionResult Index()
        {

            return View();
        }
        public ActionResult studentadd()
        {
            contextdb contextdb = new contextdb();
            var t = contextdb.students.Include(x=>x.department).ToList();
            contextdb.SaveChanges();
            
            return View(t);
        }
        public IActionResult deteals(int id)
        {
            contextdb contextdb0= new contextdb();

            var t=contextdb0.students.Include(x => x.department).Where(x=>x.Id == id).FirstOrDefault();
           


            return View(t);
        }

        public IActionResult insertstudent(student st)
        {
            testviewmodel model = new testviewmodel(); 
           
            contextdb contextdb1 = new contextdb();
           var k= contextdb1.departments.ToList();
            
            model.department = k;
            model.student = st;
            return View(model);

        }
        public IActionResult fulladd(student st)
        {
            if (st.Name != null) {
                contextdb contextdb1 = new contextdb();
                contextdb1.Add(st);
                contextdb1.SaveChanges();
                return RedirectToAction("studentadd");
            }
            else
                return RedirectToAction("insertstudent",st);

        }
        public IActionResult updatestud(int id)
        {
            contextdb db = new contextdb();
            
            var y = db.students.Include(x=>x.department).Where(x => x.Id == id).FirstOrDefault();
            ViewBag.Departments = db.departments.ToArray();
            return View(y);

        }
        public IActionResult updateed(student st) { 
            contextdb db= new contextdb();
           var y= db.students.Include(x=>x.department).Where(x=>x.Id==st.Id).FirstOrDefault();
            y.Name = st.Name;
            y.address = st.address;
            
            y.age = st.age;
            y.imge = st.imge;
            db.students.Update(y);
            db.SaveChanges();

            return RedirectToAction("studentadd");


        }
       
    }
}
