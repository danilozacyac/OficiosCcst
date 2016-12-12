using ScjnUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficiosCcst.Dto
{
    public class Destinatario
    {
        private int idDestinatario;
        private string nombre;
        private string apellidos;
        private int idTitulo;
        private int idAdscripcion;
        private int idGenero = 1;

         public int IdDestinatario
        {
            get
            {
                return this.idDestinatario;
            }
            set
            {
                this.idDestinatario = value;
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingresa el nombre del destinatario")]
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingresa los apellidos del destinatario")]
        public string Apellidos
        {
            get
            {
                return this.apellidos;
            }
            set
            {
                this.apellidos = value;
            }
        }

        public int IdTitulo
        {
            get
            {
                return this.idTitulo;
            }
            set
            {
                this.idTitulo = value;
            }
        }

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

        public int IdGenero
        {
            get
            {
                return this.idGenero;
            }
            set
            {
                this.idGenero = value;
            }
        }

       

        public string NombreCompleto
        {
            get
            {
                return String.Format("{0} {1}", this.nombre, this.apellidos);
            }
        }

        public string NombreCompletoStr
        {
            get
            {
                return StringUtilities.PrepareToAlphabeticalOrder(this.NombreCompleto);
            }
        }
    }
}
