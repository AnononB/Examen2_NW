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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(742, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 41);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 179);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1001, 365);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 59);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(539, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // butMostrar
            // 
            butMostrar.Location = new Point(573, 59);
            butMostrar.Margin = new Padding(3, 4, 3, 4);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(86, 31);
            butMostrar.TabIndex = 3;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = true;
            butMostrar.Click += butMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(573, 97);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Editar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += butAgregar_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 560);
            Controls.Add(btnEliminar);
            Controls.Add(butMostrar);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdmin";
            Text = "Administrador";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button butMostrar;
        private Button btnEliminar;
    }
}