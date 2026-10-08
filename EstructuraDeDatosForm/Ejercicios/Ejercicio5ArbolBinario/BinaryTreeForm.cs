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

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio5ArbolBinario
{
    public partial class BinaryTreeForm : Form
    {
        BinaryTree tree = new BinaryTree();
        int[] numeritos = { 10, 20, 30, 200, 100, 500, 250, 83, 41 };
        public BinaryTreeForm()
        {
            for (int i = 0; i < numeritos.Length; i++)
            {
                tree.Add(numeritos[i]);
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    string value = Interaction.InputBox("Digite texto", "Escriba lo que desa añadir", "Melo caramelo");
                    break;
                case 1:
                    MessageBox.Show(tree.PreOrden());
                    break;
                case 2:
                    MessageBox.Show(tree.InOrder());
                    break;
                case 3:
                    MessageBox.Show(tree.PreOrden());
                    break;
                case 4:
                    int size = tree.Size();
                    if (size == 0)
                    {
                        MessageBox.Show("Esta gvonada esta vacia");
                    }
                    else
                    {
                        MessageBox.Show($"Tamaño del arbol: {size}");
                    }
                    break;
                case 5:
                    MessageBox.Show(tree.Heigh().ToString());
                    break;
                case 6:
                    int numbers = int.Parse(Interaction.InputBox("Digite numero: "));
                    if (tree.Search(numbers))
                    {
                        MessageBox.Show("Se encontró el numero");
                    }
                    else
                    {
                        MessageBox.Show("Numero no encontrado :c");
                    }
                    break;
                case 7:
                    int numbers2 = int.Parse(Interaction.InputBox("Digite numero: "));
                    //BinaryNode = 
                    if (tree.Search(numbers2))
                    {
                        MessageBox.Show("Se encontró el numero");
                    }
                    else
                    {
                        MessageBox.Show("Numero no encontrado :c");
                    }
                    break;

            }
        }
        public string Seleccionar(string[] options)
        {
            using var f = new Form { Width = 300, Height = 130, Text = "Seleccionar" };
            var combo = new ComboBox { Left = 20, Top = 15, Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            combo.Items.AddRange(options);

            var ok = new Button { Text = "Aceptar", Left = 105, Top = 50, DialogResult = DialogResult.OK };
            f.Controls.AddRange(new Control[] { combo, ok });
            f.AcceptButton = ok;

            return f.ShowDialog() == DialogResult.OK ? combo.Text : null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
