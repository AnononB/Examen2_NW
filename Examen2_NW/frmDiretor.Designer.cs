namespace Examen2_NW
{
    partial class frmDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirector));
            label1 = new Label();
            butMostrar = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            btnDicEliminar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(70, 89, 103);
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(868, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 49);
            label1.TabIndex = 0;
            label1.Text = "Director";
            // 
            // butMostrar
            // 
            butMostrar.BackColor = Color.FromArgb(53, 58, 137);
            butMostrar.ForeColor = SystemColors.ButtonHighlight;
            butMostrar.Location = new Point(567, 11);
            butMostrar.Margin = new Padding(3, 4, 3, 4);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(85, 31);
            butMostrar.TabIndex = 7;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = false;
            butMostrar.Click += butMostrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 11);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(555, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(70, 89, 103);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 67);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(997, 427);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDicEliminar
            // 
            btnDicEliminar.BackColor = Color.FromArgb(53, 58, 137);
            btnDicEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnDicEliminar.Location = new Point(658, 11);
            btnDicEliminar.Margin = new Padding(3, 4, 3, 4);
            btnDicEliminar.Name = "btnDicEliminar";
            btnDicEliminar.Size = new Size(91, 31);
            btnDicEliminar.TabIndex = 8;
            btnDicEliminar.Text = "Eliminar";
            btnDicEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 58, 137);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 47);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 89, 103);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnDicEliminar);
            panel2.Controls.Add(butMostrar);
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 524);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(755, 14);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDirector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 549);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDirector";
            Text = "Director";
            Load += frmDirector_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button butMostrar;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btnDicEliminar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
    }
}