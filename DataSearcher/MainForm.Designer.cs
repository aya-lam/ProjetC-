namespace DataSearcher
{
    partial class DataSearcher
    {
     
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

      
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSearcher));
            this.searchBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.searchBarPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBarPanel
            // 
            this.searchBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.searchBarPanel.Controls.Add(this.label1);
            this.searchBarPanel.Controls.Add(this.closeLabel);
            this.searchBarPanel.Controls.Add(this.searchByLabel);
            this.searchBarPanel.Controls.Add(this.filterBox);
            this.searchBarPanel.Controls.Add(this.searchBtn);
            this.searchBarPanel.Controls.Add(this.searchBar);
            this.searchBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBarPanel.Location = new System.Drawing.Point(0, 0);
            this.searchBarPanel.Name = "searchBarPanel";
            this.searchBarPanel.Size = new System.Drawing.Size(1011, 144);
            this.searchBarPanel.TabIndex = 0;
            this.searchBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchBarPanel_MouseDown);
            this.searchBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchBarPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "NBA Player Info Searcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeLabel.Location = new System.Drawing.Point(977, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 26);
            this.closeLabel.TabIndex = 3;
            this.closeLabel.Text = "x";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseLabel_MouseClick);
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchByLabel.Location = new System.Drawing.Point(64, 59);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(103, 26);
            this.searchByLabel.TabIndex = 3;
            this.searchByLabel.Text = "Search By:";
            this.searchByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterBox
            // 
            this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "--Select--",
            "Name",
            "Id"});
            this.filterBox.Location = new System.Drawing.Point(173, 56);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(121, 31);
            this.filterBox.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(716, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(172, 31);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search Player";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtnClick);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(300, 56);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(410, 31);
            this.searchBar.TabIndex = 0;
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(87)))));
            this.informationPanel.Controls.Add(this.infoLabel);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationPanel.Location = new System.Drawing.Point(0, 144);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(1011, 538);
            this.informationPanel.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoLabel.Location = new System.Drawing.Point(315, 215);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(351, 33);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "<Information will appear here>";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(172)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1011, 682);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.searchBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataSearcher";
            this.Text = "Data Searcher";
            this.searchBarPanel.ResumeLayout(false);
            this.searchBarPanel.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchBarPanel;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
    }
}

