using EstructuraDeDatosForm.Actividades.Actividad1Terremoto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public void AddLast(object data)
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

        public void AddDonation(Donation don)
        {
            if (isEmpty())
                head = new Node(don);
            else
            {
                Node aux = head;
                Donation? donation = aux.GetData() as Donation;
                while (aux != null &&
                        donation.GetValue() > don.GetValue())
                    aux = aux.GetLink();
                if (aux != null)
                {
                    Node pre = Previous(aux);
                    if (pre == null)
                        AddFirst(don);
                    else
                    {
                        Node n = new Node(don);
                        pre.SetLink(n);
                        n.SetLink(aux);
                    }
                }
                else
                    AddLast(don);
            }
        }

        public bool Delete(int code)
        {
            //Recorremos la lista buscando el elemento a eliminar
            Node aux = head;
            Donation don = aux.GetData() as Donation;
            while (aux != null && don.GetCode() != code)
                aux = aux.GetLink();

            if (aux != null)
            {
                Node pre = Previous(aux);
                if (pre == null)
                    return DeleteFirst();
                else
                    pre.SetLink(aux.GetLink());
                return true;
            }
            return false;
        }

        public List LDestination(string dest)
        {
            List ldest = new List();
            Node aux = head;
            Donation don = aux.GetData() as Donation;
            while (aux != null)
            {
                if (don.GetDestiny() == dest)
                    ldest.AddLast(aux.GetData()); //dado el ejercicio se puede utilizar cualquier adicionar
                aux = aux.GetLink();
            }
            return ldest;
        }

        public float Total()
        {
            float total = 0;
            Node aux = head;
            Donation? don = aux.GetData() as Donation;
            while (aux != null)
            {
                total += don.GetValue();
                aux = aux.GetLink();
            }
            return total;
        }
    }
}
