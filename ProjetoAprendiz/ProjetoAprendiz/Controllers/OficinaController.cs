using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;

namespace ProjetoAprendiz.Controllers
{
    public class OficinaController : Controller
    {
        // GET: Oficina
        public ActionResult Index()
        {
            return View(RecuperaTodasOficinas());
        }

        private List<OficinaView> RecuperaTodasOficinas()
        {
            return OficinaContext.GetAllOficina();
        }


        public ActionResult Create()
        {
            var model = new OficinaView();
            return View(model);
        }

       


    }
}