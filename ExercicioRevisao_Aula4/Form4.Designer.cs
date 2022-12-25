namespace ExercicioRevisao_Aula4
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lresultado = new System.Windows.Forms.Label();
            this.Lresultado1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua Idade:";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(135, 12);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(116, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular Idade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lresultado
            // 
            this.Lresultado.AutoSize = true;
            this.Lresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lresultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Lresultado.Location = new System.Drawing.Point(12, 144);
            this.Lresultado.Name = "Lresultado";
            this.Lresultado.Size = new System.Drawing.Size(84, 15);
            this.Lresultado.TabIndex = 3;
            this.Lresultado.Text = "Resultado...";
            // 
            // Lresultado1
            // 
            this.Lresultado1.AutoSize = true;
            this.Lresultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lresultado1.Location = new System.Drawing.Point(12, 144);
            this.Lresultado1.Name = "Lresultado1";
            this.Lresultado1.Size = new System.Drawing.Size(0, 15);
            this.Lresultado1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(116, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lresultado1);
            this.Controls.Add(this.Lresultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Recebendo Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lresultado;
        private System.Windows.Forms.Label Lresultado1;
        private System.Windows.Forms.Button button2;
    }
}