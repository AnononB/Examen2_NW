namespace Examen2_NW
{
    partial class frmNewCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCuenta));
            label4 = new Label();
            txtAddContra = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnAddCrear = new Button();
            txtAddUsuario = new TextBox();
            txtAddNombre = new TextBox();
            label1 = new Label();
            btnNWcancelar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 210);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 15;
            label4.Text = "Nombre de usuario:";
            // 
            // txtAddContra
            // 
            txtAddContra.Location = new Point(261, 256);
            txtAddContra.Name = "txtAddContra";
            txtAddContra.PasswordChar = '*';
            txtAddContra.Size = new Size(189, 27);
            txtAddContra.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 263);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 13;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 162);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // btnAddCrear
            // 
            btnAddCrear.Location = new Point(214, 307);
            btnAddCrear.Name = "btnAddCrear";
            btnAddCrear.Size = new Size(94, 29);
            btnAddCrear.TabIndex = 11;
            btnAddCrear.Text = "Crear";
            btnAddCrear.UseVisualStyleBackColor = true;
            btnAddCrear.Click += btnAddCrear_Click;
            // 
            // txtAddUsuario
            // 
            txtAddUsuario.Location = new Point(261, 203);
            txtAddUsuario.Name = "txtAddUsuario";
            txtAddUsuario.Size = new Size(189, 27);
            txtAddUsuario.TabIndex = 10;
            // 
            // txtAddNombre
            // 
            txtAddNombre.Location = new Point(261, 155);
            txtAddNombre.Name = "txtAddNombre";
            txtAddNombre.Size = new Size(189, 27);
            txtAddNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, -3);
            label1.Name = "label1";
            label1.Size = new Size(261, 50);
            label1.TabIndex = 8;
            label1.Text = "Nueva cuenta";
            // 
            // btnNWcancelar
            // 
            btnNWcancelar.Location = new Point(368, 307);
            btnNWcancelar.Name = "btnNWcancelar";
            btnNWcancelar.Size = new Size(94, 29);
            btnNWcancelar.TabIndex = 16;
            btnNWcancelar.Text = "Cancelar";
            btnNWcancelar.UseVisualStyleBackColor = true;
            btnNWcancelar.Click += btnNWcancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-45, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 47);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(23, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(29, 490);
            panel2.TabIndex = 18;
            // 
            // frmNewCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(583, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnNWcancelar);
            Controls.Add(label4);
            Controls.Add(txtAddContra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddCrear);
            Controls.Add(txtAddUsuario);
            Controls.Add(txtAddNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNewCuenta";
            Text = "NewCuenta";
            Load += frmNewCuenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtAddContra;
        private Label label3;
        private Label label2;
        private Button btnAddCrear;
        private TextBox txtAddUsuario;
        private TextBox txtAddNombre;
        private Label label1;
        private Button btnNWcancelar;
        private Panel panel1;
        private Panel panel2;
    }
}