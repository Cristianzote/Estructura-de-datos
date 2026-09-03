using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Actividades.Actividad3ConsultorioMatematico
{
    internal class Monitor
    {
        private string id {  get; set; }
        private string nombre { get; set; }
        private string carrera { get; set; }
        private int semestre { get; set; }
        private DateOnly fecha { get; set; }
        private int horas { get; set; }

        public Monitor (string id, string nombre, string carrera, int semestre, DateOnly fecha, int horas)
        {
            this.id = id;
            this.nombre = nombre;
            this.carrera = carrera;
            this.semestre = semestre;
            this.fecha = fecha;
            this.horas = horas;
        }
        //Setters
        public void SetId(string id) {  this.id = id; }
        public void SetNombre(string nombre) {  this.nombre = nombre; }
        public void SetCarrera(string carrera) { this.carrera = carrera; }
        public void SetSemestre(int semestre) {  this.semestre = semestre;}
        public void SetFecha(DateOnly fecha) { this.fecha = fecha;}
        public void SetHoras(int horas) { this.horas = horas;}

        //Getters
        public string GetId() {  return this.id; }
        public string GetNombre() { return this.nombre; }
        public string GetCarrera() { return this.carrera; }
        public int GetSemestre() { return this.semestre; }
        public DateOnly GetFecha() { return this.fecha; }
        public int GetHoras() { return this.horas; }

    }
}
