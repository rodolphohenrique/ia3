﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAprendiz.Models;
using ProjetoAprendiz.Class;



namespace ProjetoAprendiz.Class
{
    public static class CursoContext
    {

        public static CursoView GetCursoByID(int id)
        {
            using (var context = new DatabaseEntities())
            {
                return context.Curso.Find(id).toCursos();
            }
        }

        public static List<CursoView> GetAllCursos()
        {
            using (var context = new DatabaseEntities())
            {
                return context.Curso.ToList().toCursos();
            }
        }

        public static void Salvar(CursoView curso)
        {
            using (var context = new DatabaseEntities())
            {
                var item = new Curso()
                {
                    Nome = curso.Nome,
                    DataCriacao = curso.DataCriacao
                };

                context.Curso.Add(item);
                context.SaveChanges();
            }
        }

        public static void Deletar(int id)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Curso.Find(id);

                context.Curso.Remove(item);
                context.SaveChanges();
            }
        }


        public static void Editar(CursoView curso)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Curso.Find(curso.Id);

                item.Nome = curso.Nome;
                item.DataCriacao = curso.DataCriacao;

                context.SaveChanges();
            }
        }

    }
}