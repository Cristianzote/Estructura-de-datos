using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio1Lista
{
    class Main1
    {
        public void execute()
        {
            List list = new List();
            string[] menu = { "AddFirst", "AddLast", "AddPos", "ToString", "Exit" };
            string option, value;

            /*list.AddFirst(1);
            list.AddFirst("Mondongo");
            list.AddFirst(true);
            list.AddFirst(0.2);
            Console.WriteLine("Lista: "+list);
            Console.WriteLine("Lista toString: " + list.ToString);*/

            do
            {
                Console.WriteLine("-----MENU-----\n\nWrite: AddFirst, AddLast, AddPos, ToString or Exit");
                option = Console.ReadLine();
                switch (option)
                {
                    case "AddFirst":
                        Console.WriteLine("Enter value: ");
                        value =Console.ReadLine();
                        list.AddFirst(value);
                        Console.WriteLine("Succesfuly added\n");
                        break;

                    case "ToString":
                        Console.WriteLine(list);
                        break;

                    default:
                        break;
                }
            }
            while (option != menu[4]);
        }
    }
}
