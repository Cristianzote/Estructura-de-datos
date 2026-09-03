using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio2ListaDoble
{
    internal class DoubleList
    {
        private DoubleNode head;
        private DoubleNode last;

        public DoubleList()
        {
            //head=null; last=null
        }

        public bool isEmpty()
        {
            return head == null && last == null;
        }

        public void AddFirst(object data)
        {
            if (isEmpty())
            {
                head = new DoubleNode(data);
                last = head;
            }
            else
            {
                DoubleNode n = new DoubleNode(data);
                n.setNext(head);
                head.setPrevious(n);
                head = n;
            }
        }

        public void AddLast(object data)
        {
            if (isEmpty())
                AddFirst(data);
            else
            {
                DoubleNode n = new DoubleNode(data);
                n.setPrevious(last);
                last.setNext(n);
                last = n;
            }
        }
        public DoubleNode getPos(int pos)
        {
            DoubleNode aux = head;
            int count = 1;
            while (aux != null && count < pos)
            {
                aux = aux.getNext();
                count++;
            }
            return aux;
        }

        public void AddPos(object data, int pos)
        {
            if (pos == 1)
                AddFirst(data);
            else
            {
                if (pos == Size() + 1)
                    AddLast(data);
                else
                {
                    DoubleNode aux = getPos(pos);
                    DoubleNode n = new DoubleNode(data);
                    n.setNext(aux);
                    n.setPrevious(aux.getPrevious());
                    aux.getPrevious().setNext(n);
                    aux.setPrevious(n);
                }
            }
        }
        public int Size()
        {
            DoubleNode aux = last;
            int count = 0;
            while (aux != null)
            {
                count++;
                aux = aux.getPrevious();
            }
            return count;
        }
        public override string ToString()
        {
            string text = "";
            DoubleNode aux = head;
            while (aux != null)
            {
                text = text + aux.getData() + "\n";
                aux = aux.getNext();
            }
            return text;
        }

        public bool DeleteFirst()
        {
            if (!isEmpty())
            {
                head = head.getNext();
                if (head != null)
                    head.setPrevious(null);
                else
                    last = null;
                return true;
            }
            return false;
        }

        public bool DeleteLast()
        {
            if (!isEmpty())
            {
                last = last.getPrevious();
                if (last != null)
                    last.setNext(null);
                else
                    head = null;
                return true;
            }
            return false;
        }

        public void DeletePos(int pos)
        {

            if (true)
            {

            }
            else
            {

            }
        }
    }
}
