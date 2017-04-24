using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Modelo
{
  public  class BaseDatos : DbContext
    {
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}
