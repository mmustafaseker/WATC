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

    public partial class OyuncuForm : Form
    {
        WATCContextDb db;
        
        public OyuncuForm(WATCContextDb _db)
        {
            db = _db;
            InitializeComponent();
            dgvOyuncular.AutoGenerateColumns = false;
            cboTakimlar.DataSource = db.Teams.ToList();
            FormuTemizle();
            OyuncularListele();
        }

        private void OyuncularListele()
        {
            dgvOyuncular.DataSource = null;
            dgvOyuncular.DataSource = db.Players.ToList();
        }

        private void FormuTemizle()
        {
            cboTakimlar.SelectedIndex = 0;
            txtOyuncuAdi.Clear();
            btnOlustur.Text = "OLUŞTUR";
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Player oyuncu;
            if (txtOyuncuAdi.Text.Trim()=="")
            {
                MessageBox.Show("Lütfen oyuncu adı oluşturun");
                return;
            }
            if (btnOlustur.Text=="OLUŞTUR")
            {
                oyuncu = new Player();
                OyuncuDurumu(oyuncu);
                db.Players.Add(oyuncu);
            }
            else if (btnOlustur.Text=="DÜZENLE")
            {
                oyuncu = (Player)dgvOyuncular.SelectedRows[0].DataBoundItem;
                OyuncuDurumu(oyuncu);
            }
            db.SaveChanges();
            FormuTemizle();
            OyuncularListele();
        }

        private void OyuncuDurumu(Player oyuncu)
        {
            oyuncu.PlayerName = txtOyuncuAdi.Text.Trim();
            if (cboTakimlar.SelectedIndex != -1)
            {
                oyuncu.Team = (Team)cboTakimlar.SelectedItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player oyuncu = (Player)dgvOyuncular.SelectedRows[0].DataBoundItem;
            db.Players.Remove(oyuncu);
            db.SaveChanges();
            OyuncularListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Trim()=="")
            {
                OyuncularListele();
            }
            else
            {
                dgvOyuncular.DataSource = db.Players.Where(x => x.Team.TeamName.Contains(txtAra.Text.Trim())).ToList();
            }
        }
    }
}
