namespace NChapman_Miller_Final_Project
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            grpBoxPlayerStats = new GroupBox();
            lblJuiceAmt = new Label();
            pBarJuice = new ProgressBar();
            lblJuice = new Label();
            lblDefense = new Label();
            lblHealth = new Label();
            lblPlayerHealth = new Label();
            pBarHealth = new ProgressBar();
            lblPlayerClass = new Label();
            lblPlayerLevel = new Label();
            lblPlayerExp = new Label();
            lblPlayerAcc = new Label();
            lblPlayerSpd = new Label();
            lblPlayerDmg = new Label();
            butWalk = new Button();
            pBoxPlayerIcon = new PictureBox();
            butHeal = new Button();
            butExit = new Button();
            pBoxMob = new PictureBox();
            grpBoxMobStats = new GroupBox();
            lblMobCurrentHP = new Label();
            lblMobAcc = new Label();
            pBarMobHP = new ProgressBar();
            lblMobSpd = new Label();
            lblMobDmg = new Label();
            lblMobHealth = new Label();
            butAttack = new Button();
            cBoxLevelOpts = new ComboBox();
            butLevelUp = new Button();
            butBlock = new Button();
            butRun = new Button();
            pBoxHurt = new PictureBox();
            pBoxHurtMob = new PictureBox();
            lstBoxLog = new ListBox();
            lblMessage = new Label();
            butContinue = new Button();
            pBoxDeath = new PictureBox();
            grpBoxPlayerStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxPlayerIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMob).BeginInit();
            grpBoxMobStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxHurt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxHurtMob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDeath).BeginInit();
            SuspendLayout();
            // 
            // grpBoxPlayerStats
            // 
            grpBoxPlayerStats.Controls.Add(lblJuiceAmt);
            grpBoxPlayerStats.Controls.Add(pBarJuice);
            grpBoxPlayerStats.Controls.Add(lblJuice);
            grpBoxPlayerStats.Controls.Add(lblDefense);
            grpBoxPlayerStats.Controls.Add(lblHealth);
            grpBoxPlayerStats.Controls.Add(lblPlayerHealth);
            grpBoxPlayerStats.Controls.Add(pBarHealth);
            grpBoxPlayerStats.Controls.Add(lblPlayerClass);
            grpBoxPlayerStats.Controls.Add(lblPlayerLevel);
            grpBoxPlayerStats.Controls.Add(lblPlayerExp);
            grpBoxPlayerStats.Controls.Add(lblPlayerAcc);
            grpBoxPlayerStats.Controls.Add(lblPlayerSpd);
            grpBoxPlayerStats.Controls.Add(lblPlayerDmg);
            grpBoxPlayerStats.Location = new Point(51, 35);
            grpBoxPlayerStats.Name = "grpBoxPlayerStats";
            grpBoxPlayerStats.Size = new Size(202, 162);
            grpBoxPlayerStats.TabIndex = 0;
            grpBoxPlayerStats.TabStop = false;
            grpBoxPlayerStats.Text = "Player Stats";
            // 
            // lblJuiceAmt
            // 
            lblJuiceAmt.AutoSize = true;
            lblJuiceAmt.BackColor = Color.Transparent;
            lblJuiceAmt.Location = new Point(77, 58);
            lblJuiceAmt.Name = "lblJuiceAmt";
            lblJuiceAmt.Size = new Size(29, 15);
            lblJuiceAmt.TabIndex = 16;
            lblJuiceAmt.Text = "N/A";
            // 
            // pBarJuice
            // 
            pBarJuice.ForeColor = Color.Red;
            pBarJuice.Location = new Point(51, 54);
            pBarJuice.Name = "pBarJuice";
            pBarJuice.Size = new Size(100, 23);
            pBarJuice.TabIndex = 17;
            // 
            // lblJuice
            // 
            lblJuice.AutoSize = true;
            lblJuice.Location = new Point(6, 58);
            lblJuice.Name = "lblJuice";
            lblJuice.Size = new Size(39, 15);
            lblJuice.TabIndex = 15;
            lblJuice.Text = "Juice: ";
            // 
            // lblDefense
            // 
            lblDefense.AutoSize = true;
            lblDefense.Location = new Point(93, 135);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(55, 15);
            lblDefense.TabIndex = 14;
            lblDefense.Text = "Defense: ";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(6, 29);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(48, 15);
            lblHealth.TabIndex = 13;
            lblHealth.Text = "Health: ";
            // 
            // lblPlayerHealth
            // 
            lblPlayerHealth.AutoSize = true;
            lblPlayerHealth.BackColor = Color.Transparent;
            lblPlayerHealth.Location = new Point(83, 29);
            lblPlayerHealth.Name = "lblPlayerHealth";
            lblPlayerHealth.Size = new Size(29, 15);
            lblPlayerHealth.TabIndex = 0;
            lblPlayerHealth.Text = "N/A";
            // 
            // pBarHealth
            // 
            pBarHealth.ForeColor = Color.Red;
            pBarHealth.Location = new Point(57, 25);
            pBarHealth.Name = "pBarHealth";
            pBarHealth.Size = new Size(100, 23);
            pBarHealth.TabIndex = 12;
            // 
            // lblPlayerClass
            // 
            lblPlayerClass.AutoSize = true;
            lblPlayerClass.Location = new Point(76, 12);
            lblPlayerClass.Name = "lblPlayerClass";
            lblPlayerClass.Size = new Size(40, 15);
            lblPlayerClass.TabIndex = 6;
            lblPlayerClass.Text = "Class: ";
            // 
            // lblPlayerLevel
            // 
            lblPlayerLevel.AutoSize = true;
            lblPlayerLevel.Location = new Point(93, 111);
            lblPlayerLevel.Name = "lblPlayerLevel";
            lblPlayerLevel.Size = new Size(40, 15);
            lblPlayerLevel.TabIndex = 5;
            lblPlayerLevel.Text = "Level: ";
            // 
            // lblPlayerExp
            // 
            lblPlayerExp.AutoSize = true;
            lblPlayerExp.Location = new Point(6, 135);
            lblPlayerExp.Name = "lblPlayerExp";
            lblPlayerExp.Size = new Size(31, 15);
            lblPlayerExp.TabIndex = 4;
            lblPlayerExp.Text = "Exp: ";
            // 
            // lblPlayerAcc
            // 
            lblPlayerAcc.AutoSize = true;
            lblPlayerAcc.Location = new Point(6, 111);
            lblPlayerAcc.Name = "lblPlayerAcc";
            lblPlayerAcc.Size = new Size(62, 15);
            lblPlayerAcc.TabIndex = 3;
            lblPlayerAcc.Text = "Accuracy: ";
            // 
            // lblPlayerSpd
            // 
            lblPlayerSpd.AutoSize = true;
            lblPlayerSpd.Location = new Point(6, 83);
            lblPlayerSpd.Name = "lblPlayerSpd";
            lblPlayerSpd.Size = new Size(45, 15);
            lblPlayerSpd.TabIndex = 2;
            lblPlayerSpd.Text = "Speed: ";
            // 
            // lblPlayerDmg
            // 
            lblPlayerDmg.AutoSize = true;
            lblPlayerDmg.Location = new Point(93, 83);
            lblPlayerDmg.Name = "lblPlayerDmg";
            lblPlayerDmg.Size = new Size(57, 15);
            lblPlayerDmg.TabIndex = 1;
            lblPlayerDmg.Text = "Damage: ";
            // 
            // butWalk
            // 
            butWalk.BackColor = Color.Moccasin;
            butWalk.BackgroundImage = (Image)resources.GetObject("butWalk.BackgroundImage");
            butWalk.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butWalk.ForeColor = Color.FromArgb(192, 255, 255);
            butWalk.Location = new Point(263, 242);
            butWalk.Name = "butWalk";
            butWalk.Size = new Size(133, 51);
            butWalk.TabIndex = 1;
            butWalk.Text = "&Walk forward";
            butWalk.UseVisualStyleBackColor = false;
            butWalk.Click += butWalk_Click;
            // 
            // pBoxPlayerIcon
            // 
            pBoxPlayerIcon.BackColor = Color.Transparent;
            pBoxPlayerIcon.Location = new Point(57, 280);
            pBoxPlayerIcon.Name = "pBoxPlayerIcon";
            pBoxPlayerIcon.Size = new Size(163, 144);
            pBoxPlayerIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxPlayerIcon.TabIndex = 2;
            pBoxPlayerIcon.TabStop = false;
            // 
            // butHeal
            // 
            butHeal.BackColor = Color.Moccasin;
            butHeal.BackgroundImage = (Image)resources.GetObject("butHeal.BackgroundImage");
            butHeal.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butHeal.ForeColor = Color.FromArgb(192, 255, 255);
            butHeal.Location = new Point(263, 312);
            butHeal.Name = "butHeal";
            butHeal.Size = new Size(133, 51);
            butHeal.TabIndex = 3;
            butHeal.Text = "&Heal";
            butHeal.UseVisualStyleBackColor = false;
            butHeal.Click += butHeal_Click;
            // 
            // butExit
            // 
            butExit.BackColor = Color.Moccasin;
            butExit.BackgroundImage = (Image)resources.GetObject("butExit.BackgroundImage");
            butExit.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butExit.ForeColor = Color.FromArgb(192, 255, 255);
            butExit.Location = new Point(263, 385);
            butExit.Name = "butExit";
            butExit.Size = new Size(133, 51);
            butExit.TabIndex = 4;
            butExit.Text = "&Exit";
            butExit.UseVisualStyleBackColor = false;
            butExit.Click += butExit_Click;
            // 
            // pBoxMob
            // 
            pBoxMob.BackColor = Color.Transparent;
            pBoxMob.Location = new Point(815, 292);
            pBoxMob.Name = "pBoxMob";
            pBoxMob.Size = new Size(163, 144);
            pBoxMob.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxMob.TabIndex = 7;
            pBoxMob.TabStop = false;
            // 
            // grpBoxMobStats
            // 
            grpBoxMobStats.Controls.Add(lblMobCurrentHP);
            grpBoxMobStats.Controls.Add(lblMobAcc);
            grpBoxMobStats.Controls.Add(pBarMobHP);
            grpBoxMobStats.Controls.Add(lblMobSpd);
            grpBoxMobStats.Controls.Add(lblMobDmg);
            grpBoxMobStats.Controls.Add(lblMobHealth);
            grpBoxMobStats.Location = new Point(776, 35);
            grpBoxMobStats.Name = "grpBoxMobStats";
            grpBoxMobStats.Size = new Size(202, 162);
            grpBoxMobStats.TabIndex = 7;
            grpBoxMobStats.TabStop = false;
            grpBoxMobStats.Text = "Enemy Stats";
            grpBoxMobStats.Visible = false;
            // 
            // lblMobCurrentHP
            // 
            lblMobCurrentHP.AutoSize = true;
            lblMobCurrentHP.BackColor = Color.Transparent;
            lblMobCurrentHP.Location = new Point(85, 29);
            lblMobCurrentHP.Name = "lblMobCurrentHP";
            lblMobCurrentHP.Size = new Size(29, 15);
            lblMobCurrentHP.TabIndex = 18;
            lblMobCurrentHP.Text = "N/A";
            // 
            // lblMobAcc
            // 
            lblMobAcc.AutoSize = true;
            lblMobAcc.Location = new Point(6, 111);
            lblMobAcc.Name = "lblMobAcc";
            lblMobAcc.Size = new Size(62, 15);
            lblMobAcc.TabIndex = 3;
            lblMobAcc.Text = "Accuracy: ";
            // 
            // pBarMobHP
            // 
            pBarMobHP.ForeColor = Color.Red;
            pBarMobHP.Location = new Point(60, 25);
            pBarMobHP.Name = "pBarMobHP";
            pBarMobHP.Size = new Size(100, 23);
            pBarMobHP.TabIndex = 19;
            // 
            // lblMobSpd
            // 
            lblMobSpd.AutoSize = true;
            lblMobSpd.Location = new Point(6, 83);
            lblMobSpd.Name = "lblMobSpd";
            lblMobSpd.Size = new Size(45, 15);
            lblMobSpd.TabIndex = 2;
            lblMobSpd.Text = "Speed: ";
            // 
            // lblMobDmg
            // 
            lblMobDmg.AutoSize = true;
            lblMobDmg.Location = new Point(6, 57);
            lblMobDmg.Name = "lblMobDmg";
            lblMobDmg.Size = new Size(57, 15);
            lblMobDmg.TabIndex = 1;
            lblMobDmg.Text = "Damage: ";
            // 
            // lblMobHealth
            // 
            lblMobHealth.AutoSize = true;
            lblMobHealth.Location = new Point(6, 29);
            lblMobHealth.Name = "lblMobHealth";
            lblMobHealth.Size = new Size(48, 15);
            lblMobHealth.TabIndex = 0;
            lblMobHealth.Text = "Health: ";
            // 
            // butAttack
            // 
            butAttack.BackColor = Color.Moccasin;
            butAttack.BackgroundImage = (Image)resources.GetObject("butAttack.BackgroundImage");
            butAttack.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butAttack.ForeColor = Color.FromArgb(192, 255, 255);
            butAttack.Location = new Point(263, 242);
            butAttack.Name = "butAttack";
            butAttack.Size = new Size(133, 51);
            butAttack.TabIndex = 8;
            butAttack.Text = "&Attack";
            butAttack.UseVisualStyleBackColor = false;
            butAttack.Visible = false;
            butAttack.Click += butAttack_Click;
            // 
            // cBoxLevelOpts
            // 
            cBoxLevelOpts.FormattingEnabled = true;
            cBoxLevelOpts.Items.AddRange(new object[] { "Health", "Damage", "Speed" });
            cBoxLevelOpts.Location = new Point(265, 41);
            cBoxLevelOpts.Name = "cBoxLevelOpts";
            cBoxLevelOpts.Size = new Size(121, 23);
            cBoxLevelOpts.TabIndex = 9;
            // 
            // butLevelUp
            // 
            butLevelUp.BackColor = Color.Moccasin;
            butLevelUp.BackgroundImage = (Image)resources.GetObject("butLevelUp.BackgroundImage");
            butLevelUp.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butLevelUp.ForeColor = Color.FromArgb(192, 255, 255);
            butLevelUp.Location = new Point(265, 0);
            butLevelUp.Name = "butLevelUp";
            butLevelUp.Size = new Size(111, 31);
            butLevelUp.TabIndex = 10;
            butLevelUp.Text = "&Level Up";
            butLevelUp.UseVisualStyleBackColor = false;
            butLevelUp.Click += butLevelUp_Click;
            // 
            // butBlock
            // 
            butBlock.BackColor = Color.Moccasin;
            butBlock.BackgroundImage = (Image)resources.GetObject("butBlock.BackgroundImage");
            butBlock.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butBlock.ForeColor = Color.FromArgb(192, 255, 255);
            butBlock.Location = new Point(263, 385);
            butBlock.Name = "butBlock";
            butBlock.Size = new Size(133, 51);
            butBlock.TabIndex = 11;
            butBlock.Text = "&Block";
            butBlock.UseVisualStyleBackColor = false;
            butBlock.Visible = false;
            butBlock.Click += butBlock_Click;
            // 
            // butRun
            // 
            butRun.BackColor = Color.Moccasin;
            butRun.BackgroundImage = (Image)resources.GetObject("butRun.BackgroundImage");
            butRun.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butRun.ForeColor = Color.FromArgb(192, 255, 255);
            butRun.Location = new Point(263, 170);
            butRun.Name = "butRun";
            butRun.Size = new Size(133, 51);
            butRun.TabIndex = 12;
            butRun.Text = "&Run";
            butRun.UseVisualStyleBackColor = false;
            butRun.Visible = false;
            butRun.Click += butRun_Click;
            // 
            // pBoxHurt
            // 
            pBoxHurt.BackColor = Color.Transparent;
            pBoxHurt.Image = Properties.Resources.hurtpic;
            pBoxHurt.Location = new Point(51, 280);
            pBoxHurt.Name = "pBoxHurt";
            pBoxHurt.Size = new Size(163, 144);
            pBoxHurt.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxHurt.TabIndex = 13;
            pBoxHurt.TabStop = false;
            pBoxHurt.Visible = false;
            // 
            // pBoxHurtMob
            // 
            pBoxHurtMob.BackColor = Color.Transparent;
            pBoxHurtMob.Image = Properties.Resources.hurtpic;
            pBoxHurtMob.Location = new Point(815, 292);
            pBoxHurtMob.Name = "pBoxHurtMob";
            pBoxHurtMob.Size = new Size(163, 144);
            pBoxHurtMob.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxHurtMob.TabIndex = 14;
            pBoxHurtMob.TabStop = false;
            pBoxHurtMob.Visible = false;
            // 
            // lstBoxLog
            // 
            lstBoxLog.BackColor = Color.Black;
            lstBoxLog.ForeColor = Color.White;
            lstBoxLog.FormattingEnabled = true;
            lstBoxLog.HorizontalScrollbar = true;
            lstBoxLog.ItemHeight = 15;
            lstBoxLog.Location = new Point(392, 0);
            lstBoxLog.Name = "lstBoxLog";
            lstBoxLog.Size = new Size(378, 79);
            lstBoxLog.TabIndex = 15;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(265, 83);
            lblMessage.MaximumSize = new Size(600, 0);
            lblMessage.MinimumSize = new Size(378, 30);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(505, 30);
            lblMessage.TabIndex = 18;
            // 
            // butContinue
            // 
            butContinue.BackColor = Color.Moccasin;
            butContinue.BackgroundImage = (Image)resources.GetObject("butContinue.BackgroundImage");
            butContinue.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butContinue.ForeColor = Color.FromArgb(192, 255, 255);
            butContinue.Location = new Point(434, 208);
            butContinue.Name = "butContinue";
            butContinue.Size = new Size(133, 51);
            butContinue.TabIndex = 19;
            butContinue.Text = "&Continue";
            butContinue.UseVisualStyleBackColor = false;
            butContinue.Visible = false;
            butContinue.Click += butContinue_Click_1;
            // 
            // pBoxDeath
            // 
            pBoxDeath.BackColor = Color.Transparent;
            pBoxDeath.ErrorImage = null;
            pBoxDeath.InitialImage = null;
            pBoxDeath.Location = new Point(3, 85);
            pBoxDeath.Name = "pBoxDeath";
            pBoxDeath.Size = new Size(988, 197);
            pBoxDeath.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxDeath.TabIndex = 20;
            pBoxDeath.TabStop = false;
            pBoxDeath.Visible = false;
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 450);
            Controls.Add(butContinue);
            Controls.Add(lblMessage);
            Controls.Add(lstBoxLog);
            Controls.Add(pBoxHurtMob);
            Controls.Add(pBoxHurt);
            Controls.Add(butRun);
            Controls.Add(butBlock);
            Controls.Add(butLevelUp);
            Controls.Add(cBoxLevelOpts);
            Controls.Add(butAttack);
            Controls.Add(grpBoxMobStats);
            Controls.Add(pBoxMob);
            Controls.Add(butExit);
            Controls.Add(butHeal);
            Controls.Add(pBoxPlayerIcon);
            Controls.Add(butWalk);
            Controls.Add(grpBoxPlayerStats);
            Controls.Add(pBoxDeath);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += frmGame_Load;
            grpBoxPlayerStats.ResumeLayout(false);
            grpBoxPlayerStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxPlayerIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMob).EndInit();
            grpBoxMobStats.ResumeLayout(false);
            grpBoxMobStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxHurt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxHurtMob).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDeath).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxPlayerStats;
        private Label lblPlayerExp;
        private Label lblPlayerAcc;
        private Label lblPlayerSpd;
        private Label lblPlayerDmg;
        private Label lblPlayerHealth;
        private Label lblPlayerClass;
        private Label lblPlayerLevel;
        private Button butWalk;
        private PictureBox pBoxPlayerIcon;
        private Button butHeal;
        private Button butExit;
        private PictureBox pBoxMob;
        private GroupBox grpBoxMobStats;
        private Label lblMobAcc;
        private Label lblMobSpd;
        private Label lblMobDmg;
        private Label lblMobHealth;
        private Button butAttack;
        private ComboBox cBoxLevelOpts;
        private Button butLevelUp;
        private Button butBlock;
        private ProgressBar pBarHealth;
        private Label lblHealth;
        private Label lblJuiceAmt;
        private ProgressBar pBarJuice;
        private Label lblJuice;
        private Label lblDefense;
        private Button butRun;
        private PictureBox pBoxHurt;
        private PictureBox pBoxHurtMob;
        private ListBox lstBoxLog;
        private Label lblMessage;
        private Button butContinue;
        private Label lblMobCurrentHP;
        private ProgressBar pBarMobHP;
        private PictureBox pBoxDeath;
    }
}