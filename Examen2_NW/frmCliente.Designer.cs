namespace Examen2_NW
{
    partial class frmCliente
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
            butMostrar = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(635, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "CLIENTE";
            // 
            // butMostrar
            // 
            butMostrar.Location = new Point(557, 85);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(75, 23);
            butMostrar.TabIndex = 13;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = true;
            butMostrar.Click += butMostrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(504, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(620, 274);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 430);
            Controls.Add(butMostrar);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butMostrar;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}