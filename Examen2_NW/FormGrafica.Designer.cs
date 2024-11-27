namespace Examen2_NW
{
    partial class FormGrafica
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
            Barra = new Panel();
            panel1 = new Panel();
            butMedio = new Button();
            butBajo = new Button();
            butGrafica = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Barra
            // 
            Barra.BackColor = Color.FromArgb(53, 58, 137);
            Barra.Location = new Point(0, 0);
            Barra.Name = "Barra";
            Barra.Size = new Size(857, 35);
            Barra.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 89, 103);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(butMedio);
            panel1.Controls.Add(butBajo);
            panel1.Controls.Add(butGrafica);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-9, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 426);
            panel1.TabIndex = 7;
            // 
            // butMedio
            // 
            butMedio.BackColor = Color.FromArgb(53, 58, 137);
            butMedio.ForeColor = Color.White;
            butMedio.Location = new Point(133, 8);
            butMedio.Name = "butMedio";
            butMedio.Size = new Size(121, 23);
            butMedio.TabIndex = 3;
            butMedio.Text = "Productos Medios";
            butMedio.UseVisualStyleBackColor = false;
            butMedio.Click += butMedio_Click;
            // 
            // butBajo
            // 
            butBajo.BackColor = Color.FromArgb(53, 58, 137);
            butBajo.ForeColor = Color.White;
            butBajo.Location = new Point(260, 8);
            butBajo.Name = "butBajo";
            butBajo.Size = new Size(116, 23);
            butBajo.TabIndex = 2;
            butBajo.Text = "Productos Bajos";
            butBajo.UseVisualStyleBackColor = false;
            butBajo.Click += butBajo_Click;
            // 
            // butGrafica
            // 
            butGrafica.BackColor = Color.FromArgb(53, 58, 137);
            butGrafica.ForeColor = Color.White;
            butGrafica.Location = new Point(21, 8);
            butGrafica.Name = "butGrafica";
            butGrafica.Size = new Size(106, 23);
            butGrafica.TabIndex = 1;
            butGrafica.Text = "Productos Altos";
            butGrafica.UseVisualStyleBackColor = false;
            butGrafica.Click += butGrafica_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(21, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 359);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 4);
            label1.Name = "label1";
            label1.Size = new Size(137, 39);
            label1.TabIndex = 4;
            label1.Text = "GRAFICA";
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 450);
            Controls.Add(panel1);
            Controls.Add(Barra);
            Name = "FormGrafica";
            Text = "FormGrafica";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Barra;
        private Panel panel1;
        private Panel panel2;
        private Button butGrafica;
        private Button butBajo;
        private Button butMedio;
        private Label label1;
    }
}