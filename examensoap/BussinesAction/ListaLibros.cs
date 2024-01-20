using examensoap.BusinessMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examensoap.BussinesAction
{
    public class ListaLibros
    {
        public static List<Libro> libro = new List<Libro>()
        {
           new Libro()
           {
              Id = 1,
              TituloLibro ="Cien años de soledad"
           },
           new Libro()
           {
              Id = 2,
              TituloLibro ="1984"
           },
            new Libro()
           {
              Id = 3,
              TituloLibro ="Jack el cazador de gigantes "
           },
        };

        public static LibrosServices GetAllLibros()
        {
            return new LibrosServices() { Librosres = libro };
        }
    }
}