using Practica.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
[assembly: ComVisible(false)]
[assembly: Guid("ace40b2a-9071-41f2-a4ec-5e314181e5c9")]

namespace Practica
{
    public class Libro
    {

      
        public int ID { get; set; }
     
        public string titulo { get; set; }

  
        public string resumen { get; set; }
        
        public DateTime fechapubli { get; set; }
        
        public string fotoportada { get; set; }

        public int generoId { get; set; }
        public int autorId { get; set; }

        public Genero genero { get; set; }
        public Autor autor { get; set; }
       
    }
}
