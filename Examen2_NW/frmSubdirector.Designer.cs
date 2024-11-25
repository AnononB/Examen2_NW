namespace Examen2_NW
{
    partial class frmSubdirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubdirector));
            label1 = new Label();
            butMostrar = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            btnSubEliminar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(703, 53);
            label1.Name = "label1";
            label1.Size = new Size(189, 35);
            label1.TabIndex = 0;
            label1.Text = "SUBDIRECTOR";
            // 
            // butMostrar
            // 
            butMostrar.BackColor = Color.FromArgb(53, 58, 137);
            butMostrar.ForeColor = SystemColors.ButtonHighlight;
            butMostrar.Location = new Point(528, 64);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(75, 23);
            butMostrar.TabIndex = 10;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = false;
            butMostrar.Click += butMostrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(2, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(520, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(70, 89, 103);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(901, 308);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSubEliminar
            // 
            btnSubEliminar.BackColor = Color.FromArgb(53, 58, 137);
            btnSubEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnSubEliminar.Location = new Point(609, 65);
            btnSubEliminar.Name = "btnSubEliminar";
            btnSubEliminar.Size = new Size(72, 22);
            btnSubEliminar.TabIndex = 3;
            btnSubEliminar.Text = "Eliminar";
            btnSubEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 58, 137);
            panel1.Location = new Point(-13, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 42);
            panel1.TabIndex = 11;
            // 
            // frmSubdirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 89, 103);
            ClientSize = new Size(939, 432);
            Controls.Add(panel1);
            Controls.Add(butMostrar);
            Controls.Add(btnSubEliminar);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSubdirector";
            Text = "Subdirector";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;

        private Button butMostrar;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;

        private DataGridView dataGridView2;
        private ComboBox comboBox2;
        private Button btnSubEliminar;
        private Panel panel1;
    }
}