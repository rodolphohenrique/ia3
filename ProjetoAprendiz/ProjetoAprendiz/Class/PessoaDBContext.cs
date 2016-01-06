using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;

namespace ProjetoAprendiz.Class
{
    public static class PessoaDBContext
    {
        public static PessoaView GetPessoaById(int id)
        {
            using (var context = new DataBaseEntities())
            {
                return context.Pessoa.Find(id).toPessoaView();
            }
        }

        public static List<PessoaView> RecuperarListaPessoasCompleta()
        {
            using (var context = new DataBaseEntities())
            {
                return context.Pessoa.ToList().toPessoasView();
            }
        }

        public static void Deletar(int idPessoa)
        {
            using (var context = new DataBaseEntities())
            {
                var item = context.Pessoa.Find(idPessoa);

                context.Pessoa.Remove(item);
                context.SaveChanges();
            }
        }

        public static List<Models.PessoaTipo> GetAllPessoaTipo()
        {
            using (var context = new DataBaseEntities())
            {
                return context.PessoaTipo.ToList().toPessoasTipos();

            }
        }

        public static void Salvar(PessoaView pessoa)
        {
            using (var context = new DataBaseEntities())
            {
                var item = new Pessoa()
                {
                    Nome = pessoa.Nome,
                    Email = pessoa.Email,
                    DataInclusao = DateTime.Now,
                    DataNascimento = pessoa.DataNascimento,
                    CPFCNPJ = pessoa.CPFCNPJ,
                    IdAtividade = 1,
                    IdPessoaTipo = pessoa.IdPessoaTipo
                };

                context.Pessoa.Add(item);
                context.SaveChanges();
            }
        }

    }
}