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
            btnSubMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 27);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "SUBDIRECTOR";
            // 
            // butMostrar
            // 
            butMostrar.Location = new Point(556, 74);
            butMostrar.Margin = new Padding(3, 4, 3, 4);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(86, 31);
            butMostrar.TabIndex = 10;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = true;
            butMostrar.Click += butMostrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(470, 27);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 137);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 365);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSubMostrar
            // 
            btnSubMostrar.Location = new Point(687, 13);
            btnSubMostrar.Margin = new Padding(3, 4, 3, 4);
            btnSubMostrar.Name = "btnSubMostrar";
            btnSubMostrar.Size = new Size(174, 39);
            btnSubMostrar.TabIndex = 3;
            btnSubMostrar.Text = "Mostrar";
            btnSubMostrar.UseVisualStyleBackColor = true;
            // 
            // frmSubdirector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 631);
            Controls.Add(butMostrar);
            Controls.Add(btnSubMostrar);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSubdirector";
            Text = "Subdirector";
            Load += frmSubdirector_Load;
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
        private Button btnSubMostrar;

    }
}