using ProjectDemo.ThreeUniqueDataBaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectDemo
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        string id, email, phone, address;
        public void ErrorMessage(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
   
        }


        private void UpdataButton_Click(object sender, EventArgs e)
        {
            if(EmptextBox.Text != "")
            {
                id = EmptextBox.Text;
                if (EmailtextBox.Text != "")
                {
                    email = EmailtextBox.Text;
                    string check = employeeTableAdapter.SearchID(threeUniqueDataBaseDataSet.Employee, EmptextBox.Text).ToString();
                    int found = int.Parse(check);
                    if (found != 1)
                    {
                        ErrorMessage("The ID Not Found", "Error");
                        this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                        EmptextBox.Focus();
                    }
                    else
                    {
                        employeeTableAdapter.UpdateEmail(EmailtextBox.Text,EmptextBox.Text);
                        this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                        MessageBox.Show("Updated Successfully For : \n"+"Employee Id : "+id+"\n New Email : "+email);
                        EmailtextBox.Text = "";
                        EmptextBox.Text = "";
                    }
                }
                else
                {
                    ErrorMessage("Please Enter Employee E-mail You Wan't to change it !", "Email Missing");
                    EmailtextBox.Focus();
                }
            }
            else
            {
                ErrorMessage("Please Enter Employee ID You Wan't to change it !", "ID Missing");
                EmptextBox.Focus();
            }
        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.threeUniqueDataBaseDataSet);
        }

        private void UpdateButton2_Click(object sender, EventArgs e)
        {
            if (EmpTextBox2.Text != "")
            {
                id = EmpTextBox2.Text;
                if (AddresstextBox.Text != "")
                {
                    address = AddresstextBox.Text;
                    string check = employeeTableAdapter.SearchID(threeUniqueDataBaseDataSet.Employee, EmpTextBox2.Text).ToString();
                    int found = int.Parse(check);
                    if (found != 1)
                    {
                        ErrorMessage("The ID Not Found", "Error");
                        this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                        EmpTextBox2.Focus();
                    }
                    else
                    {
                        employeeTableAdapter.UpdateAddress(AddresstextBox.Text, EmpTextBox2.Text);
                        this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                        MessageBox.Show("Updated Successfully For : \n" + "Employee Id : " + id + "\n New Address : " + address);
                        AddresstextBox.Text = "";
                        EmpTextBox2.Text = "";
                    }
                }
                else
                {
                    ErrorMessage("Please Enter Employee Address You Wan't to change it !", "Address Missing");
                    AddresstextBox.Focus();
                }
            }
            else
            {
                ErrorMessage("Please Enter Employee ID You Wan't to change it !", "ID Missing");
                EmpTextBox2.Focus();
            }
        }

        private void UpdatButton3_Click(object sender, EventArgs e)
        {
            if (EmpTextBox3.Text != "")
            {
                id = EmpTextBox3.Text;
                if (phonetextBox.Text != "")
                {
                    phone = phonetextBox.Text;
                    string check = employeeTableAdapter.SearchID(threeUniqueDataBaseDataSet.Employee, EmpTextBox3.Text).ToString();
                    int found = int.Parse(check);
                    if (found != 1)
                    {
                        ErrorMessage("The ID Not Found", "Error");
                        this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                        EmpTextBox3.Focus();
                    }
                    else
                    {
                        employeeTableAdapter.UpdatePhone(phonetextBox.Text, EmpTextBox3.Text);
                        this.employeeTableAdapter.Fill(threeUniqueDataBaseDataSet.Employee);
                        MessageBox.Show("Updated Successfully For : \n" + "Employee Id : " + id + "\n New Phone : " + phone);
                        phonetextBox.Text = "";
                        EmpTextBox3.Text = "";
                    }
                }
                else
                {
                    ErrorMessage("Please Enter Employee Phone You Wan't to change it !", "Phone Missing");
                    phonetextBox.Focus();
                }
            }
            else
            {
                ErrorMessage("Please Enter Employee ID You Wan't to change it !", "ID Missing");
                EmpTextBox3.Focus();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Guideline guideline = new Guideline();
            guideline.FirstLabel.Text = "In the top Right form You have a Update GroupBox with four textbox , First textbox for the Employee ID and seconde one for new Address the therd one for new phone number and the last textbox for the new email";
            guideline.SecondeLabel.Text = "In the Top left You will See EmpId GroupBox To Search For Sepecific EmployeeId";
            guideline.ThirdLabel.Text = "In the table at the end of the form you can see the Updated information or the searched information \"Make Sure you click the save Navigator \" ";
            guideline.Show();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'threeUniqueDataBaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.threeUniqueDataBaseDataSet.Employee);

        }


    }
}
