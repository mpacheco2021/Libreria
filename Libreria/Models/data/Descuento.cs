//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libreria.Models.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Descuento
    {
        public short IdDescuento { get; set; }
        public short IdProducto { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.###}", ApplyFormatInEditMode = true)]
        public decimal Porcentaje { get; set; }
        public System.DateTime FechaIni { get; set; }
        public System.DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
