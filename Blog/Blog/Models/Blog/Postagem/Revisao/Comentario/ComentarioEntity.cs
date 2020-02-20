using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem.Revisao.Comentario
{
    public class ComentarioEntity
    {
        public RevisaoEntity Revisao;
        public string Texto;
        public string Autor;
        public DateTime Data;
    }
}
