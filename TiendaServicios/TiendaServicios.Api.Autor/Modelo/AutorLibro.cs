using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.Autor.Modelo
{
    public class AutorLibro
    {
        public int AutorLibroId {get; set; }
        public string Nobmre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        /*
        * es un valor unico universal el cua cuando y oquiera trasmitir o darle seguimiento
        * a un record de un objeto o elemento desde otro microservices
        */

        public string AutorLibroGuid { get; set; }
        public ICollection<GradoAcademico> ListaGradoAcademico{ get; set; }

    }
}
