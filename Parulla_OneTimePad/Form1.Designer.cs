namespace Parulla_OneTimePad
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
            this.btnShfaqParullen = new System.Windows.Forms.Button();
            this.btnKerko = new System.Windows.Forms.Button();
            this.btnShto = new System.Windows.Forms.Button();
            this.rtbparullat = new System.Windows.Forms.RichTextBox();
            this.dgvparullat = new System.Windows.Forms.DataGridView();
            this.txtnr = new System.Windows.Forms.TextBox();
            this.btnFshij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvparullat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShfaqParullen
            // 
            this.btnShfaqParullen.Location = new System.Drawing.Point(198, 174);
            this.btnShfaqParullen.Name = "btnShfaqParullen";
            this.btnShfaqParullen.Size = new System.Drawing.Size(176, 35);
            this.btnShfaqParullen.TabIndex = 22;
            this.btnShfaqParullen.Text = "Shfaq Parullen";
            this.btnShfaqParullen.UseVisualStyleBackColor = true;
            this.btnShfaqParullen.Click += new System.EventHandler(this.btnShfaqParullen_Click);
            // 
            // btnKerko
            // 
            this.btnKerko.Location = new System.Drawing.Point(12, 174);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(180, 35);
            this.btnKerko.TabIndex = 21;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(12, 14);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(180, 42);
            this.btnShto.TabIndex = 18;
            this.btnShto.Text = "Shto Parulle";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // rtbparullat
            // 
            this.rtbparullat.Location = new System.Drawing.Point(12, 88);
            this.rtbparullat.Name = "rtbparullat";
            this.rtbparullat.Size = new System.Drawing.Size(456, 80);
            this.rtbparullat.TabIndex = 17;
            this.rtbparullat.Text = "";
            this.rtbparullat.TextChanged += new System.EventHandler(this.rtbparullat_TextChanged);
            // 
            // dgvparullat
            // 
            this.dgvparullat.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvparullat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvparullat.Location = new System.Drawing.Point(12, 215);
            this.dgvparullat.Name = "dgvparullat";
            this.dgvparullat.Size = new System.Drawing.Size(456, 174);
            this.dgvparullat.TabIndex = 16;
            // 
            // txtnr
            // 
            this.txtnr.Location = new System.Drawing.Point(12, 62);
            this.txtnr.Name = "txtnr";
            this.txtnr.Size = new System.Drawing.Size(285, 20);
            this.txtnr.TabIndex = 25;
            // 
            // btnFshij
            // 
            this.btnFshij.Location = new System.Drawing.Point(198, 14);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(162, 42);
            this.btnFshij.TabIndex = 27;
            this.btnFshij.Text = "Fshij";
            this.btnFshij.UseVisualStyleBackColor = true;
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 401);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.txtnr);
            this.Controls.Add(this.btnShfaqParullen);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.rtbparullat);
            this.Controls.Add(this.dgvparullat);
            this.Name = "Form1";
            this.Text = "Simulimi i Parullave";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvparullat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShfaqParullen;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.RichTextBox rtbparullat;
        private System.Windows.Forms.DataGridView dgvparullat;
        private System.Windows.Forms.TextBox txtnr;
        private System.Windows.Forms.Button btnFshij;
    }
}

