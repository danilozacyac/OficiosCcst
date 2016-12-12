using OficiosCcst.Dto;
using OficiosCcst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficiosCcst.Singletons
{
    public class AdscripcionSingleton
    {

        private static List<Adscripcion> adscripciones;


        public static List<Adscripcion> Adscripciones
        {
            get
            {
                if (adscripciones == null)
                    adscripciones = new AdscripcionModel().GetAdscripciones();

                return adscripciones;
            }
        }

    }
}