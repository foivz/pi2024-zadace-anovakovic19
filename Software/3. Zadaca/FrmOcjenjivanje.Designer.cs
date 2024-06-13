namespace _3.Zadaca
{
    partial class FrmOcjenjivanje
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
            this.lblNazivJela = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtKomentar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudOcjenaJela = new System.Windows.Forms.NumericUpDown();
            this.nudOcjenaKolicineJela = new System.Windows.Forms.NumericUpDown();
            this.btnOcijeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjenaJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjenaKolicineJela)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivJela
            // 
            this.lblNazivJela.AutoSize = true;
            this.lblNazivJela.Location = new System.Drawing.Point(97, 9);
            this.lblNazivJela.Name = "lblNazivJela";
            this.lblNazivJela.Size = new System.Drawing.Size(53, 13);
            this.lblNazivJela.TabIndex = 1;
            this.lblNazivJela.Text = "Naziv jela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ocjena jela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ocjena količine jela";
            // 
            // rtKomentar
            // 
            this.rtKomentar.Location = new System.Drawing.Point(15, 114);
            this.rtKomentar.Name = "rtKomentar";
            this.rtKomentar.Size = new System.Drawing.Size(203, 47);
            this.rtKomentar.TabIndex = 5;
            this.rtKomentar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodatni komentari/poboljšanja (ako imate)";
            // 
            // nudOcjenaJela
            // 
            this.nudOcjenaJela.Location = new System.Drawing.Point(130, 41);
            this.nudOcjenaJela.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOcjenaJela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOcjenaJela.Name = "nudOcjenaJela";
            this.nudOcjenaJela.Size = new System.Drawing.Size(88, 20);
            this.nudOcjenaJela.TabIndex = 7;
            this.nudOcjenaJela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOcjenaKolicineJela
            // 
            this.nudOcjenaKolicineJela.Location = new System.Drawing.Point(130, 66);
            this.nudOcjenaKolicineJela.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOcjenaKolicineJela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOcjenaKolicineJela.Name = "nudOcjenaKolicineJela";
            this.nudOcjenaKolicineJela.Size = new System.Drawing.Size(88, 20);
            this.nudOcjenaKolicineJela.TabIndex = 8;
            this.nudOcjenaKolicineJela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOcijeni
            // 
            this.btnOcijeni.Location = new System.Drawing.Point(75, 171);
            this.btnOcijeni.Name = "btnOcijeni";
            this.btnOcijeni.Size = new System.Drawing.Size(75, 23);
            this.btnOcijeni.TabIndex = 9;
            this.btnOcijeni.Text = "Ocijeni jelo";
            this.btnOcijeni.UseVisualStyleBackColor = true;
            this.btnOcijeni.Click += new System.EventHandler(this.btnOcijeni_Click);
            // 
            // FrmOcjenjivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(236, 203);
            this.Controls.Add(this.btnOcijeni);
            this.Controls.Add(this.nudOcjenaKolicineJela);
            this.Controls.Add(this.nudOcjenaJela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtKomentar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNazivJela);
            this.Name = "FrmOcjenjivanje";
            this.Text = "Ocjeni jelo";
            this.Load += new System.EventHandler(this.FrmOcjenjivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjenaJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjenaKolicineJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivJela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudOcjenaJela;
        private System.Windows.Forms.NumericUpDown nudOcjenaKolicineJela;
        private System.Windows.Forms.Button btnOcijeni;
    }
}