﻿namespace _3.Zadaca
{
    partial class Frmstudents
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
            this.btnBodovi = new System.Windows.Forms.Button();
            this.btnNarudzba = new System.Windows.Forms.Button();
            this.btnMeni = new System.Windows.Forms.Button();
            this.btnKomentar = new System.Windows.Forms.Button();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBodovi
            // 
            this.btnBodovi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodovi.Location = new System.Drawing.Point(58, 266);
            this.btnBodovi.Name = "btnBodovi";
            this.btnBodovi.Size = new System.Drawing.Size(190, 98);
            this.btnBodovi.TabIndex = 2;
            this.btnBodovi.Text = "Prikupljanje bodova";
            this.btnBodovi.UseVisualStyleBackColor = false;
            this.btnBodovi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNarudzba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarudzba.ForeColor = System.Drawing.Color.Black;
            this.btnNarudzba.Location = new System.Drawing.Point(426, 266);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(188, 98);
            this.btnNarudzba.TabIndex = 3;
            this.btnNarudzba.Text = "Praćenje narudzbi";
            this.btnNarudzba.UseVisualStyleBackColor = false;
            // 
            // btnMeni
            // 
            this.btnMeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeni.Location = new System.Drawing.Point(58, 48);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(190, 96);
            this.btnMeni.TabIndex = 4;
            this.btnMeni.Text = "Meni menze";
            this.btnMeni.UseVisualStyleBackColor = false;
            // 
            // btnKomentar
            // 
            this.btnKomentar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomentar.Location = new System.Drawing.Point(426, 48);
            this.btnKomentar.Name = "btnKomentar";
            this.btnKomentar.Size = new System.Drawing.Size(188, 96);
            this.btnKomentar.TabIndex = 5;
            this.btnKomentar.Text = "Povratni komentari";
            this.btnKomentar.UseVisualStyleBackColor = false;
            this.btnKomentar.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabir.Location = new System.Drawing.Point(130, 195);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(401, 29);
            this.lblOdabir.TabIndex = 6;
            this.lblOdabir.Text = "Odaberite opciju pa vašem ukusu";
            // 
            // Frmstudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(650, 421);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.btnKomentar);
            this.Controls.Add(this.btnMeni);
            this.Controls.Add(this.btnNarudzba);
            this.Controls.Add(this.btnBodovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmstudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.Load += new System.EventHandler(this.Frmstudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBodovi;
        private System.Windows.Forms.Button btnNarudzba;
        private System.Windows.Forms.Button btnMeni;
        private System.Windows.Forms.Button btnKomentar;
        private System.Windows.Forms.Label lblOdabir;
    }
}