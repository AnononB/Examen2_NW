namespace Examen2_NW
{
    partial class frmUsuario
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
            panel1 = new Panel();
            btnCancelar3 = new Button();
            linkLabCrear = new LinkLabel();
            btnIngresar = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(btnCancelar3);
            panel1.Controls.Add(linkLabCrear);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 461);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnCancelar3
            // 
            btnCancelar3.Location = new Point(330, 206);
            btnCancelar3.Name = "btnCancelar3";
            btnCancelar3.Size = new Size(94, 29);
            btnCancelar3.TabIndex = 7;
            btnCancelar3.Text = "Cancelar";
            btnCancelar3.UseVisualStyleBackColor = true;
            btnCancelar3.Click += btnCancelar3_Click;
            // 
            // linkLabCrear
            // 
            linkLabCrear.AutoSize = true;
            linkLabCrear.LinkColor = Color.MediumBlue;
            linkLabCrear.Location = new Point(280, 318);
            linkLabCrear.Name = "linkLabCrear";
            linkLabCrear.Size = new Size(92, 20);
            linkLabCrear.TabIndex = 6;
            linkLabCrear.TabStop = true;
            linkLabCrear.Text = "Crear cuenta";
            linkLabCrear.LinkClicked += linkLabCrear_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(217, 206);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 159);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 52);
            label1.Name = "label1";
            label1.Size = new Size(229, 41);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 377);
            Controls.Add(panel1);
            Name = "frmUsuario";
            Text = "Datos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnIngresar;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private LinkLabel linkLabCrear;
        private Button btnCancelar3;
    }
}