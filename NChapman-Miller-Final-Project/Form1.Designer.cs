namespace NChapman_Miller_Final_Project
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            butPlayGame = new Button();
            butExit = new Button();
            lblTitle = new Label();
            grpBoxClass = new GroupBox();
            radButWizard = new RadioButton();
            radButBowman = new RadioButton();
            radButBlob = new RadioButton();
            radButBeserk = new RadioButton();
            radButKnight = new RadioButton();
            butClassInfo = new Button();
            txtBoxPlayerName = new TextBox();
            lblPlayerName = new Label();
            grpBoxClass.SuspendLayout();
            SuspendLayout();
            // 
            // butPlayGame
            // 
            butPlayGame.BackColor = Color.Moccasin;
            butPlayGame.BackgroundImage = (Image)resources.GetObject("butPlayGame.BackgroundImage");
            butPlayGame.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butPlayGame.ForeColor = Color.FromArgb(192, 255, 255);
            butPlayGame.Location = new Point(243, 281);
            butPlayGame.Name = "butPlayGame";
            butPlayGame.Size = new Size(87, 32);
            butPlayGame.TabIndex = 0;
            butPlayGame.Text = "Play Game";
            butPlayGame.UseVisualStyleBackColor = false;
            butPlayGame.Click += butPlayGame_Click;
            // 
            // butExit
            // 
            butExit.BackColor = Color.Moccasin;
            butExit.BackgroundImage = (Image)resources.GetObject("butExit.BackgroundImage");
            butExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butExit.ForeColor = Color.FromArgb(192, 255, 255);
            butExit.Location = new Point(452, 281);
            butExit.Name = "butExit";
            butExit.Size = new Size(87, 32);
            butExit.TabIndex = 1;
            butExit.Text = "Exit";
            butExit.UseVisualStyleBackColor = false;
            butExit.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.RosyBrown;
            lblTitle.BorderStyle = BorderStyle.Fixed3D;
            lblTitle.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(189, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 42);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Battle Path";
            // 
            // grpBoxClass
            // 
            grpBoxClass.BackColor = Color.FromArgb(196, 203, 221);
            grpBoxClass.Controls.Add(radButWizard);
            grpBoxClass.Controls.Add(radButBowman);
            grpBoxClass.Controls.Add(radButBlob);
            grpBoxClass.Controls.Add(radButBeserk);
            grpBoxClass.Controls.Add(radButKnight);
            grpBoxClass.Location = new Point(21, 93);
            grpBoxClass.Name = "grpBoxClass";
            grpBoxClass.Size = new Size(126, 151);
            grpBoxClass.TabIndex = 3;
            grpBoxClass.TabStop = false;
            grpBoxClass.Text = "Character Class";
            // 
            // radButWizard
            // 
            radButWizard.AutoSize = true;
            radButWizard.Location = new Point(6, 122);
            radButWizard.Name = "radButWizard";
            radButWizard.Size = new Size(61, 19);
            radButWizard.TabIndex = 4;
            radButWizard.Text = "Wizard";
            radButWizard.UseVisualStyleBackColor = true;
            // 
            // radButBowman
            // 
            radButBowman.AutoSize = true;
            radButBowman.Location = new Point(6, 97);
            radButBowman.Name = "radButBowman";
            radButBowman.Size = new Size(72, 19);
            radButBowman.TabIndex = 3;
            radButBowman.Text = "Bowman";
            radButBowman.UseVisualStyleBackColor = true;
            // 
            // radButBlob
            // 
            radButBlob.AutoSize = true;
            radButBlob.Location = new Point(6, 72);
            radButBlob.Name = "radButBlob";
            radButBlob.Size = new Size(49, 19);
            radButBlob.TabIndex = 2;
            radButBlob.Text = "Blob";
            radButBlob.UseVisualStyleBackColor = true;
            // 
            // radButBeserk
            // 
            radButBeserk.AutoSize = true;
            radButBeserk.Location = new Point(6, 47);
            radButBeserk.Name = "radButBeserk";
            radButBeserk.Size = new Size(69, 19);
            radButBeserk.TabIndex = 1;
            radButBeserk.Text = "Beserker";
            radButBeserk.UseVisualStyleBackColor = true;
            // 
            // radButKnight
            // 
            radButKnight.AutoSize = true;
            radButKnight.Location = new Point(6, 22);
            radButKnight.Name = "radButKnight";
            radButKnight.Size = new Size(60, 19);
            radButKnight.TabIndex = 0;
            radButKnight.Text = "Knight";
            radButKnight.UseVisualStyleBackColor = true;
            // 
            // butClassInfo
            // 
            butClassInfo.BackColor = Color.Moccasin;
            butClassInfo.BackgroundImage = (Image)resources.GetObject("butClassInfo.BackgroundImage");
            butClassInfo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butClassInfo.ForeColor = Color.FromArgb(192, 255, 255);
            butClassInfo.Location = new Point(21, 281);
            butClassInfo.Name = "butClassInfo";
            butClassInfo.Size = new Size(87, 32);
            butClassInfo.TabIndex = 4;
            butClassInfo.Text = "Class Info";
            butClassInfo.UseVisualStyleBackColor = false;
            butClassInfo.Click += butClassInfo_Click;
            // 
            // txtBoxPlayerName
            // 
            txtBoxPlayerName.Location = new Point(305, 93);
            txtBoxPlayerName.Name = "txtBoxPlayerName";
            txtBoxPlayerName.Size = new Size(100, 23);
            txtBoxPlayerName.TabIndex = 5;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.BackColor = Color.FromArgb(196, 203, 221);
            lblPlayerName.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerName.Location = new Point(189, 93);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(107, 23);
            lblPlayerName.TabIndex = 6;
            lblPlayerName.Text = "Player Name:";
            // 
            // frmMainMenu
            // 
            AcceptButton = butPlayGame;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 227, 190);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = butExit;
            ClientSize = new Size(599, 325);
            Controls.Add(lblPlayerName);
            Controls.Add(txtBoxPlayerName);
            Controls.Add(butClassInfo);
            Controls.Add(grpBoxClass);
            Controls.Add(lblTitle);
            Controls.Add(butExit);
            Controls.Add(butPlayGame);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapman-Miller Game Menu";
            grpBoxClass.ResumeLayout(false);
            grpBoxClass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butPlayGame;
        private Button butExit;
        private Label lblTitle;
        private GroupBox grpBoxClass;
        private RadioButton radButBeserk;
        private RadioButton radButKnight;
        private RadioButton radButBlob;
        private RadioButton radButBowman;
        private RadioButton radButWizard;
        private Button butClassInfo;
        private TextBox txtBoxPlayerName;
        private Label lblPlayerName;
    }
}
