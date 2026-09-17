/*

using EstructuraDeDatosForm.Ejercicios.Ejercicio3Pilas;

package com.mycompany.prequiz;

import javax.swing.JOptionPane;

public class Prequiz
{

    public static void main(String[] args)
    {
        ManagerQueue mq = new ManagerQueue();
        ManagerStack ms = new ManagerStack();

        String menu[] ={"Add Stack", "Stack range","toString Stack",
            "Create Process", "toString Queue","Assing CPU","Average",
            "Exit"};
        String option;
        int number, cont = 1, quatum = 15;

        do
        {
            option = (String)JOptionPane.showInputDialog(null, "Selected", "Main", 1, null,
                    menu, menu[0]);
            switch (option)
            {
                case "Add Stack"->
                {
                        //llenamos aleatoriamente
                        int lim = (int)(Math.random() * 10);
                        for (int i = 0; i < lim; i++)
                            ms.Add((int)(Math.random() * 50));
                        JOptionPane.showMessageDialog(null, "Numbers created");
                    }
                case "toString Stack"->
                {
                        JOptionPane.showMessageDialog(null, ms.toString());
                    }
                case "Stack range"->
                {
                        int x, y;
                        do
                        {
                            x = Integer.parseInt(JOptionPane.showInputDialog("enter number"));
                        } while (x < 1 || x > ms.Size());

                        do
                        {
                            y = Integer.parseInt(JOptionPane.showInputDialog("enter number"));
                        } while (y < 1 || y > ms.Size() || y < x);
                        JOptionPane.showMessageDialog(null, ms.Range(x, y).toString());
                    }
                case "Create Process"->
                {
                        String name = "Process" + cont;
                        cont++;
                        int cpu = ((int)(Math.random() * 100));
                        int memory = ((int)(Math.random() * 25));
                        Process p = new Process(name, cpu, memory);
                        mq.Add(p);
                        JOptionPane.showMessageDialog(null, "Process created: \n" +
                                p.toString());
                    }
                case "toString Queue"->
                {
                        JOptionPane.showMessageDialog(null, mq.toString());
                    }
                case "Assing CPU"->
                {
                        if (mq.Assign(quatum))
                            JOptionPane.showMessageDialog(null, "The process concluded successfully");
                        else
                            JOptionPane.showMessageDialog(null, "The process still requires CPU time");
                    }
            }


        } while (!option.equals("Exit"));
    }
}

*/