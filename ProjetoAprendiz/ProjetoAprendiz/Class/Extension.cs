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
                IdPessoaTipo = data.IdPessoaTipo
            };
        }

        public static List<PessoaView> toPessoasView(this List<Pessoa> data)
        {
            return data.Select(x => x.toPessoaView()).ToList();
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

        public static TurmaView toTurma(this Turma data)
        {
            return new TurmaView()
            {
                Id = data.Id,
                Nome = data.Nome,
                DataCriacao = data.DataCriacao,
                Descricao = data.Descricao,
                IdEstado = data.IdEstado,
                IdOficina = data.IdOficina
            };
        }

        public static List<TurmaView> toTurmas(this List<Turma> data)
        {
            return data.Select(x => x.toTurma()).ToList();
        }
    }
}