using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Modelo
{
   [Table("Venta")]
   
    public class Venta
    {
        Controlador.Venta v = new Controlador.Venta();
        BaseDatos db = new BaseDatos();
        public int Id { get; set; }
        public Vendedor Vendedor { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }



        public DataTable ventasPorPersona()
        {
            db.Database.SqlQuery<ReporteVendedores>("SELECT  V.Nombre, SUM(T.Cantidad * P.Precio) AS Total FROM    Venta T, Vendedor V, Producto P WHERE   V.Id = T.Id Group by V.Nombre; ").ToList<ReporteVendedores>();

            return v.ventasPorPersona() ;
        }
    }
}
