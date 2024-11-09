namespace Examen2_NW
{
    partial class frmLogin
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
            txtNombre = new TextBox();
            txtApaterno = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            msbCURP = new MaskedTextBox();
            btnCrear1 = new Button();
            txtAmaterno = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 22);
            label1.Name = "label1";
            label1.Size = new Size(192, 41);
            label1.TabIndex = 0;
            label1.Text = "Crear cuenta";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(260, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApaterno
            // 
            txtApaterno.Location = new Point(261, 137);
            txtApaterno.Name = "txtApaterno";
            txtApaterno.Size = new Size(323, 27);
            txtApaterno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 89);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 144);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 6;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 257);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha naciemiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 312);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "CURP";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "yyyy-MM-dd";
            dtpFecha.Location = new Point(261, 250);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(323, 27);
            dtpFecha.TabIndex = 9;
            // 
            // msbCURP
            // 
            msbCURP.Location = new Point(260, 309);
            msbCURP.Mask = "aaaa000000aaaaaaa0";
            msbCURP.Name = "msbCURP";
            msbCURP.Size = new Size(323, 27);
            msbCURP.TabIndex = 10;
            // 
            // btnCrear1
            // 
            btnCrear1.Location = new Point(378, 362);
            btnCrear1.Name = "btnCrear1";
            btnCrear1.Size = new Size(94, 29);
            btnCrear1.TabIndex = 11;
            btnCrear1.Text = "Crear";
            btnCrear1.UseVisualStyleBackColor = true;
            btnCrear1.Click += btnCrear1_Click;
            // 
            // txtAmaterno
            // 
            txtAmaterno.Location = new Point(260, 198);
            txtAmaterno.Name = "txtAmaterno";
            txtAmaterno.Size = new Size(323, 27);
            txtAmaterno.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 205);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 13;
            label6.Text = "Apellido Materno";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 444);
            Controls.Add(label6);
            Controls.Add(txtAmaterno);
            Controls.Add(btnCrear1);
            Controls.Add(msbCURP);
            Controls.Add(dtpFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApaterno);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApaterno;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFecha;
        private MaskedTextBox msbCURP;
        private Button btnCrear1;
        private TextBox txtAmaterno;
        private Label label6;
    }
}