//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoAprendiz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            this.GradeProfessor = new HashSet<GradeProfessor>();
            this.Matricula = new HashSet<Matricula>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPFCNPJ { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public System.DateTime DataInclusao { get; set; }
        public string Email { get; set; }
        public int IdAtividade { get; set; }
        public int IdPessoaTipo { get; set; }
        public Nullable<int> IdTelefone { get; set; }
        public Nullable<int> IdEndereco { get; set; }
        public bool IsAtivo { get; set; }
    
        public virtual Atividade Atividade { get; set; }
        public virtual Endereco Endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeProfessor> GradeProfessor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual PessoaTipo PessoaTipo { get; set; }
        public virtual Telefone Telefone { get; set; }
    }
}
