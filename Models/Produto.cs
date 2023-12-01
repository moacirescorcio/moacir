using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moacir.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Descricao {get; set;}
        public string PathImagem {get; set;}
        public float Preco {get; set;}

        public int Quatidade {get;set;}

        public int Categoria {get; set;}
    }
}