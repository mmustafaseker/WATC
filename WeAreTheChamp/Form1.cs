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
    public partial class Form1 : Form
    {
        WATCContextDb db = new WATCContextDb();
        public Form1()
        {
            InitializeComponent();
            MaclariListele();
            SonucKontrol();
            TakimKontrol();
            dgvKarsilasmalar.AutoGenerateColumns = false; // otomatik seçim iptal
        }

        private void TakimKontrol()
        {
            if (db.Teams.Any(x => x.TeamName == "Belirtilmemiş"))
            {
                return;
            }
            else
            {
                db.Teams.Add(new Team()
                {
                    TeamName = "Belirtilmemiş"
                });
                db.SaveChanges();
            }
        }

        private void MaclariListele()
        {
            var maclar = db.Matches.ToList()
                .Select
                (x => new
                {
                    MatchId = x.Id,
                    Team1 = x.Team1,
                    Team2 = x.Team2,
                    Date = x.MatchTime?.ToShortDateString(),
                    Time = x.MatchTime?.ToShortDateString(),
                    Score = x.Score1 + " - " + x.Score2,
                    MatchResult = x.Result
                });
            dgvKarsilasmalar.DataSource = maclar.ToList();
        }
        private void SonucKontrol()
        {
            var maclar = db.Matches.ToList();
            foreach (Match mac in maclar)
            {
                // takım 1'in skoru takım 2'den büyükse takım1 kazınsın
                if (mac.Score1 > mac.Score2)
                {
                    mac.Result = Result.team1;
                }
                else if (mac.Score1 < mac.Score2)
                {
                    mac.Result = Result.team2;
                }
                else
                {
                    mac.Result = Result.tie;
                }
                db.SaveChanges();
            }
        }

        private void tsmiTakimlar_Click(object sender, EventArgs e)
        {
            takimlarForm frmTakimlar = new takimlarForm(db);
            frmTakimlar.ShowDialog();
        }

        private void tsmiRenkler_Click(object sender, EventArgs e)
        {
            RenkleForm frmRenkler = new RenkleForm(db);
            frmRenkler.ShowDialog();
        }

        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            OyuncuForm frmOyuncular = new OyuncuForm(db);
            frmOyuncular.ShowDialog();
        }

        private void btnYeniKarsilasma_Click(object sender, EventArgs e)
        {
            macOlusturForm frmMacOlustur = new macOlusturForm(db);
            frmMacOlustur.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalar.SelectedRows.Count==0)
            {
                return;
            }
            //seçili satırın Id'sine göre silme işlemi yapmak için Id elimize alıyoruz
            int macId = (int)dgvKarsilasmalar.SelectedRows[0].Cells[0].Value;
            
            //db nesnesindeki en az bir Id ile seçili Id aynıysa mac ogesinde tutalım 
            Match mac = db.Matches.ToList().FirstOrDefault(x => x.Id == macId);

            //Silelim
            db.Matches.Remove(mac);

            db.SaveChanges();
            MaclariListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalar.SelectedRows.Count == 0)
            {
                return;
            }

            int macId2 = (int)dgvKarsilasmalar.SelectedRows[0].Cells[0].Value;

            Match mac2 = db.Matches.ToList().FirstOrDefault(x => x.Id == macId2);

            macDuzenleForm frmMacDuzenle = new macDuzenleForm(db, mac2);
            frmMacDuzenle.ShowDialog();
            MaclariListele();
        }
    }
}
