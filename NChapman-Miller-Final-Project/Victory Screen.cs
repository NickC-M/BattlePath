using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NChapman_Miller_Final_Project
{
    public partial class Victory_Screen : Form
    {
        public Player winner;

        private SoundPlayer hooraySound;
        private SoundPlayer vicMusic;
        public Victory_Screen(Player gamer)
        {
            InitializeComponent();
            winner = gamer;

            hooraySound = new SoundPlayer(Properties.Resources.hooray);
            vicMusic = new SoundPlayer(Properties.Resources.vicmusic);

        }

        private void Victory_Screen_Load(object sender, EventArgs e)
        {
            lblName.Text = winner.Name;
            lblLvl.Text = $"Lvl: {winner.Level}";
            lblClass.Text = $"Class: {winner.BattleClass.Name}";
            pBoxClass.Image = winner.BattleClass.Icon;
            lblCongrats.Text = $"CONGRATS {winner.Name}!! YOU SAVED THE CASTLE !!";
            lblDmg.Text = $"Dmg: {winner.BattleClass.Damage}";
            lblMaxHp.Text = $"MaxHP: {winner.BattleClass.MaxHealth}";
            lblSpeed.Text = $"Spd: {winner.BattleClass.Speed}";


            hooraySound.PlaySync();
            hooraySound.PlaySync();
            vicMusic.Play();

        }

        private void butContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            vicMusic.Stop();
        }
    }
}
