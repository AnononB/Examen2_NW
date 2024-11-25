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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
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
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 31);
            label1.Name = "label1";
            label1.Size = new Size(228, 39);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // txtUsuario2
            // 
            txtUsuario2.Location = new Point(148, 72);
            txtUsuario2.Margin = new Padding(3, 2, 3, 2);
            txtUsuario2.Name = "txtUsuario2";
            txtUsuario2.Size = new Size(256, 23);
            txtUsuario2.TabIndex = 1;
            // 
            // txtContra2
            // 
            txtContra2.Location = new Point(148, 116);
            txtContra2.Margin = new Padding(3, 2, 3, 2);
            txtContra2.Name = "txtContra2";
            txtContra2.Size = new Size(256, 23);
            txtContra2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 72);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 124);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(190, 154);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(82, 22);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // linkLabCrear
            // 
            linkLabCrear.AutoSize = true;
            linkLabCrear.LinkColor = Color.Red;
            linkLabCrear.Location = new Point(297, 213);
            linkLabCrear.Name = "linkLabCrear";
            linkLabCrear.Size = new Size(74, 15);
            linkLabCrear.TabIndex = 6;
            linkLabCrear.TabStop = true;
            linkLabCrear.Text = "Crear cuenta";
            linkLabCrear.LinkClicked += linkLabCrear_LinkClicked;
            // 
            // btnCancelar3
            // 
            btnCancelar3.Location = new Point(289, 154);
            btnCancelar3.Margin = new Padding(3, 2, 3, 2);
            btnCancelar3.Name = "btnCancelar3";
            btnCancelar3.Size = new Size(82, 22);
            btnCancelar3.TabIndex = 7;
            btnCancelar3.Text = "Cancelar";
            btnCancelar3.UseVisualStyleBackColor = true;
            btnCancelar3.Click += btnCancelar3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 89, 103);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCancelar3);
            panel1.Controls.Add(linkLabCrear);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtContra2);
            panel1.Controls.Add(txtUsuario2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -7);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 346);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 213);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "¿No tienes cuenta?";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 283);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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