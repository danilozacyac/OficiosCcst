using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficiosCcst.Dto
{
    public class Adscripcion
    {
        private int idAdscripcion;
        private string adscripcions;
        private string adscripcionStr;
        private int idResponsable;
        private char libro;
        private int nivel;
        private bool isEnable;

        public int IdAdscripcion
        {
            get
            {
                return this.idAdscripcion;
            }
            set
            {
                this.idAdscripcion = value;
            }
        }

        public string Adscripcions
        {
            get
            {
                return this.adscripcions;
            }
            set
            {
                this.adscripcions = value;
            }
        }

        public string AdscripcionStr
        {
            get
            {
                return this.adscripcionStr;
            }
            set
            {
                this.adscripcionStr = value;
            }
        }

        public int IdResponsable
        {
            get
            {
                return this.idResponsable;
            }
            set
            {
                this.idResponsable = value;
            }
        }

        public char Libro
        {
            get
            {
                return this.libro;
            }
            set
            {
                this.libro = value;
            }
        }

        public int Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        public bool IsEnable
        {
            get
            {
                return this.isEnable;
            }
            set
            {
                this.isEnable = value;
            }
        }
    }
}
