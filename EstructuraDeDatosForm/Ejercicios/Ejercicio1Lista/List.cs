using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio1Lista
{
    internal class List
    {
        private Node head;

        public List()
        {
            head = null;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public void AddFirst(object data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node n = new Node(data);
                n.SetLink(head);
                head = n;
            }
        }

        public void AddLink(Node node)
        {
            head = node;

        }

        public string ToList()
        {
            string text = "";
            Node aux = head;
            while (aux != null)
            {
                text += aux.ToString() + "\n";
                aux=aux.GetLink();
            }
            return text;
        }

        public override string ToString()
        {
            string text = "";
            Node aux = head;
            while (aux != null)
            {
                text = text+aux.GetData()+"\n";
                aux= aux.GetLink();
            }
            return text;
        }

        //Clase 3
        public Node getPos (int pos)
        {
            Node aux = head;
            int count = 1;

            return aux;
        }

        public void AddPos (object data, int pos)
        {
            if (pos == 1)
            {
                AddFirst(data);
            }
        }

        public bool DeletePos(int pos)
        {
            if (pos == 1)
            {
                //return DeleteFirst();
                return false;
            }
            return true;
        }
    }
}
