using OficiosCcst.Dto;
using OficiosCcst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficiosCcst.Singletons
{
    public class ArchivisticaSingleton
    {

        private static List<Archivistica> archivistica;


        public static List<Archivistica> Archivistica
        {
            get
            {
                if (archivistica == null)
                    archivistica = new ArchivisticaModel().GetArchivistica();

                return archivistica;
            }
        }

    }
}
