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
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(886, 7);
            label1.Name = "label1";
            label1.Size = new Size(132, 49);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(70, 89, 103);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 63);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1001, 407);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.FromArgb(0, 111, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 11);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(539, 28);
            comboBox1.TabIndex = 2;
            // 
            // butMostrar
            // 
            butMostrar.BackColor = Color.FromArgb(53, 58, 137);
            butMostrar.ForeColor = Color.Snow;
            butMostrar.Location = new Point(550, 11);
            butMostrar.Margin = new Padding(3, 4, 3, 4);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(86, 31);
            butMostrar.TabIndex = 3;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = false;
            butMostrar.Click += butMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(53, 58, 137);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(642, 11);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar\r\n";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += butAgregar_Click;
            // 
            // Barra
            // 
            Barra.BackColor = Color.FromArgb(53, 58, 137);
            Barra.Location = new Point(-9, -3);
            Barra.Margin = new Padding(3, 4, 3, 4);
            Barra.Name = "Barra";
            Barra.Size = new Size(1080, 47);
            Barra.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 89, 103);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(butMostrar);
            panel1.Location = new Point(-3, 41);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 513);
            panel1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(734, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1054, 545);
            Controls.Add(panel1);
            Controls.Add(Barra);
            ForeColor = Color.FromArgb(0, 26, 30);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}