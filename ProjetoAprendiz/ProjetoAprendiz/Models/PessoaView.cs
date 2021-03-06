﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAprendiz.Models
{
    public class PessoaView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPFCNPJ { get; set; }
        public string Email { get; set; }
        public int IdPessoaTipo { get; set; }
        public string descricaoTipoPessoa { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataNascimento { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataInclusao { get; set; }

        public EnderecoView Endereco { get; set; }
        public TelefoneView Telefone { get; set; }

        public int IdRepresentante { get; set; }
        public string NomeRepresentante { get; set; }
        public int CPFCNPJRepresentante { get; set; }
        public string EmailRepresentante { get; set; }
        public int IdPessoaTipoRepresentante { get; set; }
        public string descricaoTipoPessoaRepresentante { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataNascimentoRepresentante { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataInclusaoRepresentante { get; set; }

        public List<PessoaTipo> PessoaTipos { get; set; }

        public PessoaTipo Tipo { get; set; }
    }
}