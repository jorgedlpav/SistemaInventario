using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Numero de Serie es Requerido")]
        [MaxLength(60,ErrorMessage ="Serie debe ser Maximo 60 Caracteres")]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage ="Descripcion debe ser Requerida")]
        [MaxLength(100,ErrorMessage ="Descripcion debe ser maximo 100 Caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Precio debe ser Requerida")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Costo debe ser Requerida")]
        public double Costo { get; set; }
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Estado debe ser Requerida")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "CategoriaId debe ser Requerida")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "MarcaId debe ser Requerida")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }
        public int? PadreId { get; set; }
        public virtual Producto Padre  { get; set; }
    }
}
