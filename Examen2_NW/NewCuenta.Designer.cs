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
            label4 = new Label();
            txtAddContra = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnAddCrear = new Button();
            txtAddUsuario = new TextBox();
            txtAddNombre = new TextBox();
            label1 = new Label();
            btnNWcancelar = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 207);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 15;
            label4.Text = "Nombre de usuario:";
            // 
            // txtAddContra
            // 
            txtAddContra.Location = new Point(324, 253);
            txtAddContra.Name = "txtAddContra";
            txtAddContra.PasswordChar = '*';
            txtAddContra.Size = new Size(189, 27);
            txtAddContra.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 260);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 13;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 159);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // btnAddCrear
            // 
            btnAddCrear.Location = new Point(277, 304);
            btnAddCrear.Name = "btnAddCrear";
            btnAddCrear.Size = new Size(94, 29);
            btnAddCrear.TabIndex = 11;
            btnAddCrear.Text = "Crear";
            btnAddCrear.UseVisualStyleBackColor = true;
            btnAddCrear.Click += btnAddCrear_Click;
            // 
            // txtAddUsuario
            // 
            txtAddUsuario.Location = new Point(324, 200);
            txtAddUsuario.Name = "txtAddUsuario";
            txtAddUsuario.Size = new Size(189, 27);
            txtAddUsuario.TabIndex = 10;
            // 
            // txtAddNombre
            // 
            txtAddNombre.Location = new Point(324, 152);
            txtAddNombre.Name = "txtAddNombre";
            txtAddNombre.Size = new Size(189, 27);
            txtAddNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 67);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 8;
            label1.Text = "Nueva cuenta";
            // 
            // btnNWcancelar
            // 
            btnNWcancelar.Location = new Point(431, 304);
            btnNWcancelar.Name = "btnNWcancelar";
            btnNWcancelar.Size = new Size(94, 29);
            btnNWcancelar.TabIndex = 16;
            btnNWcancelar.Text = "Cancelar";
            btnNWcancelar.UseVisualStyleBackColor = true;
            btnNWcancelar.Click += btnNWcancelar_Click;
            // 
            // frmNewCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNWcancelar);
            Controls.Add(label4);
            Controls.Add(txtAddContra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddCrear);
            Controls.Add(txtAddUsuario);
            Controls.Add(txtAddNombre);
            Controls.Add(label1);
            Name = "frmNewCuenta";
            Text = "NewCuenta";
            Load += frmNewCuenta_Load;
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
    }
}