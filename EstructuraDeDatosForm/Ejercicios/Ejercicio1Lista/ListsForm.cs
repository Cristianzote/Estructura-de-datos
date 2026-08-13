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

namespace EstructuraDeDatosForm.Ejercicio1Lista
{
    public partial class ListsForm : Form
    {
        List list = new List();
        string[] menu = { "AddFirst", "AddLast", "AddPos", "ToString", "Exit" };
        string option, value;

        public ListsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "AddFirst":
                    //MessageBoxButtons messageBox = MessageBoxButtons.OK;
                    string value = Interaction.InputBox("Digite texto", "Escriba lo que desa añadir", "Melo caramelo");
                    //MessageBox.Show("Holaaa");
                    list.AddFirst(value);
                    break;

                case "ToString":
                    MessageBox.Show(list.ToString());
                    break;

                case "DeleteLast":
                    break;

                default:
                    break;
            }
        }
    }
}
