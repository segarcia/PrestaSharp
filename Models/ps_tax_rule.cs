//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrestaSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ps_tax_rule
    {
        public int id_tax_rule { get; set; }
        public int id_tax_rules_group { get; set; }
        public int id_country { get; set; }
        public int id_state { get; set; }
        public string zipcode_from { get; set; }
        public string zipcode_to { get; set; }
        public int id_tax { get; set; }
        public int behavior { get; set; }
        public string description { get; set; }
    }
}