namespace _3.Zadaca
{
    partial class FrmJela
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvJela = new System.Windows.Forms.DataGridView();
            this.txtPretraziJela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiJelo = new System.Windows.Forms.Button();
            this.btnOcijeniJelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJela
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJela.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJela.Location = new System.Drawing.Point(12, 32);
            this.dgvJela.Name = "dgvJela";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJela.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJela.Size = new System.Drawing.Size(505, 185);
            this.dgvJela.TabIndex = 0;
            this.dgvJela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJela_CellClick);
            // 
            // txtPretraziJela
            // 
            this.txtPretraziJela.Location = new System.Drawing.Point(128, 6);
            this.txtPretraziJela.Name = "txtPretraziJela";
            this.txtPretraziJela.Size = new System.Drawing.Size(100, 20);
            this.txtPretraziJela.TabIndex = 1;
            this.txtPretraziJela.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretraziJela_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretrazi jela po imenu:";
            // 
            // btnObrisiJelo
            // 
            this.btnObrisiJelo.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiJelo.Enabled = false;
            this.btnObrisiJelo.Location = new System.Drawing.Point(12, 223);
            this.btnObrisiJelo.Name = "btnObrisiJelo";
            this.btnObrisiJelo.Size = new System.Drawing.Size(126, 23);
            this.btnObrisiJelo.TabIndex = 3;
            this.btnObrisiJelo.Text = "Obrisi odabrano jelo";
            this.btnObrisiJelo.UseVisualStyleBackColor = false;
            this.btnObrisiJelo.Click += new System.EventHandler(this.btnObrisiJelo_Click);
            // 
            // btnOcijeniJelo
            // 
            this.btnOcijeniJelo.BackColor = System.Drawing.Color.Transparent;
            this.btnOcijeniJelo.Enabled = false;
            this.btnOcijeniJelo.Location = new System.Drawing.Point(144, 223);
            this.btnOcijeniJelo.Name = "btnOcijeniJelo";
            this.btnOcijeniJelo.Size = new System.Drawing.Size(127, 23);
            this.btnOcijeniJelo.TabIndex = 4;
            this.btnOcijeniJelo.Text = "Ocijeni odabrano jelo";
            this.btnOcijeniJelo.UseVisualStyleBackColor = false;
            this.btnOcijeniJelo.Click += new System.EventHandler(this.btnOcijeniJelo_Click);
            // 
            // FrmJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(533, 256);
            this.Controls.Add(this.btnOcijeniJelo);
            this.Controls.Add(this.btnObrisiJelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraziJela);
            this.Controls.Add(this.dgvJela);
            this.Name = "FrmJela";
            this.Text = "Prikaz jela";
            this.Load += new System.EventHandler(this.FrmJela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJela;
        private System.Windows.Forms.TextBox txtPretraziJela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiJelo;
        private System.Windows.Forms.Button btnOcijeniJelo;
    }
}