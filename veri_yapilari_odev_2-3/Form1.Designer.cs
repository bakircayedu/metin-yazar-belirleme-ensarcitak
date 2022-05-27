
namespace veri_yapilari_odev_2_3
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
            this.btnmetinyukle = new System.Windows.Forms.Button();
            this.duzenlenecek_metin_rchtxtb = new System.Windows.Forms.RichTextBox();
            this.txtdosyayolu = new System.Windows.Forms.TextBox();
            this.lbldosyayolu = new System.Windows.Forms.Label();
            this.btnstackeoku = new System.Windows.Forms.Button();
            this.dosya_bilgileri_listbox = new System.Windows.Forms.ListBox();
            this.btnagacaaktar = new System.Windows.Forms.Button();
            this.btn_ensık_kullanılan_kelimeler = new System.Windows.Forms.Button();
            this.listbox_ensikkelimeler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_en_sik_kac_kelime = new System.Windows.Forms.TextBox();
            this.btnHashTabloOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmetinyukle
            // 
            this.btnmetinyukle.Location = new System.Drawing.Point(38, 272);
            this.btnmetinyukle.Name = "btnmetinyukle";
            this.btnmetinyukle.Size = new System.Drawing.Size(141, 34);
            this.btnmetinyukle.TabIndex = 0;
            this.btnmetinyukle.Text = "Metin Yükle";
            this.btnmetinyukle.UseVisualStyleBackColor = true;
            this.btnmetinyukle.Click += new System.EventHandler(this.btnmetinyukle_Click);
            // 
            // duzenlenecek_metin_rchtxtb
            // 
            this.duzenlenecek_metin_rchtxtb.Location = new System.Drawing.Point(25, 35);
            this.duzenlenecek_metin_rchtxtb.Name = "duzenlenecek_metin_rchtxtb";
            this.duzenlenecek_metin_rchtxtb.Size = new System.Drawing.Size(625, 217);
            this.duzenlenecek_metin_rchtxtb.TabIndex = 1;
            this.duzenlenecek_metin_rchtxtb.Text = "";
            // 
            // txtdosyayolu
            // 
            this.txtdosyayolu.Location = new System.Drawing.Point(284, 278);
            this.txtdosyayolu.Name = "txtdosyayolu";
            this.txtdosyayolu.Size = new System.Drawing.Size(366, 22);
            this.txtdosyayolu.TabIndex = 2;
            // 
            // lbldosyayolu
            // 
            this.lbldosyayolu.AutoSize = true;
            this.lbldosyayolu.Location = new System.Drawing.Point(194, 281);
            this.lbldosyayolu.Name = "lbldosyayolu";
            this.lbldosyayolu.Size = new System.Drawing.Size(84, 17);
            this.lbldosyayolu.TabIndex = 3;
            this.lbldosyayolu.Text = "Dosya Yolu:";
            // 
            // btnstackeoku
            // 
            this.btnstackeoku.Location = new System.Drawing.Point(725, 66);
            this.btnstackeoku.Name = "btnstackeoku";
            this.btnstackeoku.Size = new System.Drawing.Size(141, 32);
            this.btnstackeoku.TabIndex = 4;
            this.btnstackeoku.Text = "Metni Stack\'e Oku";
            this.btnstackeoku.UseVisualStyleBackColor = true;
            this.btnstackeoku.Click += new System.EventHandler(this.btnstackeoku_Click);
            // 
            // dosya_bilgileri_listbox
            // 
            this.dosya_bilgileri_listbox.FormattingEnabled = true;
            this.dosya_bilgileri_listbox.ItemHeight = 16;
            this.dosya_bilgileri_listbox.Location = new System.Drawing.Point(25, 364);
            this.dosya_bilgileri_listbox.Name = "dosya_bilgileri_listbox";
            this.dosya_bilgileri_listbox.Size = new System.Drawing.Size(320, 68);
            this.dosya_bilgileri_listbox.TabIndex = 5;
            // 
            // btnagacaaktar
            // 
            this.btnagacaaktar.Location = new System.Drawing.Point(725, 139);
            this.btnagacaaktar.Name = "btnagacaaktar";
            this.btnagacaaktar.Size = new System.Drawing.Size(141, 34);
            this.btnagacaaktar.TabIndex = 6;
            this.btnagacaaktar.Text = "Ağaca Aktar";
            this.btnagacaaktar.UseVisualStyleBackColor = true;
            this.btnagacaaktar.Click += new System.EventHandler(this.btnagacaaktar_Click);
            // 
            // btn_ensık_kullanılan_kelimeler
            // 
            this.btn_ensık_kullanılan_kelimeler.Location = new System.Drawing.Point(978, 108);
            this.btn_ensık_kullanılan_kelimeler.Name = "btn_ensık_kullanılan_kelimeler";
            this.btn_ensık_kullanılan_kelimeler.Size = new System.Drawing.Size(252, 38);
            this.btn_ensık_kullanılan_kelimeler.TabIndex = 7;
            this.btn_ensık_kullanılan_kelimeler.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btn_ensık_kullanılan_kelimeler.UseVisualStyleBackColor = true;
            this.btn_ensık_kullanılan_kelimeler.Click += new System.EventHandler(this.btn_ensık_kullanılan_kelimeler_Click);
            // 
            // listbox_ensikkelimeler
            // 
            this.listbox_ensikkelimeler.FormattingEnabled = true;
            this.listbox_ensikkelimeler.ItemHeight = 16;
            this.listbox_ensikkelimeler.Location = new System.Drawing.Point(978, 162);
            this.listbox_ensikkelimeler.Name = "listbox_ensikkelimeler";
            this.listbox_ensikkelimeler.Size = new System.Drawing.Size(333, 100);
            this.listbox_ensikkelimeler.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(974, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "En sık geçen kaç kelimeyi görmek istersiniz?";
            // 
            // txt_en_sik_kac_kelime
            // 
            this.txt_en_sik_kac_kelime.Location = new System.Drawing.Point(978, 65);
            this.txt_en_sik_kac_kelime.Name = "txt_en_sik_kac_kelime";
            this.txt_en_sik_kac_kelime.Size = new System.Drawing.Size(100, 22);
            this.txt_en_sik_kac_kelime.TabIndex = 10;
            // 
            // btnHashTabloOlustur
            // 
            this.btnHashTabloOlustur.Location = new System.Drawing.Point(725, 207);
            this.btnHashTabloOlustur.Name = "btnHashTabloOlustur";
            this.btnHashTabloOlustur.Size = new System.Drawing.Size(141, 38);
            this.btnHashTabloOlustur.TabIndex = 11;
            this.btnHashTabloOlustur.Text = "Hash Tablo Oluştur";
            this.btnHashTabloOlustur.UseVisualStyleBackColor = true;
            this.btnHashTabloOlustur.Click += new System.EventHandler(this.btnHashTabloOlustur_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(481, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 81);
            this.label3.TabIndex = 13;
            this.label3.Text = "LÜTFEN BUTONLARA BAŞLARINDA YAZAN NUMARA SIRASINA GÖRE BASINIZ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Metin Hakkında Genel Bilgiler";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(699, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(699, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(699, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "5";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(952, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHashTabloOlustur);
            this.Controls.Add(this.txt_en_sik_kac_kelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_ensikkelimeler);
            this.Controls.Add(this.btn_ensık_kullanılan_kelimeler);
            this.Controls.Add(this.btnagacaaktar);
            this.Controls.Add(this.dosya_bilgileri_listbox);
            this.Controls.Add(this.btnstackeoku);
            this.Controls.Add(this.lbldosyayolu);
            this.Controls.Add(this.txtdosyayolu);
            this.Controls.Add(this.duzenlenecek_metin_rchtxtb);
            this.Controls.Add(this.btnmetinyukle);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmetinyukle;
        private System.Windows.Forms.RichTextBox duzenlenecek_metin_rchtxtb;
        private System.Windows.Forms.TextBox txtdosyayolu;
        private System.Windows.Forms.Label lbldosyayolu;
        private System.Windows.Forms.Button btnstackeoku;
        private System.Windows.Forms.ListBox dosya_bilgileri_listbox;
        private System.Windows.Forms.Button btnagacaaktar;
        private System.Windows.Forms.Button btn_ensık_kullanılan_kelimeler;
        private System.Windows.Forms.ListBox listbox_ensikkelimeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_en_sik_kac_kelime;
        private System.Windows.Forms.Button btnHashTabloOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

