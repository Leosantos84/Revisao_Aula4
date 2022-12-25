namespace ExercicioRevisao_Aula4
{
    partial class Form1
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
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroInteiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebendoNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebendoTresNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeroInteiroToolStripMenuItem,
            this.recebendoNumerosToolStripMenuItem,
            this.idadeToolStripMenuItem,
            this.recebendoTresNumerosToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // numeroInteiroToolStripMenuItem
            // 
            this.numeroInteiroToolStripMenuItem.Name = "numeroInteiroToolStripMenuItem";
            this.numeroInteiroToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.numeroInteiroToolStripMenuItem.Text = "1) Numero Inteiro";
            this.numeroInteiroToolStripMenuItem.Click += new System.EventHandler(this.numeroInteiroToolStripMenuItem_Click);
            // 
            // recebendoNumerosToolStripMenuItem
            // 
            this.recebendoNumerosToolStripMenuItem.Name = "recebendoNumerosToolStripMenuItem";
            this.recebendoNumerosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recebendoNumerosToolStripMenuItem.Text = "2) Recebendo 4 Numeros";
            this.recebendoNumerosToolStripMenuItem.Click += new System.EventHandler(this.recebendoNumerosToolStripMenuItem_Click);
            // 
            // idadeToolStripMenuItem
            // 
            this.idadeToolStripMenuItem.Name = "idadeToolStripMenuItem";
            this.idadeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.idadeToolStripMenuItem.Text = "3) Recebendo Idade";
            this.idadeToolStripMenuItem.Click += new System.EventHandler(this.idadeToolStripMenuItem_Click);
            // 
            // recebendoTresNumerosToolStripMenuItem
            // 
            this.recebendoTresNumerosToolStripMenuItem.Name = "recebendoTresNumerosToolStripMenuItem";
            this.recebendoTresNumerosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recebendoTresNumerosToolStripMenuItem.Text = "4) Recebendo Tres Numeros";
            this.recebendoTresNumerosToolStripMenuItem.Click += new System.EventHandler(this.recebendoTresNumerosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroInteiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebendoNumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebendoTresNumerosToolStripMenuItem;
    }
}

