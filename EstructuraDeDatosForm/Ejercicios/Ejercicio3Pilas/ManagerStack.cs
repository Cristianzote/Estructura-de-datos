using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override String ToString()
        {
            String text = "";
            while (!s.isEmpty())
            {
                Object data = s.Pop();
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
            {
                aux.Push(s.Pop());
            }
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
                {
                    aux.Push(number);
                }
                else
                {
                    resp = true;
                }
            }
            while (!aux.isEmpty())
            {
                s.Push(aux.Pop());
            }
            return resp;
        }
    }
}
