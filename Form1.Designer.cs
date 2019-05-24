namespace GR15_Detyra2
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
            this.btnEnkriptimi = new System.Windows.Forms.Button();
            this.btnNDigital = new System.Windows.Forms.Button();
            this.btnVDigital = new System.Windows.Forms.Button();
            this.rtbPlain = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbCipher = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbTextDekriptuar = new System.Windows.Forms.RichTextBox();
            this.btnDekriptimi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbHGjeneruar = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbHngaNenshkrimi = new System.Windows.Forms.RichTextBox();
            this.btnGjeneroCelesat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnkriptimi
            // 
            this.btnEnkriptimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnkriptimi.Location = new System.Drawing.Point(377, 98);
            this.btnEnkriptimi.Name = "btnEnkriptimi";
            this.btnEnkriptimi.Size = new System.Drawing.Size(170, 42);
            this.btnEnkriptimi.TabIndex = 0;
            this.btnEnkriptimi.Text = "Enkriptimi";
            this.btnEnkriptimi.UseVisualStyleBackColor = true;
            this.btnEnkriptimi.Click += new System.EventHandler(this.btnEnkriptimi_Click);
            // 
            // btnNDigital
            // 
            this.btnNDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNDigital.Location = new System.Drawing.Point(199, 364);
            this.btnNDigital.Name = "btnNDigital";
            this.btnNDigital.Size = new System.Drawing.Size(170, 42);
            this.btnNDigital.TabIndex = 1;
            this.btnNDigital.Text = "Nenshkrimi Digjital";
            this.btnNDigital.UseVisualStyleBackColor = true;
            this.btnNDigital.Click += new System.EventHandler(this.btnNDigital_Click);
            // 
            // btnVDigital
            // 
            this.btnVDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDigital.Location = new System.Drawing.Point(581, 364);
            this.btnVDigital.Name = "btnVDigital";
            this.btnVDigital.Size = new System.Drawing.Size(170, 42);
            this.btnVDigital.TabIndex = 2;
            this.btnVDigital.Text = "Verifikimi Nenshkrimit";
            this.btnVDigital.UseVisualStyleBackColor = true;
            this.btnVDigital.Click += new System.EventHandler(this.btnVDigital_Click);
            // 
            // rtbPlain
            // 
            this.rtbPlain.Location = new System.Drawing.Point(12, 43);
            this.rtbPlain.Name = "rtbPlain";
            this.rtbPlain.Size = new System.Drawing.Size(357, 62);
            this.rtbPlain.TabIndex = 3;
            this.rtbPlain.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teksti per enkriptim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teksti Enkriptuar";
            // 
            // rtbCipher
            // 
            this.rtbCipher.Location = new System.Drawing.Point(12, 130);
            this.rtbCipher.Name = "rtbCipher";
            this.rtbCipher.Size = new System.Drawing.Size(357, 62);
            this.rtbCipher.TabIndex = 5;
            this.rtbCipher.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teksti dekriptuar";
            // 
            // rtbTextDekriptuar
            // 
            this.rtbTextDekriptuar.Location = new System.Drawing.Point(12, 222);
            this.rtbTextDekriptuar.Name = "rtbTextDekriptuar";
            this.rtbTextDekriptuar.Size = new System.Drawing.Size(357, 62);
            this.rtbTextDekriptuar.TabIndex = 7;
            this.rtbTextDekriptuar.Text = "";
            // 
            // btnDekriptimi
            // 
            this.btnDekriptimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekriptimi.Location = new System.Drawing.Point(377, 146);
            this.btnDekriptimi.Name = "btnDekriptimi";
            this.btnDekriptimi.Size = new System.Drawing.Size(170, 42);
            this.btnDekriptimi.TabIndex = 9;
            this.btnDekriptimi.Text = "Dekriptimi";
            this.btnDekriptimi.UseVisualStyleBackColor = true;
            this.btnDekriptimi.Click += new System.EventHandler(this.btnDekriptimi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hashi Gjeneruar-Nenshkrimi Digjital";
            // 
            // rtbHGjeneruar
            // 
            this.rtbHGjeneruar.Location = new System.Drawing.Point(12, 412);
            this.rtbHGjeneruar.Name = "rtbHGjeneruar";
            this.rtbHGjeneruar.Size = new System.Drawing.Size(357, 62);
            this.rtbHGjeneruar.TabIndex = 10;
            this.rtbHGjeneruar.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hashi nga nenshkrimi";
            // 
            // rtbHngaNenshkrimi
            // 
            this.rtbHngaNenshkrimi.Location = new System.Drawing.Point(402, 412);
            this.rtbHngaNenshkrimi.Name = "rtbHngaNenshkrimi";
            this.rtbHngaNenshkrimi.Size = new System.Drawing.Size(349, 62);
            this.rtbHngaNenshkrimi.TabIndex = 12;
            this.rtbHngaNenshkrimi.Text = "";
            // 
            // btnGjeneroCelesat
            // 
            this.btnGjeneroCelesat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGjeneroCelesat.Location = new System.Drawing.Point(377, 50);
            this.btnGjeneroCelesat.Name = "btnGjeneroCelesat";
            this.btnGjeneroCelesat.Size = new System.Drawing.Size(170, 42);
            this.btnGjeneroCelesat.TabIndex = 14;
            this.btnGjeneroCelesat.Text = "Gjenero celesat";
            this.btnGjeneroCelesat.UseVisualStyleBackColor = true;
            this.btnGjeneroCelesat.Click += new System.EventHandler(this.btnGjeneroCelesat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Verifikimi i Nenshkrimit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 490);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbHngaNenshkrimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbHGjeneruar);
            this.Controls.Add(this.rtbTextDekriptuar);
            this.Controls.Add(this.rtbCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGjeneroCelesat);
            this.Controls.Add(this.rtbPlain);
            this.Controls.Add(this.btnDekriptimi);
            this.Controls.Add(this.btnVDigital);
            this.Controls.Add(this.btnNDigital);
            this.Controls.Add(this.btnEnkriptimi);
            this.Name = "Form1";
            this.Text = "Nenshkrimi Digjital ne menyre manuale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnkriptimi;
        private System.Windows.Forms.Button btnNDigital;
        private System.Windows.Forms.Button btnVDigital;
        private System.Windows.Forms.RichTextBox rtbPlain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbCipher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbTextDekriptuar;
        private System.Windows.Forms.Button btnDekriptimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbHGjeneruar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbHngaNenshkrimi;
        private System.Windows.Forms.Button btnGjeneroCelesat;
        private System.Windows.Forms.Label label6;
    }
}

