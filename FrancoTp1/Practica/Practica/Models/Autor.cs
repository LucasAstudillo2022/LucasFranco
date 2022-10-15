using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Practica.Models
{
    public class Autor
    {     
        public int ID { get; set; }

      
        public string apellido { get; set; }

     
        public string nombre { get; set; }

       
        public string biografia { get; set; }
        

        public string foto { get; set; }


    }
}
