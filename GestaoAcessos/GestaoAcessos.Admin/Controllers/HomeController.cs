using GestaoAcessos.Admin.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoAcessos.Admin.Controllers
{
    [AdminAuthorize]
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        } 
    }
}