using Blog.Models.Blog.Autor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public string Titulo;
        public AutorEntity autor;

    }

    public class PostagemSobreFilmesEntity : PostagemEntity
    {
        public string Genero;
    }
}
