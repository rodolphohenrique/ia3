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
            return View(NovaInstanciaPessoasListView(string.Empty, string.Empty, string.Empty, 0));
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
            return View("Index", NovaInstanciaPessoasListView(string.Empty, string.Empty, string.Empty, 0));
        }

        [HttpGet]
        public ActionResult Pesquisar(string NomeFiltro, string CnpjCpfFiltro, string EmailFiltro, int idPessoaTipo)
        {
            return View("Index", NovaInstanciaPessoasListView(NomeFiltro, CnpjCpfFiltro, EmailFiltro, idPessoaTipo));
        }

        private PessoaListView NovaInstanciaPessoasListView(string NomeFiltro, string CnpjCpfFiltro, string EmailFiltro, int idPessoaTipo)
        {
            var objeto =  new PessoaListView()
            {
                Pessoas = PessoaDBContext.RecuperarListaPessoaFiltrada(NomeFiltro, CnpjCpfFiltro, EmailFiltro, idPessoaTipo),
                PessoaTipos = PessoaDBContext.GetAllPessoaTipo()
            };

            objeto.PessoaTipos.Insert(0, new Models.PessoaTipo() { Id = 0, Descricao = "Todos" });

            return objeto;
        }

        [HttpPost]
        public ActionResult Edit(PessoaView pessoa)
        {
            if(pessoa.descricaoTipoPessoa == "Física")
            {
                pessoa.IdPessoaTipo = 1;
            }
            else
            {
                pessoa.IdPessoaTipo = 2;
            }
            PessoaDBContext.Editar(pessoa);
            return View("Index", PessoaDBContext.RecuperarListaPessoasCompleta());
        }

        [HttpGet]
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