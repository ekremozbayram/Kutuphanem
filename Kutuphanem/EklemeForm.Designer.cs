namespace Kutuphanem
{
    partial class EklemeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KEFormBu = new System.Windows.Forms.Button();
            this.KAFormBu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EkleB = new System.Windows.Forms.Button();
            this.KAdiTb = new System.Windows.Forms.TextBox();
            this.YazarTb = new System.Windows.Forms.TextBox();
            this.BasimYTb = new System.Windows.Forms.TextBox();
            this.BarkodTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YayinCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.KEFormBu);
            this.panel1.Controls.Add(this.KAFormBu);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 75);
            this.panel1.TabIndex = 1;
            // 
            // KEFormBu
            // 
            this.KEFormBu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KEFormBu.Location = new System.Drawing.Point(1320, 0);
            this.KEFormBu.Name = "KEFormBu";
            this.KEFormBu.Size = new System.Drawing.Size(150, 75);
            this.KEFormBu.TabIndex = 7;
            this.KEFormBu.Text = "Kitap Ekleme";
            this.KEFormBu.UseVisualStyleBackColor = true;
            // 
            // KAFormBu
            // 
            this.KAFormBu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KAFormBu.Location = new System.Drawing.Point(1170, 0);
            this.KAFormBu.Name = "KAFormBu";
            this.KAFormBu.Size = new System.Drawing.Size(150, 75);
            this.KAFormBu.TabIndex = 6;
            this.KAFormBu.Text = "Kitap Arama";
            this.KAFormBu.UseVisualStyleBackColor = true;
            this.KAFormBu.Click += new System.EventHandler(this.KAFormBu_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.YayinCb);
            this.panel2.Controls.Add(this.EkleB);
            this.panel2.Controls.Add(this.KAdiTb);
            this.panel2.Controls.Add(this.YazarTb);
            this.panel2.Controls.Add(this.BasimYTb);
            this.panel2.Controls.Add(this.BarkodTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(418, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 343);
            this.panel2.TabIndex = 2;
            // 
            // EkleB
            // 
            this.EkleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleB.Location = new System.Drawing.Point(338, 257);
            this.EkleB.Name = "EkleB";
            this.EkleB.Size = new System.Drawing.Size(156, 53);
            this.EkleB.TabIndex = 5;
            this.EkleB.Text = "EKLE";
            this.EkleB.UseVisualStyleBackColor = true;
            this.EkleB.Click += new System.EventHandler(this.EkleB_Click);
            // 
            // KAdiTb
            // 
            this.KAdiTb.Location = new System.Drawing.Point(189, 76);
            this.KAdiTb.Name = "KAdiTb";
            this.KAdiTb.Size = new System.Drawing.Size(300, 22);
            this.KAdiTb.TabIndex = 1;
            // 
            // YazarTb
            // 
            this.YazarTb.Location = new System.Drawing.Point(189, 114);
            this.YazarTb.Name = "YazarTb";
            this.YazarTb.Size = new System.Drawing.Size(300, 22);
            this.YazarTb.TabIndex = 2;
            // 
            // BasimYTb
            // 
            this.BasimYTb.Location = new System.Drawing.Point(189, 150);
            this.BasimYTb.Name = "BasimYTb";
            this.BasimYTb.Size = new System.Drawing.Size(300, 22);
            this.BasimYTb.TabIndex = 3;
            // 
            // BarkodTb
            // 
            this.BarkodTb.Location = new System.Drawing.Point(189, 36);
            this.BarkodTb.Name = "BarkodTb";
            this.BarkodTb.Size = new System.Drawing.Size(300, 22);
            this.BarkodTb.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yayınevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basım Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // YayinCb
            // 
            this.YayinCb.FormattingEnabled = true;
            this.YayinCb.Location = new System.Drawing.Point(189, 188);
            this.YayinCb.Name = "YayinCb";
            this.YayinCb.Size = new System.Drawing.Size(300, 24);
            this.YayinCb.TabIndex = 4;
            // 
            // EklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1482, 883);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EklemeForm";
            this.Text = "Kitap Ekleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EklemeForm_FormClosed);
            this.Load += new System.EventHandler(this.EklemeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KAdiTb;
        private System.Windows.Forms.TextBox YazarTb;
        private System.Windows.Forms.TextBox BasimYTb;
        private System.Windows.Forms.TextBox BarkodTb;
        private System.Windows.Forms.Button EkleB;
        private System.Windows.Forms.Button KEFormBu;
        private System.Windows.Forms.Button KAFormBu;
        private System.Windows.Forms.ComboBox YayinCb;
    }
}