using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;

namespace ProjetoAprendiz.Class
{
    public static class OficinaContext
    {
        public static OficinaView GetOficinaByID(int id)
        {
            using (var context = new DatabaseEntities())
            {
                return context.Oficina.Find(id).toOficina();
            }
        }

        public static List<OficinaView> GetAllOficina()
        {
            using (var context = new DatabaseEntities())
            {
                return context.Oficina.ToList().toOficinas();
            }
        }

        public static void Salvar(OficinaView oficina)
        {
            using (var context = new DatabaseEntities())
            {
                var item = new Oficina()
                {
                    Nome = oficina.Nome,
                    DataCriacao = oficina.DataCriacao
                };

                context.Oficina.Add(item);
                context.SaveChanges();
            }
        }

        public static void Deletar(int id)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Oficina.Find(id);

                context.Oficina.Remove(item);
                context.SaveChanges();
            }
        }


        public static void Editar(OficinaView oficina)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Oficina.Find(oficina.Id);

                item.Nome = oficina.Nome;
                item.DataCriacao = oficina.DataCriacao;

                context.SaveChanges();
            }
        }

    }
}