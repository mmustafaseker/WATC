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
    public partial class macOlusturForm : Form
    {
        WATCContextDb db;
        public macOlusturForm(WATCContextDb _db)
        {
            db = _db;
            InitializeComponent();

            cbTakim1.SelectedIndex = -1;
            cbTakim2.SelectedIndex = -1;
            cbTakim1.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            cbTakim2.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (cbTakim1.SelectedIndex == -1 || cbTakim2.SelectedIndex == -1 || cbTakim2.SelectedItem == cbTakim1.SelectedItem)
            {
                MessageBox.Show("Lütfen doğru seçim yapın");
            }
            else
            {
                DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);
                if (date < DateTime.Now)
                {
                    MessageBox.Show("Geçersiz Tarih!");
                    return;
                }
                db.Matches.Add(new Match()
                {
                    MatchTime=date,
                    Team1=(Team)cbTakim1.SelectedItem,
                    Team2 = (Team)cbTakim2.SelectedItem,
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
