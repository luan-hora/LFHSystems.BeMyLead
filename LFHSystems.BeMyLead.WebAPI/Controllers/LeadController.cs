using LFHSystems.BeMyLead.Model;
using LFHSystems.BeMyLead.Repository;
using LFHSystems.BeMyLead.Repository.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace LFHSystems.BeMyLead.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : Controller
    {
        readonly LeadRepository repo;
        readonly BeMyLeadDBContext _ctx;
        public LeadController(IConfiguration configuration, BeMyLeadDBContext context)
        {
            this._ctx = context;
            repo = new LeadRepository(this._ctx);
        }

        [HttpPost]
        [Route("Insert")]
        public JsonResult Insert([FromBody] LeadModel pLead)
        {
            repo.Insert(ref pLead);
            return Json(pLead);
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update([FromBody] LeadModel pLead)
        {
            repo.Update(pLead);
            return Json(pLead);
        }

        [HttpDelete()]
        [Route("DeleteExistingLead/{pId}")]
        public IActionResult Delete(int pId)
        {            
            repo.Delete(new LeadModel() { ID = pId });
            return Ok();
        }

        [HttpGet]
        [Route("GetExistingLeadById/{pId}")]
        public JsonResult GetExistingLeadById(int pId)
        {
            LeadModel ret;
            ret = repo.GetByParameter(new LeadModel() { ID = pId });

            return Json(ret);
        }

        [HttpGet]
        [Route("GetExistingLeads")]
        public JsonResult GetExistingLeads()
        {
            IEnumerable<LeadModel> ret;
            ret = repo.GetAll();

            return Json(ret);
        }

        //// GET: LeadController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: LeadController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: LeadController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: LeadController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LeadController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: LeadController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LeadController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: LeadController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
