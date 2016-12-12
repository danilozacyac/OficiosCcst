using System;
using System.Collections.Generic;
using System.Linq;

namespace OficiosCcst.Dto
{
    public class Archivistica
    {
        private int idArchivistica;
        private int idPadre;
        private string clave;
        private string descripcion;
        private string descripcionStr;
        private string observaciones;
        private List<Archivistica> child;


        public int IdArchivistica
        {
            get
            {
                return this.idArchivistica;
            }
            set
            {
                this.idArchivistica = value;
            }
        }

        public int IdPadre
        {
            get
            {
                return this.idPadre;
            }
            set
            {
                this.idPadre = value;
            }
        }

        public string Clave
        {
            get
            {
                return this.clave;
            }
            set
            {
                this.clave = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public string DescripcionStr
        {
            get
            {
                return this.descripcionStr;
            }
            set
            {
                this.descripcionStr = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return this.observaciones;
            }
            set
            {
                this.observaciones = value;
            }
        }

        public List<Archivistica> Child
        {
            get
            {
                return this.child;
            }
            set
            {
                this.child = value;
            }
        }

        
    }
}
