//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Granamiza.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.preferencias = new HashSet<preferencias>();
            this.simulacao = new HashSet<simulacao>();
            this.categoria = new HashSet<categoria>();
            this.transacao = new HashSet<transacao>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public Nullable<System.DateTime> data_criacao { get; set; }
    
        public virtual ICollection<preferencias> preferencias { get; set; }
        public virtual ICollection<simulacao> simulacao { get; set; }
        public virtual ICollection<categoria> categoria { get; set; }
        public virtual ICollection<transacao> transacao { get; set; }
    }
}
