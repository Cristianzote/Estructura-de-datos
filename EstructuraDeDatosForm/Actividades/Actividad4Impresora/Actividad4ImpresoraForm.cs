using EstructuraDeDatosForm.Actividades.Actividad2Universidad;
using EstructuraDeDatosForm.Ejercicios.Ejercicio4Colas;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraDeDatosForm.Actividades.Actividad4Impresora
{
    /*
    Ejercicio:
    1. Crear orden de impresión
    2. Mostrar las OdI pendientes
    3. Buscar OdI con nombre y usuario
    4. Calcular cantidad de hojas para todas las OdI pendientes
    5. Eliminar impresiones con mas de 50 hojas
    */
    public partial class Actividad4ImpresoraForm : Form
    {
        public Actividad4ImpresoraForm()
        {
            InitializeComponent();
        }

        Queue cola = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                //1. Crear orden de impresión
                case 0:
                    string nombreDoc = Interaction.InputBox("Dijite nombre del documento: ");
                    int cantPaginas = int.Parse(Interaction.InputBox("Dijite cantidad de paginas: "));
                    int catCopias = int.Parse(Interaction.InputBox("Dijite cantidad de copias: "));
                    string usuario = Interaction.InputBox("Dijite nombre de usuario: ");
                    Impresion impresion = new Impresion();
                    
                    cola.Enqueue(impresion);
                    MessageBox.Show("Asignatura registrada");
                    break;
                //2. Mostrar las OdI pendientes
                case 1:
                    break;
                //3. Buscar OdI con nombre y usuario
                case 2:
                    break;
                //4. Calcular cantidad de hojas para todas las OdI pendientes
                case 3:
                    break;
                //5. Eliminar impresiones con mas de 50 hojas
                case 4:
                    break;
            }
        }
    }
}
