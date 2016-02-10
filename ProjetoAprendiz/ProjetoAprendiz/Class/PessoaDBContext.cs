﻿using System;
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
            using (var context = new DatabaseEntities())
            {
                return context.Pessoa.Find(id).toPessoaView();
            }
        }

        public static List<PessoaView> RecuperarListaPessoaFiltrada(string nomeFiltro, string CnpjCpfFiltro, string EmailFiltro, int idPessoaTipo)
        {
            using (var context = new DatabaseEntities())
            {
                return context.Pessoa.Where
                    (x => ((string.IsNullOrEmpty(nomeFiltro) || x.Nome.Contains(nomeFiltro))
                    && (string.IsNullOrEmpty(CnpjCpfFiltro) || x.CPFCNPJ.ToString().Contains(CnpjCpfFiltro))
                    && (string.IsNullOrEmpty(EmailFiltro) || x.Email.Contains(EmailFiltro))
                    && (idPessoaTipo == 0 || x.IdPessoaTipo.Equals(idPessoaTipo))
                    )).ToList().toPessoasView();
            }
        }

        public static List<PessoaView> RecuperarListaPessoasCompleta()
        {
            using (var context = new DatabaseEntities())
            {
                return context.Pessoa.ToList().toPessoasView();
            }
        }

        public static void Deletar(int idPessoa)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Pessoa.Find(idPessoa);

                context.Pessoa.Remove(item);
                context.SaveChanges();
            }
        }

        public static List<Models.PessoaTipo> GetAllPessoaTipo()
        {
            using (var context = new DatabaseEntities())
            {
                return context.PessoaTipo.ToList().toPessoasTipos();

            }
        }

        public static void Editar(PessoaView pessoa)
        {
            using (var context = new DatabaseEntities())
            {
                var item = context.Pessoa.Find(pessoa.Id);

                item.Nome = pessoa.Nome;
                item.Email = pessoa.Email;
                item.DataInclusao = pessoa.DataInclusao;
                item.DataNascimento = pessoa.DataNascimento;
                item.CPFCNPJ = pessoa.CPFCNPJ;
                item.IdPessoaTipo = pessoa.IdPessoaTipo;
                
                context.SaveChanges();

            }
        }

        public static void Salvar(PessoaView pessoa)
        {
            using (var context = new DatabaseEntities())
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

                int id = item.Id;

                if(pessoa.NomeRepresentante)
                    var representante = new Pessoa()
                    {

                    }
            }
        }

        public static List<Models.PessoaView> PesquisaPessoa(PessoaView pessoa)
        {
            using (var context = new DatabaseEntities())
            {
                var queryPessoas = (from p in context.Pessoa
                                   where p.Nome == pessoa.Nome
                                   select p).ToList();

                

            }
            List<PessoaView> listaPessoaView = new List<PessoaView>();
            return listaPessoaView;
        }

        public static Boolean ValidaCadastroPessoa(PessoaView pessoa)
        {
            if(pessoa.nome)

            return true;
        }

    }
}