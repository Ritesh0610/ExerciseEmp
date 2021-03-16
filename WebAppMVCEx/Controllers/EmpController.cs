using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCEx.Models;

namespace WebAppMVCEx.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<Emp> listEmp = new List<Emp>
        {
             new Emp{EId=1,EName="Sam",EDesig="Manager",EDOJ=DateTime.Parse("12/12/2012")},
             new Emp{EId=2,EName="Anita",EDesig="HR",EDOJ=DateTime.Parse("02/11/2018")},
             new Emp{EId=3,EName="Mohan",EDesig="Developer",EDOJ=DateTime.Parse("07/03/2020")},
             new Emp{EId=4,EName="Rakesh",EDesig="Manager",EDOJ=DateTime.Parse("10/10/2011")},
        };
            return View(listEmp);
        }
    }
}