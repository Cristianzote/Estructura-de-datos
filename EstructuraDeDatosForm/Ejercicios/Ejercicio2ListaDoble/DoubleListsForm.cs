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

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio2ListaDoble
{
    public partial class DoubleListsForm : Form
    {
        DoubleList doubleList = new DoubleList();
        public DoubleListsForm()
        {
            InitializeComponent();
        }
        /*
        AddFirst
        AddLast
        AddPos
        GetPos
        Size
        DeleteFirst
        DeleteLast
        DeletePos
        */
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                //AddFirst
                case 0:
                    string songName = Interaction.InputBox("Dijite nombre de la canción: ");

                    doubleList.AddFirst(songName);
                    MessageBox.Show("Canción registrada");
                    break;
                //AddLast
                case 2:
                    string songName2 = Interaction.InputBox("Dijite nombre de la canción: ");

                    doubleList.AddLast(songName2);
                    MessageBox.Show("Canción registrada");
                    break;
                //AddPos
                case 3:
                    string songName3 = Interaction.InputBox("Dijite nombre de la canción: ");
                    int songPos3 = int.Parse(Interaction.InputBox("Dijite posición a poner la canción: "));

                    doubleList.AddPos(songName3, songPos3);
                    MessageBox.Show("Canción registrada");
                    break;
                //GetPos
                case 4:
                    int songPos4 = int.Parse(Interaction.InputBox("Dijite nombre de la canción: "));
                    MessageBox.Show(doubleList.getPos(songPos4).ToString());
                    break;
                //Size
                case 5:
                    MessageBox.Show(doubleList.Size().ToString());
                    break;
                //Delete first
                case 6:
                    if (doubleList.DeleteFirst())
                    {
                        MessageBox.Show("Canción eliminada");
                    }
                    else
                    {
                        MessageBox.Show("Canción no eliminada");
                    }
                        ;
                    break;
                //DeleteLast
                case 7:
                    if (doubleList.DeleteLast())
                    {
                        MessageBox.Show("Canción eliminada");
                    }
                    else
                    {
                        MessageBox.Show("Canción no eliminada");
                    }
                    break;
                //DeletePos
                case 8:
                    int songPos8 = int.Parse(Interaction.InputBox("Dijite posición de la canción: "));
                    doubleList.DeletePos(songPos8);
                    MessageBox.Show("Canción eliminada");
                    break;
            }
        }
    }
}
