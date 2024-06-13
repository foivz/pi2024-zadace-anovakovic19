namespace _3.Zadaca
{
    partial class FrmMeni
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
            this.btnPrikaziJela = new System.Windows.Forms.Button();
            this.btnUnesiJela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrikaziJela
            // 
            this.btnPrikaziJela.Location = new System.Drawing.Point(65, 25);
            this.btnPrikaziJela.Name = "btnPrikaziJela";
            this.btnPrikaziJela.Size = new System.Drawing.Size(102, 23);
            this.btnPrikaziJela.TabIndex = 0;
            this.btnPrikaziJela.Text = "Prikazi sva jela";
            this.btnPrikaziJela.UseVisualStyleBackColor = true;
            this.btnPrikaziJela.Click += new System.EventHandler(this.btnPrikaziJela_Click);
            // 
            // btnUnesiJela
            // 
            this.btnUnesiJela.Location = new System.Drawing.Point(65, 54);
            this.btnUnesiJela.Name = "btnUnesiJela";
            this.btnUnesiJela.Size = new System.Drawing.Size(102, 23);
            this.btnUnesiJela.TabIndex = 1;
            this.btnUnesiJela.Text = "Unesi jela";
            this.btnUnesiJela.UseVisualStyleBackColor = true;
            this.btnUnesiJela.Click += new System.EventHandler(this.btnUnesiJela_Click);
            // 
            // FrmMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(218, 103);
            this.Controls.Add(this.btnUnesiJela);
            this.Controls.Add(this.btnPrikaziJela);
            this.Name = "FrmMeni";
            this.Text = "Jela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziJela;
        private System.Windows.Forms.Button btnUnesiJela;
    }
}