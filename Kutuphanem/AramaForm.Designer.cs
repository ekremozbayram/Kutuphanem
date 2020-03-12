namespace Kutuphanem
{
    partial class AramaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KEFormB = new System.Windows.Forms.Button();
            this.KAFormB = new System.Windows.Forms.Button();
            this.AramaTb = new System.Windows.Forms.TextBox();
            this.AramaDG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AramaDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.KEFormB);
            this.panel1.Controls.Add(this.KAFormB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 75);
            this.panel1.TabIndex = 0;
            // 
            // KEFormB
            // 
            this.KEFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KEFormB.Location = new System.Drawing.Point(1320, 0);
            this.KEFormB.Name = "KEFormB";
            this.KEFormB.Size = new System.Drawing.Size(150, 75);
            this.KEFormB.TabIndex = 3;
            this.KEFormB.Text = "Kitap Ekleme";
            this.KEFormB.UseVisualStyleBackColor = true;
            this.KEFormB.Click += new System.EventHandler(this.KEFormB_Click);
            // 
            // KAFormB
            // 
            this.KAFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KAFormB.Location = new System.Drawing.Point(1170, 0);
            this.KAFormB.Name = "KAFormB";
            this.KAFormB.Size = new System.Drawing.Size(150, 75);
            this.KAFormB.TabIndex = 2;
            this.KAFormB.Text = "Kitap Arama";
            this.KAFormB.UseVisualStyleBackColor = true;
            // 
            // AramaTb
            // 
            this.AramaTb.Location = new System.Drawing.Point(109, 147);
            this.AramaTb.Name = "AramaTb";
            this.AramaTb.Size = new System.Drawing.Size(1039, 22);
            this.AramaTb.TabIndex = 0;
            this.AramaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AramaTb_KeyPress);
            // 
            // AramaDG
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AramaDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.AramaDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AramaDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AramaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AramaDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AramaDG.Enabled = false;
            this.AramaDG.Location = new System.Drawing.Point(109, 231);
            this.AramaDG.Name = "AramaDG";
            this.AramaDG.RowTemplate.Height = 24;
            this.AramaDG.Size = new System.Drawing.Size(1290, 600);
            this.AramaDG.TabIndex = 3;
            // 
            // AramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1482, 883);
            this.Controls.Add(this.AramaDG);
            this.Controls.Add(this.AramaTb);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AramaForm";
            this.Text = "Kitap Arama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AramaForm_FormClosed);
            this.Load += new System.EventHandler(this.AramaForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AramaDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KEFormB;
        private System.Windows.Forms.Button KAFormB;
        private System.Windows.Forms.TextBox AramaTb;
        private System.Windows.Forms.DataGridView AramaDG;
    }
}

