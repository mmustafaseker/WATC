
namespace WeAreTheChamp
{
    partial class takimlarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTakimlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTakımOlustur = new System.Windows.Forms.Button();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.btnRenkEkle = new System.Windows.Forms.Button();
            this.cboRenk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRenkler = new System.Windows.Forms.ListBox();
            this.txtTakimAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnOyuncular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAKIM OLUŞTURUCU";
            // 
            // lbTakimlar
            // 
            this.lbTakimlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTakimlar.FormattingEnabled = true;
            this.lbTakimlar.Location = new System.Drawing.Point(470, 40);
            this.lbTakimlar.Name = "lbTakimlar";
            this.lbTakimlar.Size = new System.Drawing.Size(173, 316);
            this.lbTakimlar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Takımlar :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnTakımOlustur);
            this.groupBox1.Controls.Add(this.btnDeleteColor);
            this.groupBox1.Controls.Add(this.btnRenkEkle);
            this.groupBox1.Controls.Add(this.cboRenk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbRenkler);
            this.groupBox1.Controls.Add(this.txtTakimAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(57, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 271);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takım Oluşturucu";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(141, 202);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(106, 37);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTakımOlustur
            // 
            this.btnTakımOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakımOlustur.Location = new System.Drawing.Point(253, 192);
            this.btnTakımOlustur.Name = "btnTakımOlustur";
            this.btnTakımOlustur.Size = new System.Drawing.Size(102, 57);
            this.btnTakımOlustur.TabIndex = 9;
            this.btnTakımOlustur.Text = "Takım Oluştur";
            this.btnTakımOlustur.UseVisualStyleBackColor = true;
            this.btnTakımOlustur.Click += new System.EventHandler(this.btnTakımOlustur_Click);
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.Enabled = false;
            this.btnDeleteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColor.Location = new System.Drawing.Point(136, 92);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(167, 26);
            this.btnDeleteColor.TabIndex = 7;
            this.btnDeleteColor.Text = "Seçili Rengi Sil";
            this.btnDeleteColor.UseVisualStyleBackColor = true;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // btnRenkEkle
            // 
            this.btnRenkEkle.Enabled = false;
            this.btnRenkEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenkEkle.Location = new System.Drawing.Point(223, 63);
            this.btnRenkEkle.Name = "btnRenkEkle";
            this.btnRenkEkle.Size = new System.Drawing.Size(80, 23);
            this.btnRenkEkle.TabIndex = 6;
            this.btnRenkEkle.Text = "Renk Ekle";
            this.btnRenkEkle.UseVisualStyleBackColor = true;
            this.btnRenkEkle.Click += new System.EventHandler(this.btnRenkEkle_Click);
            // 
            // cboRenk
            // 
            this.cboRenk.Enabled = false;
            this.cboRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRenk.FormattingEnabled = true;
            this.cboRenk.Location = new System.Drawing.Point(137, 65);
            this.cboRenk.Name = "cboRenk";
            this.cboRenk.Size = new System.Drawing.Size(80, 21);
            this.cboRenk.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Renk Ekle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Renkler :";
            // 
            // lbRenkler
            // 
            this.lbRenkler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRenkler.Enabled = false;
            this.lbRenkler.FormattingEnabled = true;
            this.lbRenkler.Location = new System.Drawing.Point(6, 50);
            this.lbRenkler.Name = "lbRenkler";
            this.lbRenkler.Size = new System.Drawing.Size(120, 199);
            this.lbRenkler.TabIndex = 2;
            // 
            // txtTakimAdi
            // 
            this.txtTakimAdi.Location = new System.Drawing.Point(139, 156);
            this.txtTakimAdi.Name = "txtTakimAdi";
            this.txtTakimAdi.Size = new System.Drawing.Size(166, 20);
            this.txtTakimAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Takım Adı :";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(175, 317);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(137, 37);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "SiL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDüzenle.Location = new System.Drawing.Point(49, 319);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(120, 37);
            this.btnDüzenle.TabIndex = 16;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnOyuncular
            // 
            this.btnOyuncular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOyuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyuncular.Location = new System.Drawing.Point(319, 317);
            this.btnOyuncular.Name = "btnOyuncular";
            this.btnOyuncular.Size = new System.Drawing.Size(120, 37);
            this.btnOyuncular.TabIndex = 15;
            this.btnOyuncular.Text = "Oyuncular";
            this.btnOyuncular.UseVisualStyleBackColor = true;
            this.btnOyuncular.Click += new System.EventHandler(this.btnOyuncular_Click);
            // 
            // takimlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 368);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnOyuncular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTakimlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "takimlarForm";
            this.Text = "takimlarForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTakimlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTakımOlustur;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.Button btnRenkEkle;
        private System.Windows.Forms.ComboBox cboRenk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbRenkler;
        private System.Windows.Forms.TextBox txtTakimAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnOyuncular;
    }
}