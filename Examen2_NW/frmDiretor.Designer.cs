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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(646, 35);
            label1.Name = "label1";
            label1.Size = new Size(252, 56);
            label1.TabIndex = 0;
            label1.Text = "Director";
            // 
            // butMostrar
            // 
            butMostrar.Location = new Point(369, 32);
            butMostrar.Margin = new Padding(3, 4, 3, 4);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(122, 31);
            butMostrar.TabIndex = 7;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = true;
            butMostrar.Click += butMostrar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 35);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(333, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(886, 365);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDicEliminar
            // 
            btnDicEliminar.Location = new Point(497, 32);
            btnDicEliminar.Margin = new Padding(3, 4, 3, 4);
            btnDicEliminar.Name = "btnDicEliminar";
            btnDicEliminar.Size = new Size(110, 31);
            btnDicEliminar.TabIndex = 8;
            btnDicEliminar.Text = "Eliminar";
            btnDicEliminar.UseVisualStyleBackColor = true;
            // 
            // frmDirector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 620);
            Controls.Add(btnDicEliminar);
            Controls.Add(butMostrar);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDirector";
            Text = "Director";
           
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butMostrar;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btnDicEliminar;
    }
}