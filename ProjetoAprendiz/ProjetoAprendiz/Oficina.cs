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
    
    public partial class Oficina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oficina()
        {
            this.Turma = new HashSet<Turma>();
            this.GradeMatricula = new HashSet<GradeMatricula>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataCriacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turma> Turma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeMatricula> GradeMatricula { get; set; }
    }
}
