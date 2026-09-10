using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio4Colas
{
    internal class Queue
    {
        public Node first { get; set; }
        public Node last { get; set; }

        public bool IsEmpty()
        {
            return first==null && last==null;
        }

        public void Enqueue(object data)
        {
            if (IsEmpty())
            {
                first=new Node(data);
            }
            else
            {
                {
                    Node n = new Node(data);
                    last.setLink(n);
                    last = n;
                }
            }
        }

        public object Dequeue()
        {
            object data = null;
            if (IsEmpty())
            {
                data = first.getData();
                first = first.getLink();
                if (first == null)
                {
                    last = null;
                }
            }
            return data;
        }
    }
}
