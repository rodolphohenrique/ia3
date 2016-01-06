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
        public static TurmaView GetOficinaByID(int id)
        {
            using (var context = new DataBaseEntities())
            {
                return context.Turma.Find(id).toTurma();
            }
        }

        public static List<TurmaView> GetAllTurma()
        {
            using (var context = new DataBaseEntities())
            {
                return context.Turma.ToList().toTurmas();
            }
        }

        public static void Salvar(TurmaView turma)
        {
            using (var context = new DataBaseEntities())
            {
                var item = new Turma()
                {
                    Descricao = turma.Descricao,
                    DataCriacao = turma.DataCriacao,
                    Nome = turma.Nome,
                    IdEstado = turma.IdEstado,
                    IdOficina = turma.IdOficina
                };

                context.Turma.Add(item);
                context.SaveChanges();
            }
        }

        public static void Deletar(int id)
        {
            using (var context = new DataBaseEntities())
            {
                var item = context.Turma.Find(id);

                context.Turma.Remove(item);
                context.SaveChanges();
            }
        }
    }
}