namespace ProjectDemo
{
    partial class LoginForm
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
            this.OfflineLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasscheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.threeUniqueDataBaseDataSet = new ProjectDemo.ThreeUniqueDataBaseDataSet();
            this.adminRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminRegTableAdapter = new ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters.adminRegTableAdapter();
            this.tableAdapterManager = new ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.threeUniqueDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OfflineLabel
            // 
            this.OfflineLabel.AutoSize = true;
            this.OfflineLabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.OfflineLabel.Location = new System.Drawing.Point(700, 378);
            this.OfflineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OfflineLabel.Name = "OfflineLabel";
            this.OfflineLabel.Size = new System.Drawing.Size(103, 36);
            this.OfflineLabel.TabIndex = 4;
            this.OfflineLabel.TabStop = true;
            this.OfflineLabel.Text = "Offline";
            this.OfflineLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OfflineLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 32.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 94);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login To System";
            // 
            // UserTextBox
            // 
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextBox.Font = new System.Drawing.Font("Tahoma", 15F);
            this.UserTextBox.Location = new System.Drawing.Point(415, 186);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(256, 38);
            this.UserTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label2.Location = new System.Drawing.Point(239, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label3.Location = new System.Drawing.Point(247, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password :";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(357, 373);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(178, 54);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasscheckBox
            // 
            this.PasscheckBox.AutoSize = true;
            this.PasscheckBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.PasscheckBox.Location = new System.Drawing.Point(693, 292);
            this.PasscheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasscheckBox.Name = "PasscheckBox";
            this.PasscheckBox.Size = new System.Drawing.Size(185, 31);
            this.PasscheckBox.TabIndex = 2;
            this.PasscheckBox.Text = "Show Password";
            this.PasscheckBox.UseVisualStyleBackColor = true;
            this.PasscheckBox.CheckedChanged += new System.EventHandler(this.PasscheckBox_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Tahoma", 15F);
            this.PasswordTextBox.Location = new System.Drawing.Point(415, 286);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(256, 38);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // threeUniqueDataBaseDataSet
            // 
            this.threeUniqueDataBaseDataSet.DataSetName = "ThreeUniqueDataBaseDataSet";
            this.threeUniqueDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminRegBindingSource
            // 
            this.adminRegBindingSource.DataMember = "adminReg";
            this.adminRegBindingSource.DataSource = this.threeUniqueDataBaseDataSet;
            // 
            // adminRegTableAdapter
            // 
            this.adminRegTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminRegTableAdapter = this.adminRegTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDemo.Properties.Resources.Lock;
            this.pictureBox1.Location = new System.Drawing.Point(23, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(931, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasscheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.OfflineLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threeUniqueDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel OfflineLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox PasscheckBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private ThreeUniqueDataBaseDataSet threeUniqueDataBaseDataSet;
        private System.Windows.Forms.BindingSource adminRegBindingSource;
        private ThreeUniqueDataBaseDataSetTableAdapters.adminRegTableAdapter adminRegTableAdapter;
        private ThreeUniqueDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}