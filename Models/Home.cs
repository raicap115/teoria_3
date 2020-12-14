using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teoria_3.Models
{
    public class Home
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name="Nombre del producto")]
        public string nombre { get; set; }
        [Display(Name="URL de la foto")]
        public string url_foto { get; set; }
        [Display(Name="Descripción de la publicación")]
        public string descripcion { get; set; }
        [Display(Name="Precio a pagar")]
        public double precio { get; set; }
        [Display(Name="Celular de contacto")]
        public string celular { get; set; }
        [Display(Name="Lugar de compra")]
        public string lugar { get; set; }
        [Display(Name="Nombre del usuario")]
        public string usuario { get; set; }
    }
}