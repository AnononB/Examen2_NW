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
            altaToolStripMenuItem = new ToolStripMenuItem();
            bajaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
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
            altasToolStripMenuItem.Size = new Size(224, 26);
            altasToolStripMenuItem.Text = "Altas";
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
            darAltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, bajaToolStripMenuItem });
            darAltaToolStripMenuItem.Name = "darAltaToolStripMenuItem";
            darAltaToolStripMenuItem.Size = new Size(224, 26);
            darAltaToolStripMenuItem.Text = "Empleados";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(224, 26);
            altaToolStripMenuItem.Text = "Alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(224, 26);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
    }
}