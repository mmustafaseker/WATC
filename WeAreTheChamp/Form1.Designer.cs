
namespace WeAreTheChamp
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
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTakimlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenkler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvKarsilasmalar = new System.Windows.Forms.DataGridView();
            this.MacId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takim1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takım2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(12, 390);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(93, 390);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARŞILAŞMALAR";
            // 
            // btnYeniKarsilasma
            // 
            this.btnYeniKarsilasma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKarsilasma.Location = new System.Drawing.Point(529, 55);
            this.btnYeniKarsilasma.Name = "btnYeniKarsilasma";
            this.btnYeniKarsilasma.Size = new System.Drawing.Size(178, 23);
            this.btnYeniKarsilasma.TabIndex = 1;
            this.btnYeniKarsilasma.Text = "+ YENİ KARŞILAŞMA";
            this.btnYeniKarsilasma.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasma.Click += new System.EventHandler(this.btnYeniKarsilasma_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTakimlar,
            this.tsmiRenkler,
            this.tsmiOyuncular});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTakimlar
            // 
            this.tsmiTakimlar.Name = "tsmiTakimlar";
            this.tsmiTakimlar.Size = new System.Drawing.Size(74, 20);
            this.tsmiTakimlar.Text = "TAKIMLAR";
            this.tsmiTakimlar.Click += new System.EventHandler(this.tsmiTakimlar_Click);
            // 
            // tsmiRenkler
            // 
            this.tsmiRenkler.Name = "tsmiRenkler";
            this.tsmiRenkler.Size = new System.Drawing.Size(67, 20);
            this.tsmiRenkler.Text = "RENKLER";
            this.tsmiRenkler.Click += new System.EventHandler(this.tsmiRenkler_Click);
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(89, 20);
            this.tsmiOyuncular.Text = "OYUNCULAR";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // dgvKarsilasmalar
            // 
            this.dgvKarsilasmalar.AllowUserToAddRows = false;
            this.dgvKarsilasmalar.AllowUserToDeleteRows = false;
            this.dgvKarsilasmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKarsilasmalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKarsilasmalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKarsilasmalar.CausesValidation = false;
            this.dgvKarsilasmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarsilasmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MacId,
            this.Takim1,
            this.takım2,
            this.Tarih,
            this.Saat,
            this.Sonuc});
            this.dgvKarsilasmalar.Location = new System.Drawing.Point(12, 87);
            this.dgvKarsilasmalar.MultiSelect = false;
            this.dgvKarsilasmalar.Name = "dgvKarsilasmalar";
            this.dgvKarsilasmalar.ReadOnly = true;
            this.dgvKarsilasmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarsilasmalar.Size = new System.Drawing.Size(717, 299);
            this.dgvKarsilasmalar.TabIndex = 0;
            // 
            // MacId
            // 
            this.MacId.DataPropertyName = "MatchId";
            this.MacId.HeaderText = "Maç Id";
            this.MacId.Name = "MacId";
            this.MacId.ReadOnly = true;
            // 
            // Takim1
            // 
            this.Takim1.DataPropertyName = "Team1";
            this.Takim1.HeaderText = "1.Takım";
            this.Takim1.Name = "Takim1";
            this.Takim1.ReadOnly = true;
            // 
            // takım2
            // 
            this.takım2.DataPropertyName = "Team2";
            this.takım2.HeaderText = "2.Takım";
            this.takım2.Name = "takım2";
            this.takım2.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Date";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Time";
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            // 
            // Sonuc
            // 
            this.Sonuc.DataPropertyName = "Score";
            this.Sonuc.HeaderText = "Sonuç";
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniKarsilasma);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dgvKarsilasmalar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "SuperToto Süper Lig 2021";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniKarsilasma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakimlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenkler;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.DataGridView dgvKarsilasmalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takim1;
        private System.Windows.Forms.DataGridViewTextBoxColumn takım2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuc;
    }
}

