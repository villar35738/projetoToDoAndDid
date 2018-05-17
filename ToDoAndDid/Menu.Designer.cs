namespace ToDoAndDid
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tAREFASAFAZERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAREFASFINALIZADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAREFASAFAZERToolStripMenuItem,
            this.tAREFASFINALIZADASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tAREFASAFAZERToolStripMenuItem
            // 
            this.tAREFASAFAZERToolStripMenuItem.Name = "tAREFASAFAZERToolStripMenuItem";
            this.tAREFASAFAZERToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.tAREFASAFAZERToolStripMenuItem.Text = "TAREFAS A FAZER";
            this.tAREFASAFAZERToolStripMenuItem.Click += new System.EventHandler(this.tAREFASAFAZERToolStripMenuItem_Click);
            // 
            // tAREFASFINALIZADASToolStripMenuItem
            // 
            this.tAREFASFINALIZADASToolStripMenuItem.Name = "tAREFASFINALIZADASToolStripMenuItem";
            this.tAREFASFINALIZADASToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.tAREFASFINALIZADASToolStripMenuItem.Text = "TAREFAS FINALIZADAS";
            this.tAREFASFINALIZADASToolStripMenuItem.Click += new System.EventHandler(this.tAREFASFINALIZADASToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 175);
            this.label1.TabIndex = 3;
            this.label1.Text = "A FAZERES E FEITOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tAREFASAFAZERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAREFASFINALIZADASToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}