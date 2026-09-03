using EstructuraDeDatosForm.Ejercicios.Ejercicio2ListaDoble;
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

namespace EstructuraDeDatosForm.Actividades.Actividad3ConsultorioMatematico
{
    public partial class Actividad3ConsultorioMatematicoForm : Form
    {
        DoubleList monitores = new DoubleList();
        DoubleList aulaTaller = new DoubleList();
        int horasMinimasMes = 200;
        public Actividad3ConsultorioMatematicoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                //Registrar
                case 0:
                    string id = Interaction.InputBox("Dijite id: ");
                    string nombre = Interaction.InputBox("Dijite nombre: ");
                    string carrera = Interaction.InputBox("Dijite carrera: ");
                    int semestre = int.Parse(Interaction.InputBox("Dijite numero del semestre: "));
                    DateOnly fecha = DateOnly.Parse(Interaction.InputBox("Dijite fecha (año-mes-dia): "));
                    int horas = int.Parse(Interaction.InputBox("Dijite numero de horas: "));
                    int type = int.Parse(Interaction.InputBox("Dijite 1 para asesoria, 2 para monitor: "));

                    Monitor monitor = new Monitor(id, nombre, carrera, semestre, fecha, horas);

                    if (type == 1 && !SerchMonitor(monitor, aulaTaller))
                    {
                        aulaTaller.AddLast(monitor);
                        MessageBox.Show("Monitor registrado");
                    }
                    else if (type == 2 && !SerchMonitor(monitor, monitores))
                    {
                        monitores.AddLast(monitor);
                        MessageBox.Show("Monitor registrada");
                    }
                    else
                    {
                        MessageBox.Show("Opción no valida");
                    }

                    break;
                //Calcular
                case 1:
                    string id2 = Interaction.InputBox("Dijite id a buscar: ");
                    int mes = int.Parse(Interaction.InputBox("Dijite mes a buscar: "));
                    MessageBox.Show($"Horas faltantes del ID {id2}: {HorasFaltantes(id2, mes)}");
                    break;
                //Crear lista de IDs
                case 2:
                    DoubleList ids = new DoubleList();
                    for(int i = 0; i < monitores.Size(); i++)
                    {
                        Monitor m = (Monitor)monitores.getPos(i).getData();
                        ids.AddLast(m.GetId());
                    }
                    MessageBox.Show($"{ids.ToString()}");
                    break;
                //Mostrar datos
                case 3:
                    MessageBox.Show($"Monitores: {monitores.ToString()}");
                    MessageBox.Show($"Aula taller: {aulaTaller.ToString()}");
                    break;
                //Eliminar las atenciones
                case 4:
                    break;

            }
        }

        private bool SerchMonitor(Monitor monitor, DoubleList list)
        {
            DoubleList doubleList = new DoubleList();
            for (int i = 0; i < list.Size(); i++)
            {
                Monitor m = (Monitor)list.getPos(i).getData();
                if (m.GetId() == monitor.GetId() && m.GetFecha() == monitor.GetFecha())
                {
                    return true;
                }
            }
            return false;
        }

        private int HorasFaltantes(string id, int mes)
        {
            int cont = 0;
            Monitor monitor;
            for(int i = 0;i < aulaTaller.Size(); i++)
            {
                monitor = (Monitor)aulaTaller.getPos(i).getData();
                if(monitor.GetFecha().Month == mes)
                {
                    cont += monitor.GetHoras();                }
            }

            for (int i = 0; i < monitores.Size(); i++)
            {
                monitor = (Monitor)monitores.getPos(i).getData();
                if (monitor.GetFecha().Month == mes)
                {
                    cont += monitor.GetHoras();
                }
            }

            return cont;
        }
    }
}