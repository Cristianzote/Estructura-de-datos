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
            if (isEmpty())
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

        public Node Last()
        {
            Node last = null;
            Node aux = head;
            while (aux != null)
            {
                last = aux;
                aux = aux.GetLink();
            }
            return last;
        }

        public void AddLast(Object data)
        {
            if (isEmpty())
            {
                head = new Node(data);
            }
            else
            {
                Node last = Last();
                Node n = new Node(data);
                last.SetLink(n);
            }
        }

        public int Size()
        {
            int count = 0;
            Node aux = head;
            while (aux != null)
            {
                count++;
                aux = aux.GetLink();
            }
            return count;
        }

        public Node Previous(Node search)
        {
            Node pre = null;
            Node aux = head;
            while (aux != null && !aux.Equals(search))
            {
                pre = aux;
                aux = aux.GetLink();
            }
            return pre;
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
                aux = aux.GetLink();
            }
            return text;
        }

        public override string ToString()
        {
            string text = "";
            Node aux = head;
            while (aux != null)
            {
                text = text + aux.GetData() + "\n";
                aux = aux.GetLink();
            }
            return text;
        }

        //Clase 3
        public Node getPos(int pos)
        {
            Node aux = head;
            int count = 1;
            while (aux != null && count < pos)
            {
                aux = aux.GetLink();
                count++;
            }
            return aux;
        }

        public void AddPos(object data, int pos)
        {
            if (pos == 1)
            {
                AddFirst(data);
            }
            else
            {
                if (pos == Size() + 1)
                {
                    AddLast(data);
                }
                else
                {
                    Node aux = getPos(pos);
                    Node pre = Previous(aux);
                    Node n = new Node(data);
                    pre.SetLink(n);
                    n.SetLink(aux);
                }
            }
        }

        public bool DeleteFirst()
        {
            if (isEmpty())
            {
                return false;
            }
            else
            {
                head = head.GetLink();
                return true;
            }
        }

        public bool DeleteLast()
        {
            if (isEmpty())
            {
                return false;
            }
            else
            {
                Node last = Last();
                Node pre = Previous(last);
                if (pre == null)
                {
                    head = null;
                }
                else
                {
                    pre.SetLink(null);
                }
                return true;
            }
        }

        public bool DeletePos(int pos)
        {
            if (pos == 1)
            {
                return DeleteLast();
            }
            else
            {
                Node aux = getPos(pos);
                Node pre = Previous(aux);
                pre.SetLink(aux.GetLink());
                return true;
            }
        }
    }
}
