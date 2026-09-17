using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio3Pilas
{
    internal class ManagerStack
    {
        Stack s = new Stack();
        Stack aux = new Stack();
        public void Add(object data)
        {
            s.Push(data);
        }
        public override string ToString()
        {
            string text = "";
            while (!s.isEmpty())
            {
                object data = s.Pop();
                text = text + data + "\n";
                aux.Push(data);
            }
            while (!aux.isEmpty())
                s.Push(aux.Pop());

            return text;
        }

        public int Size()
        {
            int size = 0;
            while (!s.isEmpty())
                aux.Push(s.Pop());

            while (!aux.isEmpty())
            {
                size++;
                s.Push(aux.Pop());
            }
            return size;
        }

        public bool Delete(int x)
        {
            bool resp = false;
            while (!s.isEmpty())
            {
                int number = (int)s.Pop();
                if (number != x)
                    aux.Push(number);
                else
                    resp = true;
            }
            while (!aux.isEmpty())
                s.Push(aux.Pop());

            return resp;
        }

        public ManagerStack Range(int x, int y)
        {
            ManagerStack srange = new ManagerStack();
            //llevamos la informacion a la pila auxiliar porque
            //estamos trabajando con las posiciones
            while (!s.isEmpty())
                aux.Push(s.Pop());
            //devolvmos operando
            int cont = 0;
            while (!aux.isEmpty())
            {
                int number = (int)aux.Pop();
                cont++;
                if (cont >= x && cont <= y)
                    srange.Add(number);
                s.Push(number);
            }
            return srange;
        }
    }
}
