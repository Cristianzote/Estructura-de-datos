using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio5ArbolBinario
{
    internal class BinaryNode
    {
        private BinaryNode left;
        private object data;
        private BinaryNode right;

        public BinaryNode(object data)
        {
            this.data = data;
        }

        public BinaryNode getLeft()
        {
            return left;
        }

        public void setLeft(BinaryNode left)
        {
            this.left = left;
        }

        public object getData()
        {
            return data;
        }

        public void setData(object data)
        {
            this.data = data;
        }

        public BinaryNode getRight()
        {
            return right;
        }

        public void setRight(BinaryNode right)
        {
            this.right = right;
        }
    }
}
