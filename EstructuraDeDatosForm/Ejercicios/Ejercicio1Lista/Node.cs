using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio1Lista
{
    internal class Node
    {
        private object data { get; set; }
        private Node link { get; set; }

        public object GetData() {  return data; }
        public Node GetLink() { return link; }
        public void SetLink (Node link) {  this.link = link; }
        public void SetData (object data) { this.data = data; }
        public Node(object data)
        { 
            this.data = data; 
        }
    }
}
