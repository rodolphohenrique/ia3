using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;

namespace ProjetoAprendiz.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            return View(PessoaDBContext.RecuperarListaPessoasCompleta());
        }

        public ActionResult Create()
        {
            var model = new PessoaView();
            model.PessoaTipos = PessoaDBContext.GetAllPessoaTipo();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(PessoaView pessoa)
        {
            PessoaDBContext.Salvar(pessoa);
            return View("Index");
        }

        public ActionResult Edit(int idPessoa)
        {
            return View(PessoaDBContext.GetPessoaById(idPessoa));
        }

        public ActionResult Delete(int idPessoa)
        {
            PessoaDBContext.Deletar(idPessoa);    
            return View("Index");
        }
    }
}