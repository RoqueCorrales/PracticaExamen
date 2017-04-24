using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Modelo
{
    [Table("Vendedor")]
    public class Vendedor
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Zona { get; set; }

        

    }
}
