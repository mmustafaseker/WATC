
namespace WeAreTheChamp
{
    partial class RenkleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbRenkler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRenkAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENK OLUŞTURUCU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RENKLER";
            // 
            // lbRenkler
            // 
            this.lbRenkler.FormattingEnabled = true;
            this.lbRenkler.Location = new System.Drawing.Point(15, 50);
            this.lbRenkler.Name = "lbRenkler";
            this.lbRenkler.Size = new System.Drawing.Size(221, 277);
            this.lbRenkler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbPreview);
            this.groupBox1.Controls.Add(this.nudBlue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudGreen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRenkAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(242, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Color";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(183, 198);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(99, 29);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(183, 147);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(99, 29);
            this.btnAddColor.TabIndex = 13;
            this.btnAddColor.Text = "OLUŞTUR";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Önizleme";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(195, 73);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(77, 55);
            this.pbPreview.TabIndex = 11;
            this.pbPreview.TabStop = false;
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(10, 239);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 20);
            this.nudBlue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blue:";
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(10, 178);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(120, 20);
            this.nudGreen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Green:";
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(10, 117);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(120, 20);
            this.nudRed.TabIndex = 6;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red:";
            // 
            // txtRenkAdi
            // 
            this.txtRenkAdi.Location = new System.Drawing.Point(10, 55);
            this.txtRenkAdi.Name = "txtRenkAdi";
            this.txtRenkAdi.Size = new System.Drawing.Size(128, 20);
            this.txtRenkAdi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Renk Adı :";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(15, 334);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(113, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // RenkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 378);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRenkler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RenkleForm";
            this.Text = "RenkleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRenkler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRenkAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
    }
}