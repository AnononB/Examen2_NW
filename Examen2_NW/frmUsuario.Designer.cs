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
            label1 = new Label();
            txtUsuario2 = new TextBox();
            txtContra2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnIngresar = new Button();
            linkLabCrear = new LinkLabel();
            btnCancelar3 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // txtUsuario2
            // 
            txtUsuario2.Location = new Point(185, 96);
            txtUsuario2.Name = "txtUsuario2";
            txtUsuario2.Size = new Size(276, 27);
            txtUsuario2.TabIndex = 1;
            // 
            // txtContra2
            // 
            txtContra2.Location = new Point(185, 156);
            txtContra2.Name = "txtContra2";
            txtContra2.Size = new Size(276, 27);
            txtContra2.TabIndex = 2;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 159);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
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
            // linkLabCrear
            // 
            linkLabCrear.AutoSize = true;
            linkLabCrear.LinkColor = Color.MediumBlue;
            linkLabCrear.Location = new Point(339, 318);
            linkLabCrear.Name = "linkLabCrear";
            linkLabCrear.Size = new Size(92, 20);
            linkLabCrear.TabIndex = 6;
            linkLabCrear.TabStop = true;
            linkLabCrear.Text = "Crear cuenta";
            linkLabCrear.LinkClicked += linkLabCrear_LinkClicked;
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
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCancelar3);
            panel1.Controls.Add(linkLabCrear);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtContra2);
            panel1.Controls.Add(txtUsuario2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 461);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 318);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 8;
            label4.Text = "¿No tienes cuenta?";
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

        private Label label1;
        private TextBox txtUsuario2;
        private TextBox txtContra2;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private LinkLabel linkLabCrear;
        private Button btnCancelar3;
        private Panel panel1;
        private Label label4;
    }
}