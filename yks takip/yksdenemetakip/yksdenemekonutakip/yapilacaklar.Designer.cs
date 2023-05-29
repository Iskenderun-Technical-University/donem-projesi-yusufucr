namespace yksdenemekonutakip
{
    partial class yapilacaklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yapilacaklar));
            this.buttonyapilacakeekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonyapilacaksil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonyapilacakeekle
            // 
            this.buttonyapilacakeekle.BackColor = System.Drawing.Color.White;
            this.buttonyapilacakeekle.FlatAppearance.BorderSize = 0;
            this.buttonyapilacakeekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonyapilacakeekle.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonyapilacakeekle.ForeColor = System.Drawing.Color.Black;
            this.buttonyapilacakeekle.Location = new System.Drawing.Point(602, 128);
            this.buttonyapilacakeekle.Name = "buttonyapilacakeekle";
            this.buttonyapilacakeekle.Size = new System.Drawing.Size(189, 61);
            this.buttonyapilacakeekle.TabIndex = 2;
            this.buttonyapilacakeekle.Text = "EKLE";
            this.buttonyapilacakeekle.UseVisualStyleBackColor = false;
            this.buttonyapilacakeekle.Click += new System.EventHandler(this.buttonyapilacakeekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 357);
            this.dataGridView1.TabIndex = 14;
            // 
            // buttonyapilacaksil
            // 
            this.buttonyapilacaksil.BackColor = System.Drawing.Color.White;
            this.buttonyapilacaksil.FlatAppearance.BorderSize = 0;
            this.buttonyapilacaksil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonyapilacaksil.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonyapilacaksil.ForeColor = System.Drawing.Color.Black;
            this.buttonyapilacaksil.Location = new System.Drawing.Point(602, 230);
            this.buttonyapilacaksil.Name = "buttonyapilacaksil";
            this.buttonyapilacaksil.Size = new System.Drawing.Size(189, 61);
            this.buttonyapilacaksil.TabIndex = 15;
            this.buttonyapilacaksil.Text = "SİL";
            this.buttonyapilacaksil.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 36);
            this.label7.TabIndex = 44;
            this.label7.Text = "®İSTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "label1";
            // 
            // yapilacaklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(57)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(803, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonyapilacaksil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonyapilacakeekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "yapilacaklar";
            this.Text = "Yapılacaklar Listesi";
            this.Load += new System.EventHandler(this.kacgunkaldi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonyapilacakeekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonyapilacaksil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}