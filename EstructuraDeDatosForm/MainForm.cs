using EstructuraDeDatosForm.Actividades;
using EstructuraDeDatosForm.Actividades.Actividad2Universidad;
using EstructuraDeDatosForm.Ejercicio1Lista;

namespace EstructuraDeDatosForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            List<String> exercises = new List<String>();
            exercises.Add("Listas");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ejercicio1: Listas":
                    new ListsForm().Show();
                    break;

                case "Actividad1: Terremoto":
                    new Actividad1TerremotoForm().Show();
                    break;
                case "Actividad2: Universidad":
                    new Actividad2UniversidadForm().Show();
                    break;
                default: break;
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
