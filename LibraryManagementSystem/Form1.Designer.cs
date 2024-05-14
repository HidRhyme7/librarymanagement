namespace LibraryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapnumara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.radiobtn_1 = new System.Windows.Forms.RadioButton();
            this.radiobtn_0 = new System.Windows.Forms.RadioButton();
            this.btn_durumgüncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı :";
            // 
            // txt_isim
            // 
            this.txt_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim.ForeColor = System.Drawing.Color.White;
            this.txt_isim.Location = new System.Drawing.Point(142, 251);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(185, 26);
            this.txt_isim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazarı     :";
            // 
            // txt_yazar
            // 
            this.txt_yazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_yazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazar.ForeColor = System.Drawing.Color.White;
            this.txt_yazar.Location = new System.Drawing.Point(142, 295);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(185, 26);
            this.txt_yazar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN       :";
            // 
            // txt_kitapnumara
            // 
            this.txt_kitapnumara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_kitapnumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapnumara.ForeColor = System.Drawing.Color.White;
            this.txt_kitapnumara.Location = new System.Drawing.Point(142, 341);
            this.txt_kitapnumara.Name = "txt_kitapnumara";
            this.txt_kitapnumara.Size = new System.Drawing.Size(185, 26);
            this.txt_kitapnumara.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(604, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID   :";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_id.Location = new System.Drawing.Point(656, 252);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(94, 26);
            this.txt_id.TabIndex = 3;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sil.Location = new System.Drawing.Point(608, 295);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(142, 35);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ekle.Location = new System.Drawing.Point(345, 251);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(88, 47);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_listele.Location = new System.Drawing.Point(345, 304);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(88, 44);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // radiobtn_1
            // 
            this.radiobtn_1.AutoSize = true;
            this.radiobtn_1.Location = new System.Drawing.Point(142, 382);
            this.radiobtn_1.Name = "radiobtn_1";
            this.radiobtn_1.Size = new System.Drawing.Size(35, 20);
            this.radiobtn_1.TabIndex = 4;
            this.radiobtn_1.TabStop = true;
            this.radiobtn_1.Text = "1";
            this.radiobtn_1.UseVisualStyleBackColor = true;
            // 
            // radiobtn_0
            // 
            this.radiobtn_0.AutoSize = true;
            this.radiobtn_0.Location = new System.Drawing.Point(142, 408);
            this.radiobtn_0.Name = "radiobtn_0";
            this.radiobtn_0.Size = new System.Drawing.Size(35, 20);
            this.radiobtn_0.TabIndex = 4;
            this.radiobtn_0.TabStop = true;
            this.radiobtn_0.Text = "0";
            this.radiobtn_0.UseVisualStyleBackColor = true;
            this.radiobtn_0.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_durumgüncelle
            // 
            this.btn_durumgüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_durumgüncelle.Location = new System.Drawing.Point(345, 382);
            this.btn_durumgüncelle.Name = "btn_durumgüncelle";
            this.btn_durumgüncelle.Size = new System.Drawing.Size(88, 47);
            this.btn_durumgüncelle.TabIndex = 5;
            this.btn_durumgüncelle.Text = "  DURUM \r\nGÜNCELLE";
            this.btn_durumgüncelle.UseVisualStyleBackColor = false;
            this.btn_durumgüncelle.Click += new System.EventHandler(this.btn_durumgüncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(452, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 58);
            this.label5.TabIndex = 6;
            this.label5.Text = "ZAFER DOĞAN AĞYAR\r\n         222503062";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_durumgüncelle);
            this.Controls.Add(this.radiobtn_0);
            this.Controls.Add(this.radiobtn_1);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kitapnumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapnumara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.RadioButton radiobtn_1;
        private System.Windows.Forms.RadioButton radiobtn_0;
        private System.Windows.Forms.Button btn_durumgüncelle;
        private System.Windows.Forms.Label label5;
    }
}

