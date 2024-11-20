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
            label1 = new Label();

            butMostrar = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();

            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            btnSubMostrar = new Button();
            button2 = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Location = new Point(577, 31);

            label1.Location = new Point(558, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "SUBDIRECTOR";
            // 

            // butMostrar
            // 
            butMostrar.Location = new Point(557, 98);
            butMostrar.Name = "butMostrar";
            butMostrar.Size = new Size(75, 23);
            butMostrar.TabIndex = 10;
            butMostrar.Text = "Consultar";
            butMostrar.UseVisualStyleBackColor = true;
            butMostrar.Click += butMostrar_Click;

            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(510, 281);
            dataGridView1.TabIndex = 1;

            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;

            comboBox1.Location = new Point(12, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(504, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(620, 274);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            comboBox1.Location = new Point(558, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // btnSubMostrar
            // 
            btnSubMostrar.Location = new Point(558, 111);
            btnSubMostrar.Name = "btnSubMostrar";
            btnSubMostrar.Size = new Size(152, 29);
            btnSubMostrar.TabIndex = 3;
            btnSubMostrar.Text = "Mostrar";
            btnSubMostrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(559, 161);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;

            // 
            // frmSubdirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(739, 438);
            Controls.Add(butMostrar);

            ClientSize = new Size(926, 473);
            Controls.Add(button2);
            Controls.Add(btnSubMostrar);

            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
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

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button btnSubMostrar;
        private Button button2;

    }
}