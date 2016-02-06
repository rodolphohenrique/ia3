using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;

namespace ProjetoAprendiz.Controllers
{
    public class TurmaController : Controller
    {
        // GET: Turma
        public ActionResult Index()
        {
            List<TurmaView> listaTurma = TurmaContext.GetAllTurma();
            return View("Index",listaTurma);
        }

        public ActionResult Create()
        {
            var model = new TurmaView();
            model.listaOficina = OficinaContext.GetAllOficina();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(TurmaView turma)
        {
            TurmaContext.Salvar(turma);
            return View("Index", TurmaContext.GetAllTurma());
        }

        [HttpPost]
        public ActionResult Edit(TurmaView turma)
        {
            TurmaContext.Editar(turma);
            return View("Index", TurmaContext.GetAllTurma());
        }

        [HttpGet]
        public ActionResult Edit(int idTurma)
        {
            return View(TurmaContext.GetTurmaByID(idTurma));
        }


    }
}