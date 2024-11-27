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
            butGrafi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 58, 137);
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, -3);
            label1.Name = "label1";
            label1.Size = new Size(128, 39);
            label1.TabIndex = 0;
            label1.Text = "Director";
            // 
            // butMostrar
            // 
            butMostrar.BackColor = Color.FromArgb(53, 58, 137);
            butMostrar.ForeColor = SystemColors.ButtonHighlight;
            butMostrar.Location = new Point(496, 8);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(74, 23);
            butMostrar.TabIndex = 7;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = false;
            butMostrar.Click += butMostrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(486, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(70, 89, 103);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 353);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDicEliminar
            // 
            btnDicEliminar.BackColor = Color.FromArgb(53, 58, 137);
            btnDicEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnDicEliminar.Location = new Point(576, 8);
            btnDicEliminar.Name = "btnDicEliminar";
            btnDicEliminar.Size = new Size(80, 23);
            btnDicEliminar.TabIndex = 8;
            btnDicEliminar.Text = "Eliminar";
            btnDicEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 58, 137);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 32);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 89, 103);
            panel2.Controls.Add(butGrafi);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnDicEliminar);
            panel2.Controls.Add(butMostrar);
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 406);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(53, 58, 137);
            button1.ForeColor = Color.White;
            button1.Location = new Point(661, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // butGrafi
            // 
            butGrafi.BackColor = Color.FromArgb(53, 58, 137);
            butGrafi.ForeColor = Color.White;
            butGrafi.Location = new Point(749, 8);
            butGrafi.Name = "butGrafi";
            butGrafi.Size = new Size(75, 23);
            butGrafi.TabIndex = 10;
            butGrafi.Text = "Grafico";
            butGrafi.UseVisualStyleBackColor = false;
            butGrafi.Click += butGrafi_Click;
            // 
            // frmDirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 435);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDirector";
            Text = "Director";
            Load += frmDirector_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Button butGrafi;
    }
}