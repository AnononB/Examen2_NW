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
            menuStrip1 = new MenuStrip();
            verToolStripMenuItem = new ToolStripMenuItem();
            altasToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            darAltaToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            directorToolStripMenuItem = new ToolStripMenuItem();
            subdirectorToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(690, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altasToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(44, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // altasToolStripMenuItem
            // 
            altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            altasToolStripMenuItem.Size = new Size(83, 26);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darAltaToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // darAltaToolStripMenuItem
            // 
            darAltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem, directorToolStripMenuItem, subdirectorToolStripMenuItem, clienteToolStripMenuItem });
            darAltaToolStripMenuItem.Name = "darAltaToolStripMenuItem";
            darAltaToolStripMenuItem.Size = new Size(224, 26);
            darAltaToolStripMenuItem.Text = "Roles";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(224, 26);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // directorToolStripMenuItem
            // 
            directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            directorToolStripMenuItem.Size = new Size(224, 26);
            directorToolStripMenuItem.Text = "Director";
            directorToolStripMenuItem.Click += directorToolStripMenuItem_Click;
            // 
            // subdirectorToolStripMenuItem
            // 
            subdirectorToolStripMenuItem.Name = "subdirectorToolStripMenuItem";
            subdirectorToolStripMenuItem.Size = new Size(224, 26);
            subdirectorToolStripMenuItem.Text = "Subdirector";
            subdirectorToolStripMenuItem.Click += subdirectorToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 325);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
    }
}