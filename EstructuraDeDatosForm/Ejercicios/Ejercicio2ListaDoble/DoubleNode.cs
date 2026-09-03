using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio2ListaDoble
{
    internal class DoubleNode
    {
        private DoubleNode previous;
        private object data;
        private DoubleNode next;

        public DoubleNode(object data)
        {
            this.data = data;
        }

        public DoubleNode getPrevious()
        {
            return previous;
        }

        public void setPrevious(DoubleNode previous)
        {
            this.previous = previous;
        }

        public object getData()
        {
            return data;
        }

        public void setData(object data)
        {
            this.data = data;
        }

        public DoubleNode getNext()
        {
            return next;
        }

        public void setNext(DoubleNode next)
        {
            this.next = next;
        }
    }
}
