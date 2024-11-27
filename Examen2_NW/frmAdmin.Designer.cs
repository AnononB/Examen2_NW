namespace Examen2_NW
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            butMostrar = new Button();
            btnEliminar = new Button();
            Barra = new Panel();
            panel1 = new Panel();
            butGrafi = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Barra.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(647, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 35);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(70, 89, 103);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(799, 305);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.FromArgb(0, 111, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(472, 23);
            comboBox1.TabIndex = 2;
            // 
            // butMostrar
            // 
            butMostrar.BackColor = Color.FromArgb(53, 58, 137);
            butMostrar.ForeColor = Color.Snow;
            butMostrar.Location = new Point(481, 8);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(75, 23);
            butMostrar.TabIndex = 3;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = false;
            butMostrar.Click += butMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(53, 58, 137);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(562, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar\r\n";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += butAgregar_Click;
            // 
            // Barra
            // 
            Barra.BackColor = Color.FromArgb(53, 58, 137);
            Barra.Controls.Add(label1);
            Barra.Location = new Point(-8, -2);
            Barra.Name = "Barra";
            Barra.Size = new Size(829, 35);
            Barra.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 89, 103);
            panel1.Controls.Add(butGrafi);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(butMostrar);
            panel1.Location = new Point(-3, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 385);
            panel1.TabIndex = 6;
            // 
            // butGrafi
            // 
            butGrafi.BackColor = Color.FromArgb(53, 58, 137);
            butGrafi.ForeColor = Color.White;
            butGrafi.Location = new Point(727, 9);
            butGrafi.Name = "butGrafi";
            butGrafi.Size = new Size(75, 23);
            butGrafi.TabIndex = 6;
            butGrafi.Text = "Grafico";
            butGrafi.UseVisualStyleBackColor = false;
            butGrafi.Click += butGrafi_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(53, 58, 137);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(642, 9);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(811, 409);
            Controls.Add(panel1);
            Controls.Add(Barra);
            ForeColor = Color.FromArgb(0, 26, 30);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Barra.ResumeLayout(false);
            Barra.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button butMostrar;
        private Button btnEliminar;
        private Panel Barra;
        private Panel panel1;
        private Button btnAgregar;
        private Button butGrafi;
    }
}