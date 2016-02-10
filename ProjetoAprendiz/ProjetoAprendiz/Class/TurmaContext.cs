using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;

namespace ProjetoAprendiz.Class
{
    public static class TurmaContext
    {
        public static TurmaView GetTurmaByID(int id)
        {
            using (var context = new DatabaseEntities())
            {
                return context.Turma.Find(id).toTurma();
            }
        }

        public static List<TurmaView> GetAllTurma()
        {
            using (var context = new DatabaseEntities())
            {
                return context.Turma.ToList().toTurmas();
            }
        }

        public static void Salvar(TurmaView turma)
        {
            using (var context = new DatabaseEntities())
            {
                var item = new Turma()
                {
                    Descricao = turma.Descricao,
                    DataCriacao = turma.DataCriacao,
                    Nome = turma.Nome,
                    IdEstado = 1,

                };

                context.Turma.Add(item);
                context.SaveChanges();
            }
        }

        public static void Deletar(int id)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Turma.Find(id);

                context.Turma.Remove(item);
                context.SaveChanges();
            }
        }


        public static void Editar(TurmaView turma)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Turma.Find(turma.Id);

                item.Nome = turma.Nome;
                item.IdEstado = 1;
               
                item.DataCriacao = turma.DataCriacao;
                item.Descricao = turma.Descricao;
   
                context.SaveChanges();
            }
        }

    }
}