using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaOO.Models
{
    public class Context : DbContext
    {
        public Context() : base("coisasecoisas") { }

        public DbSet<Conta> conta { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<Estoque> estoque { get; set; }
    }
}