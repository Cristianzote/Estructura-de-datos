using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio4Colas
{
    internal class QueueManager
    {
        private Queue q = new Queue();
        private Queue aux = new Queue();

        public void Add(Process order)
        {
            q.Enqueue(order);
        }

        public override string ToString()
        {
            string text = "";
            while (!q.isEmpty())
            {
                Process ord = (Process)q.Dequeue();
                text = text + ord.ToString() + "\n";
                aux.Enqueue(ord);
            }
            while (!aux.isEmpty())
                q.Enqueue(aux.Dequeue());

            return text;
        }

        public bool Assign(int quatum)
        {
            if (!q.isEmpty())
            {
                Process p = (Process)q.Dequeue();
                if (p.getCpu() - quatum > 0)
                {
                    p.setCpu(p.getCpu() - quatum);
                    Add(p);
                    return false;
                }
                return true; //el proceso termino...
            }
            return false;
        }
    }
}
