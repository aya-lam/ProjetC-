namespace DataSearcher
{
    partial class PlayerInformationUserControl
    {
      
        private System.ComponentModel.IContainer components = null;

     
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

  
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerInformationUserControl));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.competitionClassLabel = new System.Windows.Forms.Label();
            this.countryForSportLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(377, 138);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(265, 256);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(114, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Player Name:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(3, 138);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(118, 23);
            this.dateOfBirthLabel.TabIndex = 2;
            this.dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenshipLabel.Location = new System.Drawing.Point(3, 246);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(104, 23);
            this.citizenshipLabel.TabIndex = 3;
            this.citizenshipLabel.Text = "Citizenship: ";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.Location = new System.Drawing.Point(3, 365);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(59, 23);
            this.teamLabel.TabIndex = 4;
            this.teamLabel.Text = "Team:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(669, 38);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(82, 23);
            this.positionLabel.TabIndex = 5;
            this.positionLabel.Text = "Position: ";
            // 
            // competitionClassLabel
            // 
            this.competitionClassLabel.AutoSize = true;
            this.competitionClassLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionClassLabel.Location = new System.Drawing.Point(669, 138);
            this.competitionClassLabel.Name = "competitionClassLabel";
            this.competitionClassLabel.Size = new System.Drawing.Size(156, 23);
            this.competitionClassLabel.TabIndex = 6;
            this.competitionClassLabel.Text = "Competition Class:";
            // 
            // countryForSportLabel
            // 
            this.countryForSportLabel.AutoSize = true;
            this.countryForSportLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryForSportLabel.Location = new System.Drawing.Point(669, 246);
            this.countryForSportLabel.Name = "countryForSportLabel";
            this.countryForSportLabel.Size = new System.Drawing.Size(155, 23);
            this.countryForSportLabel.TabIndex = 7;
            this.countryForSportLabel.Text = "Country For Sport:";
            this.countryForSportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(669, 371);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(89, 23);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "Player ID: ";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.countryForSportLabel);
            this.Controls.Add(this.competitionClassLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.citizenshipLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "PlayerInformationUserControl";
            this.Size = new System.Drawing.Size(1011, 538);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label citizenshipLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label competitionClassLabel;
        private System.Windows.Forms.Label countryForSportLabel;
        private System.Windows.Forms.Label idLabel;
    }
}
