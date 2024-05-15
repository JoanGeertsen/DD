using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej1
{
    internal class Estudiante: Persona
    {
        #region Atributos
        private string legajo;
        private string carrera;
        private string fechaDeIngreso;
        private static string legajoPorDefecto = "444444";
        #endregion

        #region Constructores
        public Estudiante(string documento, string legajo): base(documento) 
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            carrera = ""; fechaDeIngreso = "";
        }

        public Estudiante(String documento, string nombre, string apellido, string fechaNacimiento,
            string legajo, string carrera, string fechaDeIngreso): base(documento, nombre, apellido, fechaNacimiento) 
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            this.carrera = (carrera != null) ? carrera : "";
            this.fechaDeIngreso = (fechaDeIngreso != null) ? fechaDeIngreso : "";            
        }
        #endregion

        #region Property
        public string Legajo
        {
            get { return legajo; }
            set { legajo = (value.Length == 6) ? value: legajoPorDefecto; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = (value != null) ? value : ""; }
        }

        public string FechaDeIngreso
        {
            get { return fechaDeIngreso; }
            set { fechaDeIngreso = (value != null) ? value : ""; }
        }
        #endregion

        #region Consultas
        public override string mostrar()
        {
            return base.mostrar() + $"\n Legajo: {legajo} \n{carrera}\n Fecha de ingreso: {fechaDeIngreso}";
        }

        public bool esIgual(Estudiante e)
        {
            return legajo.Equals(e.Legajo) || base.esIgual(e);
        }
        #endregion
    }
}
