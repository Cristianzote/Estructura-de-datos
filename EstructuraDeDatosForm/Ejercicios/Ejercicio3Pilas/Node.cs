using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio3Pilas
{
    internal class Node
    {
        private object data;
        private Node link;

        public Node(object data)
        {
            this.data = data;
        }

        public object getData()
        {
            return data;
        }

        public void setData(object data)
        {
            this.data = data;
        }

        public Node getLink()
        {
            return link;
        }

        public void setLink(Node link)
        {
            this.link = link;
        }
    }
}
