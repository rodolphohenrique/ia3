using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAprendiz.Models;

namespace ProjetoAprendiz.Class
{
    public static class Extension
    {
        public static PessoaView toPessoaView(this Pessoa data)
        {
            return new PessoaView()
            {
                Id = data.Id,
                Nome = data.Nome,
                CPFCNPJ = data.CPFCNPJ,
                Email = data.Email,
                DataNascimento = (DateTime)data.DataNascimento,
                DataInclusao = data.DataInclusao,
                IdPessoaTipo = data.IdPessoaTipo,
                Tipo = data.PessoaTipo.toPessoaTipo(),
                Telefone = data.Telefone.toTelefoneView(),
                Endereco = data.Endereco.toEnderecoView()                
            };
        }

        public static List<PessoaView> toPessoasView(this List<Pessoa> data)
        {
            return data.Select(x => x.toPessoaView()).ToList();
        }

        public static TelefoneView toTelefoneView(this Telefone data)
        {
            return new TelefoneView()
            {
                NumeroFixo = data.NumeroFixo,
                NumeroCelular = data.NumeroCelular
            };
        }

        public static EnderecoView toEnderecoView(this Endereco data)
        {
            return new EnderecoView()
            {
                Endereco = data.Endereco1,
                Complemento = data.Complemento,
                Numero = data.Numero,
                Cidade = data.Cidade,
                Estado = data.Estado,
                Bairro = data.Bairro,
                CEP = data.CEP,
                Pais = data.Pais
            };
        }

        public static Models.PessoaTipo toPessoaTipo(this PessoaTipo data)
        {
            return new Models.PessoaTipo()
            {
                Id = data.Id,
                Descricao = data.Descricao
            };
        }

        public static List<Models.PessoaTipo> toPessoasTipos(this List<PessoaTipo> data)
        {
            return data.Select(x => x.toPessoaTipo()).ToList();
        }

        public static OficinaView toOficina(this Oficina data)
        {
            return new OficinaView()
            {
                Id = data.Id,
                Nome = data.Nome,
                DataCriacao = data.DataCriacao
            };
        }

        public static List<OficinaView> toOficinas(this List<Oficina> data)
        {
            return data.Select(x => x.toOficina()).ToList();
        }


        public static CursoView toCursos(this Curso data)
        {
            return new CursoView()
            {
                Id = data.Id,
                Nome = data.Nome,
                DataCriacao = data.DataCriacao
            };
        }


        public static List<CursoView> toCursos(this List<Curso> data)
        {
            return data.Select(x => x.toCursos()).ToList();
        }

        public static TurmaView toTurma(this Turma data)
        {
            return new TurmaView()
            {
                Id = data.Id,
                Nome = data.Nome,
                DataCriacao = data.DataCriacao,
                Descricao = data.Descricao,
                IdEstado = data.IdEstado,
             
            };
        }

        public static List<TurmaView> toTurmas(this List<Turma> data)
        {
            return data.Select(x => x.toTurma()).ToList();
        }
    }
}