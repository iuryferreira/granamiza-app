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
    
    public partial class cotacao
    {
        public int id { get; set; }
        public decimal valor_dolar { get; set; }
        public decimal valor_euro { get; set; }
        public System.DateTime data_consulta { get; set; }
        public decimal valor_bitcoin { get; set; }
        public int usuario_id { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
