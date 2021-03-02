
namespace WeAreTheChamp
{
    partial class OyuncuForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.cboTakimlar = new System.Windows.Forms.ComboBox();
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuncu Oluştur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transfer Et :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.cboTakimlar);
            this.groupBox1.Controls.Add(this.txtOyuncuAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yaratıcı";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(160, 119);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(22, 119);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // cboTakimlar
            // 
            this.cboTakimlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTakimlar.FormattingEnabled = true;
            this.cboTakimlar.Location = new System.Drawing.Point(78, 79);
            this.cboTakimlar.Name = "cboTakimlar";
            this.cboTakimlar.Size = new System.Drawing.Size(168, 21);
            this.cboTakimlar.TabIndex = 2;
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(81, 38);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(165, 20);
            this.txtOyuncuAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oyuncu Adi :";
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncular.AllowUserToDeleteRows = false;
            this.dgvOyuncular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOyuncular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Team});
            this.dgvOyuncular.Location = new System.Drawing.Point(279, 53);
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.ReadOnly = true;
            this.dgvOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncular.Size = new System.Drawing.Size(307, 289);
            this.dgvOyuncular.TabIndex = 2;
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "Oyuncu Adi";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // Team
            // 
            this.Team.DataPropertyName = "Team";
            this.Team.HeaderText = "Takımı";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(337, 348);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Seçiliyi SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Seçiliyi DÜZENLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(89, 252);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(178, 20);
            this.txtAra.TabIndex = 4;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ara:";
            // 
            // OyuncuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvOyuncular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "OyuncuForm";
            this.Text = "OyuncuForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ComboBox cboTakimlar;
        private System.Windows.Forms.TextBox txtOyuncuAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label4;
    }
}