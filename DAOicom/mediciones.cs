//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOicom
{
    using System;
    using System.Collections.Generic;
    
    public partial class mediciones
    {
        public string noserie { get; set; }
        public int idcomponente { get; set; }
        public Nullable<int> marca { get; set; }
        public Nullable<int> tipo { get; set; }
        public Nullable<int> capacidad { get; set; }
        public Nullable<int> calificacion { get; set; }
        public string comentario { get; set; }
    
        public virtual componentes componentes { get; set; }
        public virtual maquinas maquinas { get; set; }
    }
}
