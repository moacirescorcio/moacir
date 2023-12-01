using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using moacir.Models;

namespace democsharp.Models
{
   public class MyDbContext : DbContext
   {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

       public DbSet<Usuario> Usuarios {get; set;}
       public DbSet<Produto> Produtos {get; set;}

       public DbSet<Carrinho> Carrinhos{get; set;}
       public DbSet<Categoria> Categorias{get; set;}
   }
}
