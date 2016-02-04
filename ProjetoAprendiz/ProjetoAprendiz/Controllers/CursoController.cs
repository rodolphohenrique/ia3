using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAprendiz.Class;
using ProjetoAprendiz.Models;

namespace ProjetoAprendiz.Controllers
{
    public class CursoController : Controller
    {
        // GET: Oficina
        public ActionResult Index()
        {
            return View(RecuperaTodosCursos());
        }

        private List<CursoView> RecuperaTodosCursos()
        {
            return CursoContext.GetAllCursos();
        }


        public ActionResult Create()
        {
            var model = new CursoView();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CursoView curso)
        {
            CursoContext.Salvar(curso);
            return View("Index", RecuperaTodosCursos());
        }




        [HttpPost]
        public ActionResult Edit(CursoView curso)
        {
            CursoContext.Editar(curso);
            return View("Index", RecuperaTodosCursos());
        }

        [HttpGet]
        public ActionResult Edit(int idCurso)
        {
            return View(CursoContext.GetCursoByID(idCurso));
        }

        public ActionResult Delete(int idCurso)
        {
            CursoContext.Deletar(idCurso);
            return View("Index");
        }
    }
}