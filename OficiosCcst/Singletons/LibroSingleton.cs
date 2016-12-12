using System;
using System.Collections.Generic;
using System.Linq;
using OficiosCcst.Model;

namespace OficiosCcst.Singletons
{
    public class LibroSingleton
    {

        private static List<char> libros;


        public static List<char> Libros
        {
            get
            {
                if (libros == null)
                    libros = new AdscripcionModel().GetLibros();

                return libros;
            }
        }

    }
}
