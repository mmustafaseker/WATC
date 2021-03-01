
namespace WeAreTheChamp
{
    partial class TakimOyunculariForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTumOyuncular = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lbOyuncular = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTumOyuncular);
            this.groupBox1.Location = new System.Drawing.Point(176, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu Ekle";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.Location = new System.Drawing.Point(69, 33);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(183, 20);
            this.txtAra.TabIndex = 7;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(53, 281);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(154, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ara :";
            // 
            // lbTumOyuncular
            // 
            this.lbTumOyuncular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTumOyuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTumOyuncular.FormattingEnabled = true;
            this.lbTumOyuncular.ItemHeight = 16;
            this.lbTumOyuncular.Location = new System.Drawing.Point(13, 59);
            this.lbTumOyuncular.Name = "lbTumOyuncular";
            this.lbTumOyuncular.Size = new System.Drawing.Size(245, 212);
            this.lbTumOyuncular.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(16, 321);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 30);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sİl";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lbOyuncular
            // 
            this.lbOyuncular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOyuncular.FormattingEnabled = true;
            this.lbOyuncular.Location = new System.Drawing.Point(16, 65);
            this.lbOyuncular.Name = "lbOyuncular";
            this.lbOyuncular.Size = new System.Drawing.Size(154, 238);
            this.lbOyuncular.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oyuncular :";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeamName.Location = new System.Drawing.Point(117, 9);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(37, 15);
            this.lblTeamName.TabIndex = 7;
            this.lblTeamName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Takım Adi :";
            // 
            // TakimOyunculariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lbOyuncular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.label1);
            this.Name = "TakimOyunculariForm";
            this.Text = "Takimlar ve Oyuncular";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTumOyuncular;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lbOyuncular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label label1;
    }
}