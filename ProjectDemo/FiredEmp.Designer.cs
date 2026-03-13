namespace ProjectDemo
{
    partial class FiredEmp
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
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label hIREDATELabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            this.SureCheckBox = new System.Windows.Forms.CheckBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RequiredLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.threeUniqueDataBaseDataSet = new ProjectDemo.ThreeUniqueDataBaseDataSet();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.Showbutton = new System.Windows.Forms.Button();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.hIREDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guidelineToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters.TableAdapterManager();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            empIDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            hIREDATELabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeUniqueDataBaseDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(16, 58);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(69, 19);
            empIDLabel.TabIndex = 0;
            empIDLabel.Text = "Emp ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(16, 91);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(91, 19);
            first_NameLabel.TabIndex = 2;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(16, 124);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(89, 19);
            last_NameLabel.TabIndex = 4;
            last_NameLabel.Text = "Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(62, 157);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(43, 19);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(67, 190);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(40, 19);
            jobLabel.TabIndex = 8;
            jobLabel.Text = "Job:";
            // 
            // hIREDATELabel
            // 
            hIREDATELabel.AutoSize = true;
            hIREDATELabel.Location = new System.Drawing.Point(16, 224);
            hIREDATELabel.Name = "hIREDATELabel";
            hIREDATELabel.Size = new System.Drawing.Size(92, 19);
            hIREDATELabel.TabIndex = 10;
            hIREDATELabel.Text = "HIREDATE:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(47, 256);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(58, 19);
            salaryLabel.TabIndex = 12;
            salaryLabel.Text = "Salary:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(58, 290);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(47, 19);
            dOBLabel.TabIndex = 14;
            dOBLabel.Text = "DOB:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(360, 58);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 19);
            phoneLabel.TabIndex = 22;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(365, 96);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(54, 19);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(347, 136);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 19);
            addressLabel.TabIndex = 24;
            addressLabel.Text = "Address:";
            // 
            // SureCheckBox
            // 
            this.SureCheckBox.AutoSize = true;
            this.SureCheckBox.Location = new System.Drawing.Point(392, 165);
            this.SureCheckBox.Name = "SureCheckBox";
            this.SureCheckBox.Size = new System.Drawing.Size(136, 23);
            this.SureCheckBox.TabIndex = 3;
            this.SureCheckBox.Text = "Are You Sure ?";
            this.SureCheckBox.UseVisualStyleBackColor = true;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentTextBox.Location = new System.Drawing.Point(149, 166);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(181, 27);
            this.CommentTextBox.TabIndex = 2;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(149, 103);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(181, 27);
            this.EmployeeIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Employee ID : ";
            // 
            // ReasonComboBox
            // 
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Items.AddRange(new object[] {
            "poor performance",
            "unethical behavior",
            "violation of company policies",
            "absence more than once"});
            this.ReasonComboBox.Location = new System.Drawing.Point(149, 44);
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.Size = new System.Drawing.Size(270, 27);
            this.ReasonComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reasons :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RequiredLabel);
            this.groupBox3.Controls.Add(this.SureCheckBox);
            this.groupBox3.Controls.Add(this.CommentTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.EmployeeIdTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ReasonComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.RemoveButton);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 239);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fired Employee :";
            // 
            // RequiredLabel
            // 
            this.RequiredLabel.AutoSize = true;
            this.RequiredLabel.ForeColor = System.Drawing.Color.Red;
            this.RequiredLabel.Location = new System.Drawing.Point(425, 47);
            this.RequiredLabel.Name = "RequiredLabel";
            this.RequiredLabel.Size = new System.Drawing.Size(89, 19);
            this.RequiredLabel.TabIndex = 27;
            this.RequiredLabel.Text = "(Required) ";
            this.RequiredLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Comment :";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.RemoveButton.Location = new System.Drawing.Point(402, 103);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 43);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(addressLabel);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(phoneLabel);
            this.groupBox2.Controls.Add(this.phoneTextBox);
            this.groupBox2.Controls.Add(this.Showbutton);
            this.groupBox2.Controls.Add(empIDLabel);
            this.groupBox2.Controls.Add(this.empIDTextBox);
            this.groupBox2.Controls.Add(first_NameLabel);
            this.groupBox2.Controls.Add(this.first_NameTextBox);
            this.groupBox2.Controls.Add(last_NameLabel);
            this.groupBox2.Controls.Add(this.last_NameTextBox);
            this.groupBox2.Controls.Add(ageLabel);
            this.groupBox2.Controls.Add(this.ageTextBox);
            this.groupBox2.Controls.Add(jobLabel);
            this.groupBox2.Controls.Add(this.jobTextBox);
            this.groupBox2.Controls.Add(hIREDATELabel);
            this.groupBox2.Controls.Add(this.hIREDATEDateTimePicker);
            this.groupBox2.Controls.Add(salaryLabel);
            this.groupBox2.Controls.Add(this.salaryTextBox);
            this.groupBox2.Controls.Add(dOBLabel);
            this.groupBox2.Controls.Add(this.dOBDateTimePicker);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 344);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Details :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(425, 133);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(168, 27);
            this.addressTextBox.TabIndex = 25;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.threeUniqueDataBaseDataSet;
            // 
            // threeUniqueDataBaseDataSet
            // 
            this.threeUniqueDataBaseDataSet.DataSetName = "ThreeUniqueDataBaseDataSet";
            this.threeUniqueDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(425, 93);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 27);
            this.emailTextBox.TabIndex = 24;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(425, 55);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(168, 27);
            this.phoneTextBox.TabIndex = 23;
            // 
            // Showbutton
            // 
            this.Showbutton.BackColor = System.Drawing.Color.Transparent;
            this.Showbutton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Showbutton.Location = new System.Drawing.Point(425, 224);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(85, 65);
            this.Showbutton.TabIndex = 0;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = false;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empIDTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.empIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "EmpID", true));
            this.empIDTextBox.Location = new System.Drawing.Point(114, 55);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(200, 27);
            this.empIDTextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // changeBackColorToolStripMenuItem
            // 
            this.changeBackColorToolStripMenuItem.Name = "changeBackColorToolStripMenuItem";
            this.changeBackColorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeBackColorToolStripMenuItem.Text = "Change BackColor";
            this.changeBackColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackColorToolStripMenuItem_Click);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(114, 88);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(200, 27);
            this.first_NameTextBox.TabIndex = 3;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(114, 121);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(200, 27);
            this.last_NameTextBox.TabIndex = 5;
            // 
            // ageTextBox
            // 
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(114, 154);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 27);
            this.ageTextBox.TabIndex = 7;
            // 
            // jobTextBox
            // 
            this.jobTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Job", true));
            this.jobTextBox.Location = new System.Drawing.Point(114, 187);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(200, 27);
            this.jobTextBox.TabIndex = 9;
            // 
            // hIREDATEDateTimePicker
            // 
            this.hIREDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource1, "HIREDATE", true));
            this.hIREDATEDateTimePicker.Location = new System.Drawing.Point(114, 220);
            this.hIREDATEDateTimePicker.Name = "hIREDATEDateTimePicker";
            this.hIREDATEDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.hIREDATEDateTimePicker.TabIndex = 11;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource1, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(114, 253);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 27);
            this.salaryTextBox.TabIndex = 13;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource1, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(114, 286);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dOBDateTimePicker.TabIndex = 15;
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PreviousButton.Location = new System.Drawing.Point(23, 166);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(126, 43);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "Previous Row";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.NextButton.Location = new System.Drawing.Point(23, 100);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(126, 43);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next Row";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FirstButton.Location = new System.Drawing.Point(23, 39);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(126, 43);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "First Row";
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.BackColor = System.Drawing.Color.Transparent;
            this.LastButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LastButton.Location = new System.Drawing.Point(23, 224);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(126, 43);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = "Last Row";
            this.LastButton.UseVisualStyleBackColor = false;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guidelineToolStrip,
            this.exitToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guidelineToolStrip
            // 
            this.guidelineToolStrip.Name = "guidelineToolStrip";
            this.guidelineToolStrip.Size = new System.Drawing.Size(69, 20);
            this.guidelineToolStrip.Text = "&Guideline";
            this.guidelineToolStrip.Click += new System.EventHandler(this.guidelineToolStrip_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(38, 20);
            this.exitToolStrip.Text = "Exi&t";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.FirstButton);
            this.groupBox1.Controls.Add(this.PreviousButton);
            this.groupBox1.Controls.Add(this.LastButton);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(632, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 344);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SaveButton.Location = new System.Drawing.Point(23, 286);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 43);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminRegTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FiredEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(814, 617);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FiredEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiredEmp";
            this.Load += new System.EventHandler(this.FiredEmp_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeUniqueDataBaseDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SureCheckBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guidelineToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RequiredLabel;
        private ThreeUniqueDataBaseDataSet threeUniqueDataBaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private ThreeUniqueDataBaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private ThreeUniqueDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem changeBackColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.DateTimePicker hIREDATEDateTimePicker;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}