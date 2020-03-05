using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Categoria
{
    public class CategoriaEntity
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }
    }
}
