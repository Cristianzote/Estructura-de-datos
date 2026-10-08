using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio5ArbolBinario
{
    internal class BinaryTree
    {
        private BinaryNode root;

        public BinaryTree()
        {
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public void Add(object data)
        {
            if (isEmpty())
                root = new BinaryNode(data);
            else
                Add(data, root);  //Llamo al metodo recursivo, iniciando desde la raiz
        }

        private void Add(object data, BinaryNode aux) //Recursivo -> recursivo, base
        {
            string[] mside = { "Left", "Right" };
            string side;
            if (aux != null)
            {
                side = Seleccionar(mside);
                if (side=="Left")
                {
                    if (aux.getLeft() == null)
                        aux.setLeft(new BinaryNode(data));
                    else
                        Add(data, aux.getLeft());
                }
                else
                {
                    if (aux.getRight() == null)
                        aux.setRight(new BinaryNode(data));
                    else
                        Add(data, aux.getRight());
                }
            }
        }

        public string PreOrden()
        {
            return PreOrden(root);
        }

        private string PreOrden(BinaryNode aux)
        {
            if (aux != null)
                return aux.getData() + " " + PreOrden(aux.getLeft()) +
                        PreOrden(aux.getRight());

            return "";
        }
        public string InOrder()
        {
            return InOrder(root);
        }

        public string InOrder(BinaryNode aux)
        {
            if (aux != null)
            {
                return $"{InOrder(aux.getLeft())}{aux.getData()} {InOrder(aux.getRight())} ";
            }
            else
            {
                return "";
            }
        }
        public int Size()
        {
            return Size(root);
        }

        public int Size(BinaryNode aux)
        {
            if (aux != null)
            {
                return 1 + Size(aux.getLeft()) + Size(aux.getRight());
            }
            return 0;
        }

        public int Heigh()
        {
            return Heigh(root);
        }

        public int Heigh(BinaryNode aux)
        {
            if(aux != null)
            {
                return 1 + Math.Max(Heigh(aux.getLeft()), Heigh(aux.getRight()));
            }
            return 0;
        }

        public bool Search(int x)
        {
            return Search(x, root);
        }

        public bool Search(int x, BinaryNode aux)
        {
            if (aux != null)
            {
                if ((int)aux.getData() == x)
                {
                    return true;    
                }
                else
                {
                    return Search(x, aux.getLeft()) || Search(x, aux.getRight());
                }
            }
            return false;
        }

        public BinaryNode SearchNode(int x)
        {
            return SearchNode(x, root);
        }

        public BinaryNode SearchNode(int x, BinaryNode aux)
        {
            BinaryNode res = null;
            if (aux != null)
            {
                if ((int)aux.getData() == x)
                {
                    return aux;
                }
                else
                {
                    res=SearchNode(x, aux.getLeft());
                    if (res == null)
                    {
                        res = SearchNode(x, aux.getRight());
                    }
                    return res;
                }
            }
            return res;
        }

        public BinaryNode getFather(int x)
        {
            return getFather(x, root);
        }

        public BinaryNode getFather(int x, BinaryNode aux)
        {
            if (aux != null)
            {
                if(aux.getLeft() != null && ((int)(aux.getData()) == x) || 
                    (aux.getRight() != null && ((int)aux.getData()) == x))
                {
                    return aux;
                }
                BinaryNode father = getFather(x, aux.getLeft());
                if(father != null)
                {
                    father = getFather(x, father.getRight());
                }
                return father;
            }
            return null;
        }

        public string Seleccionar(string[] options)
        {
            using var f = new Form { Width = 300, Height = 130, Text = "Seleccionar" };
            var combo = new ComboBox { Left = 20, Top = 15, Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            combo.Items.AddRange(options);

            var ok = new Button { Text = "Aceptar", Left = 105, Top = 50, DialogResult = DialogResult.OK };
            f.Controls.AddRange(new Control[] { combo, ok });
            f.AcceptButton = ok;

            return f.ShowDialog() == DialogResult.OK ? combo.Text : null;
        }
    }
}
