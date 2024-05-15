using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DD_TP3_ej1
{    
    internal class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected string documento;
        protected string fechaNacimiento;
        private static string documentoPorDefecto="44.444.444";
        #endregion

        #region Constructores
        public Persona(string documento) 
        {
            this.documento = (documento.Length == 10) ? documento: documentoPorDefecto;
            nombre = ""; apellido = ""; fechaNacimiento="";
        }

        public Persona(String documento, string nombre, string apellido, string fechaNacimiento) 
        { //Las comprobaciones son temporales, hay que cambiarlas
            this.documento = (documento.Length == 10) ? documento : documentoPorDefecto;
            this.nombre = (nombre!=null) ? nombre : "";
            this.apellido = (apellido != null) ? apellido : "";
            this.fechaNacimiento = (fechaNacimiento != null) ? fechaNacimiento : "";
        }
        #endregion

        #region Property
        public string Documento
        {
            get { return documento; }
            set { documento = (value.Length == 10) ? value : documentoPorDefecto; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = (value != null) ? value : ""; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = (value != null) ? value : ""; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = (value != null) ? value : ""; }
        }
        #endregion

        #region Static       
        #endregion

        #region Consultas
        public virtual string mostrar()
        {
            return $" {nombre}, {apellido}\n Documento: {documento}\n Fecha de nacimiento: {fechaNacimiento}";
        }

        public bool esIgual(Persona p)
        {
            return documento.Equals(p.Documento);
        }
        #endregion
    }
}
