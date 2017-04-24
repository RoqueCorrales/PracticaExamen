﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Modelo
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public double Precio { get; set; }


    }
}
