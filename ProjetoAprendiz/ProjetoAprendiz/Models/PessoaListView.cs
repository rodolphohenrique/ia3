using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAprendiz.Models
{
    public class PessoaListView
    {
        public List<PessoaTipo> PessoaTipos { get; set; }
        public List<PessoaView> Pessoas { get; set; }
        public List<PessoaTipo> PessoaTiposDropDownList { get; set; }
    }
}