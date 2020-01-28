using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public String Vacante { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required]
        [StringLength(100)]
        public String Empresa { get; set; }
        [Required]
        [StringLength(60)]
        public String Categoria { get; set; }
        public DateTime Publicacion { get; set; }
        public List<Comentarios> Comentarios { get; set; }

    }
}