using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio4Colas
{
    internal class Queue
    {
        private Node first;
        private Node last;

        public Queue()
        {
        }

        public bool isEmpty()
        {
            return first == null && last == null;
        }

        public void Enqueue(object data)
        {
            if (isEmpty())
            {
                first = new Node(data);
                last = first;
            }
            else
            {
                Node n = new Node(data);
                last.setLink(n);
                last = n;
            }
        }

        public object Dequeue()
        {
            object data = null;
            if (!isEmpty())
            {
                data = first.getData();
                first = first.getLink();
                if (first == null)
                    last = null;
            }
            return data;
        }
    }
}
