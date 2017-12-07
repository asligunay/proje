namespace MEETING_ORGANIZER
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
            this.btnYeniRandevu = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtKatilimcilar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBitisSaati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaslangicSaati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplantiKonusu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.btnRandevuGuncelle = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.btnRandevuKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniRandevu
            // 
            this.btnYeniRandevu.Location = new System.Drawing.Point(20, 362);
            this.btnYeniRandevu.Name = "btnYeniRandevu";
            this.btnYeniRandevu.Size = new System.Drawing.Size(120, 30);
            this.btnYeniRandevu.TabIndex = 34;
            this.btnYeniRandevu.Text = "Yeni Randevu";
            this.btnYeniRandevu.UseVisualStyleBackColor = true;
            this.btnYeniRandevu.Click += new System.EventHandler(this.btnYeniRandevu_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(741, 64);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(185, 30);
            this.btnRandevuSil.TabIndex = 33;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // txtKatilimcilar
            // 
            this.txtKatilimcilar.Location = new System.Drawing.Point(125, 319);
            this.txtKatilimcilar.Name = "txtKatilimcilar";
            this.txtKatilimcilar.Size = new System.Drawing.Size(154, 20);
            this.txtKatilimcilar.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Katılımcılar :";
            // 
            // txtBitisSaati
            // 
            this.txtBitisSaati.Location = new System.Drawing.Point(125, 266);
            this.txtBitisSaati.Name = "txtBitisSaati";
            this.txtBitisSaati.Size = new System.Drawing.Size(154, 20);
            this.txtBitisSaati.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Bitiş Saati :";
            // 
            // txtBaslangicSaati
            // 
            this.txtBaslangicSaati.Location = new System.Drawing.Point(125, 212);
            this.txtBaslangicSaati.Name = "txtBaslangicSaati";
            this.txtBaslangicSaati.Size = new System.Drawing.Size(154, 20);
            this.txtBaslangicSaati.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Başlangıç Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Toplantı Tarihi :";
            // 
            // txtToplantiKonusu
            // 
            this.txtToplantiKonusu.Location = new System.Drawing.Point(125, 100);
            this.txtToplantiKonusu.Name = "txtToplantiKonusu";
            this.txtToplantiKonusu.Size = new System.Drawing.Size(154, 20);
            this.txtToplantiKonusu.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Toplantı Konusu :";
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(297, 64);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(185, 30);
            this.btnRandevuListele.TabIndex = 22;
            this.btnRandevuListele.Text = "Randevu Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(524, 64);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(185, 30);
            this.btnRandevuGuncelle.TabIndex = 21;
            this.btnRandevuGuncelle.Text = "Randevu Güncelle";
            this.btnRandevuGuncelle.UseVisualStyleBackColor = true;
            this.btnRandevuGuncelle.Click += new System.EventHandler(this.btnRandevuGuncelle_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(297, 100);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(629, 294);
            this.DataGrid.TabIndex = 20;
            // 
            // btnRandevuKayit
            // 
            this.btnRandevuKayit.Location = new System.Drawing.Point(159, 362);
            this.btnRandevuKayit.Name = "btnRandevuKayit";
            this.btnRandevuKayit.Size = new System.Drawing.Size(120, 30);
            this.btnRandevuKayit.TabIndex = 19;
            this.btnRandevuKayit.Text = "Randevu Kayıt";
            this.btnRandevuKayit.UseVisualStyleBackColor = true;
            this.btnRandevuKayit.Click += new System.EventHandler(this.btnRandevuKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mechsoft Toplantı Randevu Sistemine Hoşgeldiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(944, 436);
            this.Controls.Add(this.btnYeniRandevu);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtKatilimcilar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBitisSaati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBaslangicSaati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplantiKonusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRandevuListele);
            this.Controls.Add(this.btnRandevuGuncelle);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.btnRandevuKayit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meeting Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniRandevu;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtKatilimcilar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBitisSaati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaslangicSaati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplantiKonusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandevuListele;
        private System.Windows.Forms.Button btnRandevuGuncelle;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button btnRandevuKayit;
        private System.Windows.Forms.Label label1;
    }
}

