namespace Examen2_NW
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            verToolStripMenuItem = new ToolStripMenuItem();
            altasToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            darAltaToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            directorToolStripMenuItem = new ToolStripMenuItem();
            subdirectorToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(604, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altasToolStripMenuItem });
            verToolStripMenuItem.Image = (Image)resources.GetObject("verToolStripMenuItem.Image");
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(55, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // altasToolStripMenuItem
            // 
            altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            altasToolStripMenuItem.Size = new Size(67, 22);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darAltaToolStripMenuItem });
            editarToolStripMenuItem.Image = (Image)resources.GetObject("editarToolStripMenuItem.Image");
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(69, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // darAltaToolStripMenuItem
            // 
            darAltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem, directorToolStripMenuItem, subdirectorToolStripMenuItem, clienteToolStripMenuItem });
            darAltaToolStripMenuItem.Image = (Image)resources.GetObject("darAltaToolStripMenuItem.Image");
            darAltaToolStripMenuItem.Name = "darAltaToolStripMenuItem";
            darAltaToolStripMenuItem.Size = new Size(184, 26);
            darAltaToolStripMenuItem.Text = "Roles";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(135, 22);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // directorToolStripMenuItem
            // 
            directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            directorToolStripMenuItem.Size = new Size(135, 22);
            directorToolStripMenuItem.Text = "Director";
            directorToolStripMenuItem.Click += directorToolStripMenuItem_Click;
            // 
            // subdirectorToolStripMenuItem
            // 
            subdirectorToolStripMenuItem.Name = "subdirectorToolStripMenuItem";
            subdirectorToolStripMenuItem.Size = new Size(135, 22);
            subdirectorToolStripMenuItem.Text = "Subdirector";
            subdirectorToolStripMenuItem.Click += subdirectorToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(135, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 98);
            label1.Name = "label1";
            label1.Size = new Size(280, 69);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 89, 103);
            ClientSize = new Size(604, 244);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem altasToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem darAltaToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem directorToolStripMenuItem;
        private ToolStripMenuItem subdirectorToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private Label label1;
    }
}