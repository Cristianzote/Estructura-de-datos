using EstructuraDeDatosForm.Actividades.Actividad1Terremoto;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstructuraDeDatosForm.Ejercicio1Lista;
using EstructuraDeDatosForm.Ejercicios.Ejercicio1Lista;

/*El area metropolitana del valle de Aburrá está realizando una campaña para la recolección de donaciones
 * a las victimas del terremoto 810 y requiere un programa que le permita gestionar estas ayudas
 * 
 * Cada donación debe almacenar codigo, el benefactor, el tipo de ayuda (dinero, alimentación, vestuario, aseo,
 * materia prima, otro), valor y destino.
 * 
 * El sistema debe realizar:
 *  1. Registrar donación -> Se debe registrar la donación de acuerdo a su valor + a -
 *  2. Mostrar todas las ayudas registrados
 *  3. Eliminar una donación según el código.
 *  4. Listar las donacónes de un destino especifico.
 *  5. Calcular el valor total recolectado y/o ciudad
 *  6. Determinar el porcentaje de donaciones por destino.
 *  7. Eliminar las donaciones cuyo tipo sea "otro".
 *  */

namespace EstructuraDeDatosForm.Actividades
{
    public partial class Actividad1TerremotoForm : Form
    {
        public Actividad1TerremotoForm()
        {
            InitializeComponent();
            donationList.AddFirst(new Donation(1, "Cristian", 12000, "Envigado", "Ropa"));
            donationList.AddFirst(new Donation(2, "David", 50000, "Envigado", "Comida"));
            donationList.AddFirst(new Donation(3, "Ramirez", 10000, "Envigado", "Otro"));
            donationList.AddFirst(new Donation(4, "Vargas", 30000, "Envigado", "Ropa"));

        }
        List donationList = new List();

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                //Registrar donación
                case 0:
                    int code = int.Parse(Interaction.InputBox("Dijite Código: "));
                    string donor = Interaction.InputBox("Dijite donador: ");
                    float value = float.Parse(Interaction.InputBox("Dijite valor de la donación: "));
                    string destiny = Interaction.InputBox("Dijite destino de la donación: ");
                    string type = Interaction.InputBox("Dijite tipo de la donación: ");

                    Donation donation = new Donation(code, donor, value, destiny, type);
                    donationList.AddLast(donation);
                    break;

                //Mostrar registros
                case 1:                  
                    MessageBox.Show(donationList.ToString());
                    break;

                //Eliminar por codigo
                case 2:
                    int delCode = int.Parse(Interaction.InputBox("Dijite codigo que desea eliminar: "));
                    Donation? data2;
                    /*foreach (Donation d in donationList)
                    {
                        if (delCode == d.GetCode())
                        {
                            donationList.Remove(d);
                            break;
                        }
                    }*/
                    for (int i = 0; i < donationList.Size(); i++)
                    {
                        data2 = donationList.getPos(i).GetData() as Donation;
                        if (data2.GetCode().Equals(delCode))
                        {
                            donationList.DeletePos(i);
                        }
                    }
                    break;

                //Listar por destino
                case 3:
                    string showDestiny = Interaction.InputBox("Dijite destino: ");
                    string msgDestiny = "";
                    Donation? data3;
                    /*foreach (Donation d in donationList)
                    {
                        if (showDestiny == d.GetDestiny())
                        {
                            msgDestiny += d.ToString();
                        }
                    }*/

                    for (int i = 0; i < donationList.Size(); i++)
                    {
                        data3 = donationList.getPos(i).GetData() as Donation;
                        if (data3.GetDestiny().Equals(showDestiny))
                        {
                            msgDestiny += donationList.getPos(i).GetData().ToString();
                        }
                    }

                    MessageBox.Show(msgDestiny);
                    break;
                //Calcular valor total
                case 4:
                    float totalValue = 0;
                    Donation? data4;
                    /*foreach (Donation d in donationList)
                    {
                        totalValue += d.GetValue();
                    }*/

                    for (int i = 0; i < donationList.Size(); i++)
                    {
                        data4 = donationList.getPos(i).GetData() as Donation;
                        totalValue += data4.GetValue();
                    }
                    MessageBox.Show("Valor total: "+ totalValue);
                    break;

                //Determinar porcentaje de donaciones por destino
                case 5:
                    string percentDestiny = Interaction.InputBox("Dijite destino: ");
                    int amountDestiny = 0;
                    Donation? data5;
                    /*foreach (Donation d in donationList)
                    {
                        if (percentDestiny == d.GetDestiny())
                        {
                            amountDestiny++;
                        }
                    }*/

                    for (int i = 0; i < donationList.Size(); i++)
                    {
                        data5 = donationList.getPos(i).GetData() as Donation;
                        if(data5.GetDestiny() == percentDestiny)
                        {
                            amountDestiny++;
                        }
                    }
                    MessageBox.Show($"Porcentaje de donaciones de {percentDestiny}: {(amountDestiny/ donationList.Size())*100}%");
                    break;

                //Eliminar donaciones cuyo tipo sea otro
                case 6:
                    int delAmount = 0;
                    Donation? data6;
                    /*foreach (Donation d in donationList)
                    {
                        if ("Otro" == d.GetDonationType())
                        {
                            donationList.Remove(d);
                            delAmount++;
                        }
                    }*/
                    for (int i = 0; i < donationList.Size(); i++)
                    {
                        data6 = donationList.getPos(i).GetData() as Donation;
                        if (data6.GetDestiny()=="Otro")
                        {
                            donationList.DeletePos(i);
                        }
                    }
                    MessageBox.Show($"{delAmount} elementos eliminados");
                    break;
            }
        }
    }
}
