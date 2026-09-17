using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosForm.Ejercicios.Ejercicio4Colas
{
    internal class Process
    {
        private string name;
        private int cpu;
        private int memory;

        public Process(String name, int cpu, int memory)
        {
            this.name = name;
            this.cpu = cpu;
            this.memory = memory;
        }

        public string getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getCpu()
        {
            return cpu;
        }

        public void setCpu(int cpu)
        {
            this.cpu = cpu;
        }

        public int getMemory()
        {
            return memory;
        }

        public void setMemory(int memory)
        {
            this.memory = memory;
        }

        public override String ToString()
        {
            return "Process{" + "name=" + name + ", cpu=" + cpu + ", memory=" + memory + '}';
        }
    }
}
