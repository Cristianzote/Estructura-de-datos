using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio3Pilas
{
    internal class Stack
    {
        private Node top;  //controla de donde sale o entra a la pila

        public bool isEmpty()
        {
            return top == null;
        }

        public void Push(object data)  //meter en la pila
        {
            if (isEmpty())
                top = new Node(data);
            else
            {
                Node n = new Node(data);
                n.setLink(top);
                top = n;
            }
        }

        public object Pop()
        {
            if (!isEmpty())
            {
                object obj = top.getData();
                top = top.getLink();
                return obj;
            }
            return null;
        }
    }
}
