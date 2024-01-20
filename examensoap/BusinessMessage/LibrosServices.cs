using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examensoap.BusinessMessage
{
    public class LibrosServices
    {
        public List<Libro> Librosres { get; set; }

        public bool ActionResult { get; set; }

        public string Error { get; set; }
    }
}