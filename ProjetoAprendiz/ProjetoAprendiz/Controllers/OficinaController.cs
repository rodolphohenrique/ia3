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

        [HttpPost]
        public ActionResult Create(OficinaView oficina)
        {
            OficinaContext.Salvar(oficina);
            return View("Index", RecuperaTodasOficinas());
        }




        [HttpPost]
        public ActionResult Edit(OficinaView oficina)
        {
            OficinaContext.Editar(oficina);
            return View("Index", RecuperaTodasOficinas());
        }

        [HttpGet]
        public ActionResult Edit(int idOficina)
        {
            return View(OficinaContext.GetOficinaByID(idOficina));
        }

        public ActionResult Delete(int idOficina)
        {
            OficinaContext.Deletar(idOficina);
            return View("Index");
        }


    }
}