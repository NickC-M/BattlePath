namespace NChapman_Miller_Final_Project
{
    partial class Victory_Screen
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
            lblCongrats = new Label();
            gBoxOverview = new GroupBox();
            pBoxClass = new PictureBox();
            lblClass = new Label();
            lblSpeed = new Label();
            lblDmg = new Label();
            lblMaxHp = new Label();
            lblLvl = new Label();
            lblName = new Label();
            butContinue = new Button();
            gBoxOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxClass).BeginInit();
            SuspendLayout();
            // 
            // lblCongrats
            // 
            lblCongrats.AutoSize = true;
            lblCongrats.BackColor = Color.Transparent;
            lblCongrats.Font = new Font("Stencil", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCongrats.ForeColor = Color.Gold;
            lblCongrats.Location = new Point(22, 78);
            lblCongrats.Name = "lblCongrats";
            lblCongrats.Size = new Size(635, 38);
            lblCongrats.TabIndex = 0;
            lblCongrats.Text = "CONGRATS !! YOU SAVED THE CASTLE !!";
            // 
            // gBoxOverview
            // 
            gBoxOverview.BackColor = Color.OldLace;
            gBoxOverview.Controls.Add(pBoxClass);
            gBoxOverview.Controls.Add(lblClass);
            gBoxOverview.Controls.Add(lblSpeed);
            gBoxOverview.Controls.Add(lblDmg);
            gBoxOverview.Controls.Add(lblMaxHp);
            gBoxOverview.Controls.Add(lblLvl);
            gBoxOverview.Controls.Add(lblName);
            gBoxOverview.Location = new Point(36, 199);
            gBoxOverview.Name = "gBoxOverview";
            gBoxOverview.Size = new Size(265, 205);
            gBoxOverview.TabIndex = 1;
            gBoxOverview.TabStop = false;
            gBoxOverview.Text = "Overview";
            // 
            // pBoxClass
            // 
            pBoxClass.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxClass.Location = new Point(125, 51);
            pBoxClass.Name = "pBoxClass";
            pBoxClass.Size = new Size(134, 123);
            pBoxClass.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxClass.TabIndex = 6;
            pBoxClass.TabStop = false;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(125, 19);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(34, 15);
            lblClass.TabIndex = 5;
            lblClass.Text = "Class";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(6, 150);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(38, 15);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "speed";
            // 
            // lblDmg
            // 
            lblDmg.AutoSize = true;
            lblDmg.Location = new Point(6, 116);
            lblDmg.Name = "lblDmg";
            lblDmg.Size = new Size(33, 15);
            lblDmg.TabIndex = 3;
            lblDmg.Text = "Dmg";
            // 
            // lblMaxHp
            // 
            lblMaxHp.AutoSize = true;
            lblMaxHp.Location = new Point(6, 86);
            lblMaxHp.Name = "lblMaxHp";
            lblMaxHp.Size = new Size(45, 15);
            lblMaxHp.TabIndex = 2;
            lblMaxHp.Text = "maxHp";
            // 
            // lblLvl
            // 
            lblLvl.AutoSize = true;
            lblLvl.Location = new Point(6, 51);
            lblLvl.Name = "lblLvl";
            lblLvl.Size = new Size(34, 15);
            lblLvl.TabIndex = 1;
            lblLvl.Text = "Level";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 0;
            lblName.Text = "name";
            // 
            // butContinue
            // 
            butContinue.BackColor = Color.OldLace;
            butContinue.Location = new Point(255, 489);
            butContinue.Name = "butContinue";
            butContinue.Size = new Size(136, 44);
            butContinue.TabIndex = 2;
            butContinue.Text = "&Continue";
            butContinue.UseVisualStyleBackColor = false;
            butContinue.Click += butContinue_Click;
            // 
            // Victory_Screen
            // 
            AcceptButton = butContinue;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.castlevic;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = butContinue;
            ClientSize = new Size(708, 635);
            Controls.Add(butContinue);
            Controls.Add(gBoxOverview);
            Controls.Add(lblCongrats);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Victory_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Victory_Screen";
            Load += Victory_Screen_Load;
            gBoxOverview.ResumeLayout(false);
            gBoxOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCongrats;
        private GroupBox gBoxOverview;
        private PictureBox pBoxClass;
        private Label lblClass;
        private Label lblSpeed;
        private Label lblDmg;
        private Label lblMaxHp;
        private Label lblLvl;
        private Label lblName;
        private Button butContinue;
    }
}