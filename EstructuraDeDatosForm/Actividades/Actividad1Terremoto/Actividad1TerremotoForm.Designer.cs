namespace EstructuraDeDatosForm.Actividades
{
    partial class Actividad1TerremotoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una acción";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Registrar donación", "Mostrar donaciones", "Eliminar donación por código", "Listinar donaciones por destino", "Calcular valor recolectado", "Determinar porcentaje de donaciones por destino", "Eliminar donaciones tipo \"otro\"" });
            comboBox1.Location = new Point(39, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 23);
            comboBox1.TabIndex = 1;
            comboBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(66, 115);
            button1.Name = "button1";
            button1.Size = new Size(149, 70);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Actividad1TerremotoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Actividad1TerremotoForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}