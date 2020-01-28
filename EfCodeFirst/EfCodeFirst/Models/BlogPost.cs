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
        public String Titulo { get; set; }
        [Required]
        public String Contenido { get; set; }
        [StringLength(100)]
        public String Autor { get; set; }
        public DateTime Publicacion { get; set; }
        public List<Comentarios> Comentarios { get; set; }

    }
}