using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Actividades.Actividad2Universidad
{
    internal class Asignatura
    {
        private string codigo {  get; set; }
        private string nombre { get; set; }
        private string facultad {  get; set; }
        private int creditos { get; set; }
        private string tipo { get; set; }
        private string tipo2 { get; set; }

        public Asignatura (string codigo, string nombre, string facultad, int creditos, string tipo, string tipo2)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.facultad = facultad;
            this.creditos = creditos;
            this.tipo = tipo;
            this.tipo2 = tipo2;
        }

        public string getCodigo () { return codigo; }
        public string getNombre () { return nombre; }
        public string getFacultad () { return facultad; }
        public int getCreditos () { return creditos; }
        public string getTipo () { return tipo; }
        public string getTipo2 () { return tipo2; }
        
    }
}
