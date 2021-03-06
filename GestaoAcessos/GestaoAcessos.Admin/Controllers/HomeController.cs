﻿using GestaoAcessos.Admin.Utils;
using GestaoAcessos.Business.Components;
using GestaoAcessos.Business.Factories;
using NHibernate;
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
 
        public HomeController()
        {

            ISession _session = SessionFactory.Open(); 
        }
        protected override void Dispose(bool disposing)
        {
            SessionFactory.Close();
        }



        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        } 
    }
}