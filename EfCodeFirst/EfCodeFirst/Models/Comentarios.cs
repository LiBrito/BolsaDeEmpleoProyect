using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class Comentarios
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Autor { get; set; }
        [Required]
        public string Contenido { get; set; }
        public int BlogPostId { get; set; }
        [ForeignKey("Id")]
        public BlogPost BlogPost { get; set; }
    }

}