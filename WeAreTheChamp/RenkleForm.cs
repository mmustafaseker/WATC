using ChampData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeAreTheChamp
{
    public partial class RenkleForm : Form
    {
        WATCContextDb db;
        ChampData.Color renk;
        public RenkleForm(WATCContextDb _db)
        {
            db = _db;
            InitializeComponent();
            RenkleriListele();
        }

        private void RenkleriListele()
        {
            lbRenkler.DataSource = null;
            lbRenkler.DataSource = db.Colors.ToList();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtRenkAdi.Text.Trim()=="")
            {
                MessageBox.Show("Lütfen renk adı giriniz");
                return;
            }
            if (btnAddColor.Text=="OLUŞTUR")
            {
                if (db.Colors.Any(x => x.ColorName == txtRenkAdi.Text.Trim()))
                {
                    MessageBox.Show("Renk mevcut");
                    return;
                }
                db.Colors.Add(new ChampData.Color() 
                { 
                    ColorName=txtRenkAdi.Text.Trim(),
                    Red=(int)nudRed.Value,
                    Green=(int)nudGreen.Value,
                    BLue=(int)nudBlue.Value
                });
            }
            else if (btnDuzenle.Text=="Düzenle")
            {
                renk.ColorName = txtRenkAdi.Text;
                renk.BLue = (int)nudBlue.Value;
                renk.Red = (int)nudRed.Value;
                renk.Green = (int)nudGreen.Value;
            }
            db.SaveChanges();
            FormuTemizle();
            RenkleriListele();
        }

        private void FormuTemizle()
        {
            btnAddColor.Text = "OLUŞTUR";
            nudGreen.Value = 0;
            nudBlue.Value = 0;
            nudRed.Value = 0;
            txtRenkAdi.Clear();
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown degerDegisti = (NumericUpDown)sender;
            pbPreview.BackColor = System.Drawing.Color.FromArgb((int)nudBlue.Value, (int)nudRed.Value, (int)nudGreen.Value);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnAddColor.Text = "Düzenle";
            renk = (ChampData.Color)lbRenkler.SelectedItem;
            txtRenkAdi.Text = renk.ColorName;
            nudRed.Value = (decimal)renk.Red;
            nudGreen.Value = (decimal)renk.Green;
            nudBlue.Value = (decimal)renk.BLue;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sil = (ChampData.Color)lbRenkler.SelectedItem;
            db.Colors.Remove(sil);
            db.SaveChanges();
            RenkleriListele();
            FormuTemizle();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}
