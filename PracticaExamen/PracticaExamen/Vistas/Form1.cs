using PracticaExamen.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamen
{
    public partial class Form1 : Form
    {
        BaseDatos db ;
        public Form1()
        {
            InitializeComponent();
            db = new BaseDatos();
            cargarLista();
            cargarGrafico();
        }

       public void cargarLista()
        {
           dgTabla.DataSource= db.Database.SqlQuery<ReporteVendedores>("SELECT  V.Nombre, SUM(T.Cantidad * P.Precio) AS Total FROM    Venta T, Vendedor V, Producto P WHERE   V.Id = T.Id Group by V.Nombre; ").ToList<ReporteVendedores>();
        }

        public void cargarGrafico()
        {
            chart1.DataSource = db.Database.SqlQuery<ReporteVendedores>("SELECT  V.Nombre, SUM(T.Cantidad * P.Precio) AS Total FROM    Venta T, Vendedor V, Producto P WHERE   V.Id = T.Id Group by V.Nombre; ").ToList<ReporteVendedores>();
            chart1.Titles.Add("Ventas Mes");
            
            chart1.Series[0].XValueMember = "Nombre";
            chart1.Series[0].YValueMembers = "Total";
        }
       
    }
}
