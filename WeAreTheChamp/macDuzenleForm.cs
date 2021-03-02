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
    public partial class macDuzenleForm : Form
    {
        WATCContextDb db;
        Match mac;
        public macDuzenleForm(WATCContextDb _db , Match _mac)
        {
            db = _db;
            mac = _mac;
            InitializeComponent();
            FormuDuzeble();
        }

        private void FormuDuzeble()
        {
            cbTakim1.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            cbTakim2.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            DateTime dateTime = (DateTime)mac.MatchTime;
            cbTakim1.SelectedItem = mac.Team1;
            cbTakim2.SelectedItem = mac.Team2;
            nudHour.Value = (decimal)dateTime.Hour;
            nudMinute.Value = (decimal)dateTime.Minute;
            nudMonth.Value = (decimal)dateTime.Month;
            nudDay.Value = (decimal)dateTime.Day;
            nudYear.Value = (decimal)dateTime.Year;
            nudTeam1Score.Value = (decimal)mac.Score1;
            nudTeam2Score.Value = (decimal)mac.Score2;
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (cbTakim1.SelectedIndex == -1 || cbTakim2.SelectedIndex == -1 || cbTakim2.SelectedItem == cbTakim1.SelectedItem)
            {
                MessageBox.Show("Geçerli bir seçim yapın");
                return;
            }

            DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);
            if (date<DateTime.Now)
            {
                MessageBox.Show("Geçersiz tarih");
                return;
            }
            mac.Team1 = (Team)cbTakim1.SelectedItem;
            mac.Team2 = (Team)cbTakim2.SelectedItem;
            mac.Score1 = (int)nudTeam1Score.Value;
            mac.Score2 = (int)nudTeam2Score.Value;
            mac.MatchTime = date;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
