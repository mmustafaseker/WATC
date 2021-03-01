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
    public partial class takimlarForm : Form
    {
        WATCContextDb db;
        Team takımDuzenle;

        public takimlarForm(WATCContextDb _db)
        {
            db = _db;
            InitializeComponent();
            TakımlarıGöster();
            cboRenk.DataSource = db.Colors.ToList();
        }

        private void TakımlarıGöster()
        {
            lbRenkler.DataSource = null;
            lbRenkler.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
        }

        private void btnTakımOlustur_Click(object sender, EventArgs e)
        {
            if (txtTakimAdi.Text.Trim() =="")
            {
                MessageBox.Show("LÜtfen takım adı giriniz");
                return;
            }
            if (btnTakımOlustur.Text == "Takım Oluştur" )
            {
                if (db.Teams.Any(x => x.TeamName ==txtTakimAdi.Text.Trim()))
                {
                    MessageBox.Show("Takım adı kullanılmaktadır");
                    return;
                }
                db.Teams.Add(new Team
                {
                    TeamName =txtTakimAdi.Text.Trim()
                });
                db.SaveChanges();
                FormuTemizle();
                TakımlarıGöster();
            }
            else if (btnTakımOlustur.Text=="Takım Düzenle")
            {
                takımDuzenle = (Team)lbTakimlar.SelectedItem;
                takımDuzenle.TeamName = txtTakimAdi.Text;
                db.SaveChanges();
                TakımlarıGöster();
                FormuTemizle();
                lbTakimlar.Enabled = true;
            }
        }

        private void FormuTemizle()
        {
            
            btnTakımOlustur.Text = "Takım Oluştur";
            txtTakimAdi.Clear();
            lbRenkler.DataSource = null;

            //Takım için eklenen renkleri de temizle
            for (int i = 0; i < lbRenkler.Items.Count; i++)
            {
                lbRenkler.Items.RemoveAt(i);
            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            if (lbTakimlar.SelectedItem != null)
            {
                btnTakımOlustur.Text = "Takım Düzenle";
                takımDuzenle = (Team)lbTakimlar.SelectedItem;
                txtTakimAdi.Text = takımDuzenle.TeamName;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            for (int i = 0; i < lbRenkler.Items.Count; i++)
            {
                lbRenkler.Items.RemoveAt(i);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sil = (Team)lbTakimlar.SelectedItem;
            if (sil.TeamPlayers.Count>0)
            {
                MessageBox.Show("Takımda oyuncular mevcut. Lütfen oyuncuları transfer edin");
                return;
            }
            if (db.Matches.Any(x=> x.Team1.Id==sil.Id) || db.Matches.Any(x=> x.Team2.Id == sil.Id))
            {
                MessageBox.Show("Seçili takımın mamçı bulunmaktadır.Maç iptali Yapınız");
                return;
            }
            db.Teams.Remove(sil);
            db.SaveChanges();
            TakımlarıGöster();
        }

        private void btnRenkEkle_Click(object sender, EventArgs e)
        {
            var duzenle = (Team)lbTakimlar.SelectedItem;
            ChampData.Color renk = (ChampData.Color)cboRenk.SelectedItem;

            if (takımDuzenle.TeamColors.Any(x => x.ColorId == renk.Id))
            {
                MessageBox.Show("Renk mevcut");
                return;
            }
            takımDuzenle.TeamColors.Add(new TeamColor()
            {
                Team=takımDuzenle,
                Color=(ChampData.Color)cboRenk.SelectedItem
            });
            db.SaveChanges();
            cboRenk.SelectedIndex = -1;
            lbRenkler.DataSource = null;
            lbRenkler.DataSource = duzenle.TeamColors.ToList();
        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            var takim = (Team)lbTakimlar.SelectedItem;
            TeamColor renkSil = (TeamColor)lbRenkler.SelectedItem;
            takim.TeamColors.Remove(renkSil);
            lbRenkler.DataSource = takim.TeamColors.ToList();
        }

        private void btnOyuncular_Click(object sender, EventArgs e)
        {
            if (lbTakimlar.SelectedIndex == -1)
            {
                MessageBox.Show("lütfen bir takım seçin");
            }
            Team team = (Team)lbTakimlar.SelectedItem;
            TakimOyunculariForm frmTakimOyuncular = new TakimOyunculariForm(db, team);
            frmTakimOyuncular.ShowDialog();
        }
    }
}
