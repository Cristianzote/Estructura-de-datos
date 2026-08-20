using EstructuraDeDatosForm.Actividades.Actividad1Terremoto;
using EstructuraDeDatosForm.Ejercicios.Ejercicio1Lista;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Seguimiento de Listas simples y listas dobles.
La Institución Universitaria requiere un programa que le permita gestionar las diferentes asignaturas que se imparten en 
la institución. De cada asignatura se debe almacenar el codigo, nombre, facultad, número de créditos, tipo (teórica, practica 
o teórica practica) y tipo2 (obligatoria, optativa, electiva)

La Institución requiere que el programa permita:
1.  (0, 5 puntos) Almacenar una nueva asignatura.
2.	(0,5 puntos) Mostrar la información de todas.
3.	(1,5 puntos) Crear una sublista con la información de las asignaturas prácticas de una determinada facultad.
4.	(1,5 puntos) eliminar de la lista las asignaturas optativas que tengan más de dos créditos.
5.	(1 punto) Calcular el numero de horas que se requieren para dictar todas las asignaturas teniendo en cuenta que cada credito
equivale a una hora en las asignaturas teóricas, 2 horas en las practicas y 1,5 en las teóricas prácticas.
*/

namespace EstructuraDeDatosForm.Actividades.Actividad2Universidad
{
    public partial class Actividad2UniversidadForm : Form
    {
        public Actividad2UniversidadForm()
        {
            InitializeComponent();
        }
        List asignaturas = new List();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                //1. Almacenar una nueva asignatura.
                case 0:
                    string codigo = Interaction.InputBox("Dijite código: ");
                    string nombre = Interaction.InputBox("Dijite nombre: ");
                    string facultad = Interaction.InputBox("Dijite facultad: ");
                    int creditos = int.Parse(Interaction.InputBox("Dijite numero de creditos: "));
                    string tipo1 = Interaction.InputBox("Dijite tipo 1 (teórica, practica o teórica practica): ");
                    string tipo2 = Interaction.InputBox("Dijite tipo 2: (obligatoria, optativa, electiva)");

                    Asignatura asignatura = new Asignatura(codigo, nombre, facultad, creditos, tipo1, tipo2);
                    asignaturas.AddLast(asignatura);
                    MessageBox.Show("Asignatura registrada");

                    break;
                //2. Mostrar la información de todas.
                case 1:
                    MessageBox.Show(asignaturas.ToString());
                    break;
                //3. Crear una sublista con la información de las asignaturas prácticas de una determinada facultad.
                case 2:
                    List sublista = new List();
                    Asignatura? data2;
                    string fac2 = Interaction.InputBox("Dijite facultad: ");
                    for (int i=0; i< asignaturas.Size(); i++)
                    {
                        data2 = asignaturas.getPos(i).GetData() as Asignatura;
                        if (data2.getTipo().ToLower() == "practica" && data2.getFacultad().ToLower() == fac2)
                        {
                            sublista.AddLast(data2);
                        }
                    }
                    MessageBox.Show(sublista.ToString());
                    break;
                //4. eliminar de la lista las asignaturas optativas que tengan más de dos créditos.
                case 3:
                    break;
                //5. Calcular el numero de horas que se requieren para dictar todas las asignaturas
                case 4:
                    break;
            }
        }
    }
}
