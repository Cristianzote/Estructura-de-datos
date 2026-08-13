using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Actividades.Actividad1Terremoto
{
    internal class Donation
    {
        private int code {  get; set; }
        private string donor { get; set; }
        private float value { get; set; }
        private string destiny { get; set; }
        private string type { get; set; }

        public Donation (int code, string donor, float value, string destiny, string type)
        {
            this.code = code;
            this.donor = donor;
            this.value = value;
            this.destiny = destiny;
            this.type = type;
        }

        public int GetCode()
        {
            return code;
        }

        public string GetDestiny()
        {
            return destiny;
        }

        public float GetValue()
        {
            return value;
        }

        public string GetDonationType()
        {
            return type;
        }

        public override string ToString()
        {
            return $"Código: {code}\nDonador: {donor}\nValor: {value}\nDestino: {destiny}\nTipo: {type}\n\n";
        }
    }
}
