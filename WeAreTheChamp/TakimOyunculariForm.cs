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
    public partial class TakimOyunculariForm : Form
    {
        WATCContextDb db;
        Team team;
        public TakimOyunculariForm(WATCContextDb _db, Team _team)
        {
            team = _team;
            db = _db;
            InitializeComponent();
            OyuncularıListele();
        }

        private void OyuncularıListele()
        {
            lbOyuncular.DataSource = db.Players.Where(x => x.Team.TeamName == team.TeamName).ToList();
            lbTumOyuncular.DataSource = db.Players.Where(x => x.Team.TeamName != team.TeamName).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbTumOyuncular.SelectedItem;
            player.Team = team;
            db.SaveChanges();
            OyuncularıListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbOyuncular.SelectedItem;
            player.Team = db.Teams.FirstOrDefault(x => x.TeamName == "Belirtilmemiş");
            db.SaveChanges();
            OyuncularıListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Trim() == "")
            {
                OyuncularıListele();
            }
            else
            {
                lbTumOyuncular.DataSource = db.Players
                    .Where(x => x.Team.TeamName != team.TeamName && x.PlayerName
                    .Contains(txtAra.Text.Trim()))
                    .ToList();
            }
        }
    }
}
