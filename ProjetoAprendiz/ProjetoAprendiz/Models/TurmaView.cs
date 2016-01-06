using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAprendiz.Models
{
    public class TurmaView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdOficina { get; set; }
        public DateTime DataCriacao { get; set; }
        public int IdEstado { get; set; }
    }
}