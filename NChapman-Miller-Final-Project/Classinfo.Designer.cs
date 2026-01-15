namespace NChapman_Miller_Final_Project
{
    partial class frmClassInfo
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
            lblClassInfo = new Label();
            pBoxPlayerIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxPlayerIcon).BeginInit();
            SuspendLayout();
            // 
            // lblClassInfo
            // 
            lblClassInfo.AutoSize = true;
            lblClassInfo.Location = new Point(12, 29);
            lblClassInfo.Name = "lblClassInfo";
            lblClassInfo.Size = new Size(40, 15);
            lblClassInfo.TabIndex = 0;
            lblClassInfo.Text = "Class: ";
            // 
            // pBoxPlayerIcon
            // 
            pBoxPlayerIcon.BackColor = Color.Transparent;
            pBoxPlayerIcon.Location = new Point(266, 29);
            pBoxPlayerIcon.Name = "pBoxPlayerIcon";
            pBoxPlayerIcon.Size = new Size(138, 128);
            pBoxPlayerIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxPlayerIcon.TabIndex = 4;
            pBoxPlayerIcon.TabStop = false;
            // 
            // frmClassInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 198);
            Controls.Add(pBoxPlayerIcon);
            Controls.Add(lblClassInfo);
            Name = "frmClassInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Info";
            ((System.ComponentModel.ISupportInitialize)pBoxPlayerIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClassInfo;
        private PictureBox pBoxPlayerIcon;
    }
}