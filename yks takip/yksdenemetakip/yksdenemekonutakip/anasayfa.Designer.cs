﻿namespace yksdenemekonutakip
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.label4 = new System.Windows.Forms.Label();
            this.buttondenemeekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonistatistik = new System.Windows.Forms.Button();
            this.buttonyapilacaklar = new System.Windows.Forms.Button();
            this.labeltelefon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.denemeleraytBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ykstakipDataSet2 = new yksdenemekonutakip.ykstakipDataSet2();
            this.denemelerTableAdapter1 = new yksdenemekonutakip.ykstakipDataSet1TableAdapters.denemelerTableAdapter();
            this.denemeleraytTableAdapter = new yksdenemekonutakip.ykstakipDataSet2TableAdapters.denemeleraytTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonyenile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.denemelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.denemelerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.denemeleraytBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykstakipDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemelerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 734);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "®İSTE";
            // 
            // buttondenemeekle
            // 
            this.buttondenemeekle.BackColor = System.Drawing.Color.White;
            this.buttondenemeekle.FlatAppearance.BorderSize = 0;
            this.buttondenemeekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondenemeekle.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttondenemeekle.ForeColor = System.Drawing.Color.Black;
            this.buttondenemeekle.Location = new System.Drawing.Point(1035, 90);
            this.buttondenemeekle.Name = "buttondenemeekle";
            this.buttondenemeekle.Size = new System.Drawing.Size(249, 75);
            this.buttondenemeekle.TabIndex = 1;
            this.buttondenemeekle.Text = "TYT DENEME EKLE";
            this.buttondenemeekle.UseVisualStyleBackColor = false;
            this.buttondenemeekle.Click += new System.EventHandler(this.buttondenemeekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.White;
            this.buttonsil.FlatAppearance.BorderSize = 0;
            this.buttonsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsil.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsil.ForeColor = System.Drawing.Color.Black;
            this.buttonsil.Location = new System.Drawing.Point(1035, 344);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(249, 70);
            this.buttonsil.TabIndex = 2;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonistatistik
            // 
            this.buttonistatistik.BackColor = System.Drawing.Color.White;
            this.buttonistatistik.FlatAppearance.BorderSize = 0;
            this.buttonistatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonistatistik.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonistatistik.ForeColor = System.Drawing.Color.Black;
            this.buttonistatistik.Location = new System.Drawing.Point(1035, 469);
            this.buttonistatistik.Name = "buttonistatistik";
            this.buttonistatistik.Size = new System.Drawing.Size(249, 70);
            this.buttonistatistik.TabIndex = 3;
            this.buttonistatistik.Text = "İSTATİSTİKLER";
            this.buttonistatistik.UseVisualStyleBackColor = false;
            this.buttonistatistik.Click += new System.EventHandler(this.buttonistatistik_Click);
            // 
            // buttonyapilacaklar
            // 
            this.buttonyapilacaklar.BackColor = System.Drawing.Color.White;
            this.buttonyapilacaklar.FlatAppearance.BorderSize = 0;
            this.buttonyapilacaklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonyapilacaklar.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonyapilacaklar.ForeColor = System.Drawing.Color.Black;
            this.buttonyapilacaklar.Location = new System.Drawing.Point(1035, 594);
            this.buttonyapilacaklar.Name = "buttonyapilacaklar";
            this.buttonyapilacaklar.Size = new System.Drawing.Size(249, 70);
            this.buttonyapilacaklar.TabIndex = 4;
            this.buttonyapilacaklar.Text = "YAPILACAKLAR LİSTESİ";
            this.buttonyapilacaklar.UseVisualStyleBackColor = false;
            this.buttonyapilacaklar.Click += new System.EventHandler(this.buttonkacgunkaldi_Click);
            // 
            // labeltelefon
            // 
            this.labeltelefon.AutoSize = true;
            this.labeltelefon.Location = new System.Drawing.Point(219, 738);
            this.labeltelefon.Name = "labeltelefon";
            this.labeltelefon.Size = new System.Drawing.Size(44, 16);
            this.labeltelefon.TabIndex = 6;
            this.labeltelefon.Text = "label1";
            this.labeltelefon.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1035, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "AYT DENEME EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // denemeleraytBindingSource
            // 
            this.denemeleraytBindingSource.DataMember = "denemelerayt";
            this.denemeleraytBindingSource.DataSource = this.ykstakipDataSet2;
            // 
            // ykstakipDataSet2
            // 
            this.ykstakipDataSet2.DataSetName = "ykstakipDataSet2";
            this.ykstakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // denemelerTableAdapter1
            // 
            this.denemelerTableAdapter1.ClearBeforeFill = true;
            // 
            // denemeleraytTableAdapter
            // 
            this.denemeleraytTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "TYT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "AYT";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(996, 321);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 396);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(996, 323);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick_1);
            // 
            // buttonyenile
            // 
            this.buttonyenile.BackColor = System.Drawing.Color.Transparent;
            this.buttonyenile.FlatAppearance.BorderSize = 0;
            this.buttonyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonyenile.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonyenile.ForeColor = System.Drawing.Color.Black;
            this.buttonyenile.Location = new System.Drawing.Point(1219, 738);
            this.buttonyenile.Name = "buttonyenile";
            this.buttonyenile.Size = new System.Drawing.Size(89, 38);
            this.buttonyenile.TabIndex = 15;
            this.buttonyenile.Text = "&YENİLE ⭮";
            this.buttonyenile.UseVisualStyleBackColor = false;
            this.buttonyenile.Click += new System.EventHandler(this.buttonyenile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1080, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(57)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1310, 781);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonyenile);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeltelefon);
            this.Controls.Add(this.buttonyapilacaklar);
            this.Controls.Add(this.buttonistatistik);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttondenemeekle);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.denemeleraytBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykstakipDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemelerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttondenemeekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonistatistik;
        private System.Windows.Forms.Button buttonyapilacaklar;
        private System.Windows.Forms.Label labeltelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource denemelerBindingSource1;
        private ykstakipDataSet1TableAdapters.denemelerTableAdapter denemelerTableAdapter1;
        private ykstakipDataSet2 ykstakipDataSet2;
        private System.Windows.Forms.BindingSource denemeleraytBindingSource;
        private ykstakipDataSet2TableAdapters.denemeleraytTableAdapter denemeleraytTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource denemelerBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonyenile;
        private System.Windows.Forms.TextBox textBox1;
    }
}