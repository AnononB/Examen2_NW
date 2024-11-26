namespace Examen2_NW
{
    partial class frmADatos
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
            dataGridViewAgregar = new DataGridView();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgregar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAgregar
            // 
            dataGridViewAgregar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgregar.Location = new Point(68, 82);
            dataGridViewAgregar.Name = "dataGridViewAgregar";
            dataGridViewAgregar.RowHeadersWidth = 51;
            dataGridViewAgregar.Size = new Size(638, 264);
            dataGridViewAgregar.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(324, 34);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmADatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridViewAgregar);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmADatos";
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgregar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAgregar;
        private Button btnGuardar;
    }
}