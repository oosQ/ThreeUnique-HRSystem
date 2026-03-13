namespace ProjectDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RecruitmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecruitmenButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FiredButton = new System.Windows.Forms.Button();
            this.PromotionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceToolStripMenuItem,
            this.desingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promotionToolStripMenuItem,
            this.toolStripSeparator1,
            this.fireEmployeeToolStripMenuItem,
            this.toolStripSeparator2,
            this.updateInformationToolStripMenuItem,
            this.toolStripSeparator3,
            this.RecruitmentToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.serviceToolStripMenuItem.Text = "Se&rvices";
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.promotionToolStripMenuItem.Text = "&Promotion";
            this.promotionToolStripMenuItem.Click += new System.EventHandler(this.promotionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // fireEmployeeToolStripMenuItem
            // 
            this.fireEmployeeToolStripMenuItem.Name = "fireEmployeeToolStripMenuItem";
            this.fireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.fireEmployeeToolStripMenuItem.Text = "Fire &Employee";
            this.fireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.fireEmployeeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // updateInformationToolStripMenuItem
            // 
            this.updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            this.updateInformationToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.updateInformationToolStripMenuItem.Text = "&Update Information";
            this.updateInformationToolStripMenuItem.Click += new System.EventHandler(this.updateInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // RecruitmentToolStripMenuItem
            // 
            this.RecruitmentToolStripMenuItem.Name = "RecruitmentToolStripMenuItem";
            this.RecruitmentToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.RecruitmentToolStripMenuItem.Text = "&Recruitment";
            this.RecruitmentToolStripMenuItem.Click += new System.EventHandler(this.RecruitmentToolStripMenuItem_Click);
            // 
            // desingToolStripMenuItem
            // 
            this.desingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackColor,
            this.changeFont});
            this.desingToolStripMenuItem.Name = "desingToolStripMenuItem";
            this.desingToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.desingToolStripMenuItem.Text = "De&sing";
            // 
            // changeBackColor
            // 
            this.changeBackColor.Name = "changeBackColor";
            this.changeBackColor.Size = new System.Drawing.Size(213, 26);
            this.changeBackColor.Text = "&Change BackColor";
            this.changeBackColor.Click += new System.EventHandler(this.changeBackColor_Click);
            // 
            // changeFont
            // 
            this.changeFont.Name = "changeFont";
            this.changeFont.Size = new System.Drawing.Size(213, 26);
            this.changeFont.Text = "Change &Font";
            this.changeFont.Click += new System.EventHandler(this.changeFont_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Hel&p";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(313, 81);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(548, 96);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "ThreeUniqueHRMS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RecruitmenButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.FiredButton);
            this.groupBox1.Controls.Add(this.PromotionButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(82, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(987, 288);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Service :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(752, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Recruitment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fire Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Promotion";
            // 
            // RecruitmenButton
            // 
            this.RecruitmenButton.BackgroundImage = global::ProjectDemo.Properties.Resources.Recruitment_employee;
            this.RecruitmenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecruitmenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecruitmenButton.Location = new System.Drawing.Point(737, 55);
            this.RecruitmenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecruitmenButton.Name = "RecruitmenButton";
            this.RecruitmenButton.Size = new System.Drawing.Size(177, 153);
            this.RecruitmenButton.TabIndex = 3;
            this.RecruitmenButton.UseVisualStyleBackColor = true;
            this.RecruitmenButton.Click += new System.EventHandler(this.RecruitmenButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImage = global::ProjectDemo.Properties.Resources.Update;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Location = new System.Drawing.Point(509, 55);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(177, 153);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FiredButton
            // 
            this.FiredButton.BackgroundImage = global::ProjectDemo.Properties.Resources.Fired;
            this.FiredButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiredButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiredButton.Location = new System.Drawing.Point(265, 55);
            this.FiredButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FiredButton.Name = "FiredButton";
            this.FiredButton.Size = new System.Drawing.Size(177, 153);
            this.FiredButton.TabIndex = 1;
            this.FiredButton.UseVisualStyleBackColor = true;
            this.FiredButton.Click += new System.EventHandler(this.FiredButton_Click);
            // 
            // PromotionButton
            // 
            this.PromotionButton.BackgroundImage = global::ProjectDemo.Properties.Resources.Promition;
            this.PromotionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PromotionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PromotionButton.Location = new System.Drawing.Point(50, 55);
            this.PromotionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PromotionButton.Name = "PromotionButton";
            this.PromotionButton.Size = new System.Drawing.Size(177, 153);
            this.PromotionButton.TabIndex = 0;
            this.PromotionButton.UseVisualStyleBackColor = true;
            this.PromotionButton.Click += new System.EventHandler(this.PromotionButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Location = new System.Drawing.Point(335, 535);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 107);
            this.panel1.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CloseButton.Location = new System.Drawing.Point(255, 23);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(177, 65);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.AboutButton.Location = new System.Drawing.Point(52, 23);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(163, 65);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "ThreeUnique";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDemo.Properties.Resources.Image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Picture\r\n");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1138, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem desingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem changeBackColor;
        private System.Windows.Forms.ToolStripMenuItem changeFont;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.FontDialog FontDialog;
        public System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem RecruitmentToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Button RecruitmenButton;
        public System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.Button FiredButton;
        public System.Windows.Forms.Button PromotionButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

