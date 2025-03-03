using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sambuloStudyGroup.Controllers
{
    public class StudyController : Controller
    {
        // GET: Study
        public ActionResult View1()
        {

            List<Models.StudyGroup> studymembers = new List<Models.StudyGroup>();
            studymembers.Add(new Models.StudyGroup { studentNumber = "u23542820", name = "Sambulo", surname = "Malobola", emailAddress = "u23542820@tuks.co.za" });
            studymembers.Add(new Models.StudyGroup { studentNumber = "u23662507", name = "Sabelo", surname = "Plaatjie", emailAddress = "u23662507@tuks.co.za" });
            studymembers.Add(new Models.StudyGroup { studentNumber = "u20731028", name = "Nomvuyo", surname = "Mthimkhulu", emailAddress = "u20731028@tuks.co.za" });
            studymembers.Add(new Models.StudyGroup { studentNumber = "u24885062", name = "Tumisho", surname = "Matlala", emailAddress = "u24885062@tuks.co.za" });
            studymembers.Add(new Models.StudyGroup { studentNumber = "u23629411", name = "Destiny", surname = "Edward", emailAddress = " u23629411@tuks.co.za" });

            return View(studymembers);
        }
    }
}