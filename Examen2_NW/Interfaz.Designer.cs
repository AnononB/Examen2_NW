namespace Examen2_NW
{
    partial class frmMenuInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicio));
            toolTip1 = new ToolTip(components);
            btnLogin = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(208, 398);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 31);
            label1.Name = "label1";
            label1.Size = new Size(236, 54);
            label1.TabIndex = 4;
            label1.Text = "NorthWind";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(457, 409);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No tengo cuenta";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(737, 38);
            label2.TabIndex = 7;
            label2.Text = "Bienvenido a las listas de las corporaciones \"NorthWind\"\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 432);
            label3.Name = "label3";
            label3.Size = new Size(201, 20);
            label3.TabIndex = 8;
            label3.Text = "¿Tienes cuenta? Ingresa aquí.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 215);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmMenuInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(790, 513);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmMenuInicio";
            Text = "Interfaz";
            Load += frmMenuInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button btnLogin;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
