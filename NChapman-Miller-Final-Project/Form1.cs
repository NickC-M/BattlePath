using System.Media;
/*
 * Nicholas Chapman-Miller
 * Final Project
 * CPT 185-AO1H
 */
namespace NChapman_Miller_Final_Project
{
    public partial class frmMainMenu : Form
    {
        public SoundPlayer[] atkSounds;


        public character_type Knight;
        public character_type Beserker;
        public character_type Blob;
        public character_type Bowman;
        public character_type Wizard;

        
        public frmMainMenu()
        {
            InitializeComponent();
            atkSounds = new SoundPlayer[5];
            atkSounds[0] = new SoundPlayer(Properties.Resources.sword_swing);
            atkSounds[1] = new SoundPlayer(Properties.Resources.beserkattk);
            atkSounds[2] = new SoundPlayer(Properties.Resources.slime);
            atkSounds[3] = new SoundPlayer(Properties.Resources.arrow);
            atkSounds[4] = new SoundPlayer(Properties.Resources.spell);

            Knight = new character_type("Knight", "Big, strong, and careful, but slow", 7, 10, 3, 50, 85, Properties.Resources.Knight, atkSounds[0]);
            Beserker = new character_type("Beserker", "Unpredictable and unstoppable", 16, 7, 8, 40, 40, Properties.Resources.Beserker, atkSounds[1]);
            Blob = new character_type("Blob", "Big goo doesn't do much, but absorb", 2, 8, 2, 75, 90, Properties.Resources.Blob, atkSounds[2]);
            Bowman = new character_type("Bowman", "Fast, lethal, precise, and made of glass", 8, 4, 9, 20, 95, Properties.Resources.Bowman, atkSounds[3]);
            Wizard = new character_type("Wizard", "strange man with stranger ideas", 10, 3, 5, 30, 60, Properties.Resources.Wizard, atkSounds[4]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing!");
            this.Close();
        }

        private void butPlayGame_Click(object sender, EventArgs e)
        {
            if (txtBoxPlayerName.Text != "")
            {
                if (!radButKnight.Checked && !radButBeserk.Checked && !radButBlob.Checked && !radButBowman.Checked && !radButWizard.Checked)
                {
                    MessageBox.Show("Please select a class from the box");
                    return;
                }
                else
                {
                    string name = txtBoxPlayerName.Text;
                    character_type selectedClass = SelectClass();
                    resetClasses();
                    Player gamer = new Player(name, selectedClass, selectedClass.MaxHealth, 0, 1);
                    frmGame gameForm = new frmGame(gamer);
                    gameForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter your name");
            }
        }

        private void butClassInfo_Click(object sender, EventArgs e)
        {
            if (radButKnight.Checked)
            {
                ShowInfo(Knight);
            }else if (radButBeserk.Checked)
            {
                ShowInfo(Beserker);
            }else if(radButBlob.Checked)
            {
                ShowInfo(Blob);
            }else if (radButBowman.Checked)
            {
                ShowInfo(Bowman);
            }else if (radButWizard.Checked)
            {
                ShowInfo(Wizard);
            }
            else
            {
                MessageBox.Show("Click a class to show its stats");
            }
        }

        public void ShowInfo(character_type battleClass)
        {
            frmClassInfo infoForm = new frmClassInfo(battleClass);
            infoForm.ShowDialog();
        }
        public character_type SelectClass()
        {
            if (radButKnight.Checked)
            {
                return Knight;
            }else if (radButBeserk.Checked)
            {
                return Beserker;
            }else if (radButBlob.Checked)
            {
                return Blob;
            }else if (radButBowman.Checked)
            {
                return Bowman;
            }else if (radButWizard.Checked)
            {
                return Wizard;
            }
            return Knight;
        }
        private void resetClasses()
        {
            Knight = new character_type("Knight", "Big, strong, and careful, but slow", 6, 10, 3, 50, 85, Properties.Resources.Knight, atkSounds[0]);
            Beserker = new character_type("Beserker", "Unpredictable and unstoppable", 16, 7, 8, 40, 40, Properties.Resources.Beserker, atkSounds[1]);
            Blob = new character_type("Blob", "Big goo doesn't do much, but absorb", 2, 8, 2, 75, 90, Properties.Resources.Blob, atkSounds[2]);
            Bowman = new character_type("Bowman", "Fast, lethal, precise, and made of glass", 8, 4, 9, 20, 95, Properties.Resources.Bowman, atkSounds[3]);
            Wizard = new character_type("Wizard", "strange man with stranger ideas", 10, 3, 5, 30, 60, Properties.Resources.Wizard, atkSounds[4]);
        }
    }
}
