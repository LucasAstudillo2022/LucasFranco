using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Text;


namespace Practica.Models
{
    public class Genero
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public List<Libro> listalibro { get; set; }
    }
}
